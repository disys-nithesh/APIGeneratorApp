using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using System.Diagnostics;
using System.Text;
using static OfficeOpenXml.ExcelErrorValue;

namespace APIGenerator
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Tuple<string, string>>> sheetsData = new Dictionary<string, List<Tuple<string, string>>>();
        public MainForm()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void modelClassUploadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    // Iterate through all worksheets in the Excel package
                    foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                    {
                        List<Tuple<string, string>> sheetData = new List<Tuple<string, string>>();

                        int rowCount = worksheet.Dimension.End.Row;

                        // Assuming data starts from the second row as first row contains column names
                        for (int row = 2; row <= rowCount; row++)
                        {
                            string valueA = worksheet.Cells[row, 1].Text; // Column A
                            string valueB = worksheet.Cells[row, 2].Text; // Column B

                            sheetData.Add(new Tuple<string, string>(valueA, valueB));
                        }

                        sheetsData.Add(worksheet.Name, sheetData);
                    }
                }

                // Now, sheetsData dictionary contains all the sheet names and their corresponding column A and B values.
            }
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowOrHideProgressBar("show");
                ShowOrHideLabel("show");
                generateButton.Enabled = false;  // Disable the button
                UpdateLabel("validating input...");

                string apiName = apiNameText.Text;
                string apiPath = apiPathText.Text;
                string connectionString = connectionStringText.Text;

                if (string.IsNullOrEmpty(apiName) || string.IsNullOrEmpty(apiPath))
                {
                    MessageBox.Show("API Name and Path must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                UpdateLabel("creating projects...");
                await Task.Run(() => GenerateWebAPI(apiName, apiPath, connectionString));
                UpdateLabel("task completed...");
                UpdateProgressBar(100);

                MessageBox.Show("API generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while API generation! Details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ShowOrHideProgressBar("hide");
                ShowOrHideLabel("hide");
                generateButton.Enabled = true;  // Re-enable the button
            }
        }

        private void GenerateWebAPI(string apiName, string apiPath, string connectionString)
        {
            // Create a WebAPI project
            ExecuteCommand($"new webapi -n {apiName} -o {apiPath}/{apiName}.WebAPI");

            // Set the connection string in appsettings.json
            string appSettingsPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.json");
            SetConnectionString(appSettingsPath, connectionString);

            // Set the connection string in appsettings.Development.json
            string appSettingsDevPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "appsettings.Development.json");
            SetConnectionString(appSettingsDevPath, connectionString);

            // Create a solution
            ExecuteCommand($"new sln -n {apiName} -o {apiPath}");

            // Create Application, Domain, and Infrastructure projects
            ExecuteCommand($"new classlib -n {apiName}.Application -o {apiPath}/{apiName}.Application");
            ExecuteCommand($"new classlib -n {apiName}.Domain -o {apiPath}/{apiName}.Domain");
            ExecuteCommand($"new classlib -n {apiName}.Infrastructure -o {apiPath}/{apiName}.Infrastructure");

            Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Domain", "Entities"));
            Directory.CreateDirectory(Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data"));

            // Add all projects to the solution
            ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.WebAPI/{apiName}.csproj");
            ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.Application/{apiName}.Application.csproj");
            ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.Domain/{apiName}.Domain.csproj");
            ExecuteCommand($"sln {apiPath}/{apiName}.sln add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj");

            UpdateProgressBar(25);
            UpdateLabel("adding project dependencies...");

            // You can even add project references
            ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj reference {apiPath}/{apiName}.Application/{apiName}.Application.csproj");
            ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj reference {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj");
            ExecuteCommand($"add {apiPath}/{apiName}.Application/{apiName}.Application.csproj reference {apiPath}/{apiName}.Domain/{apiName}.Domain.csproj");
            ExecuteCommand($"add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj reference {apiPath}/{apiName}.Domain/{apiName}.Domain.csproj");
            ExecuteCommand($"add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj reference {apiPath}/{apiName}.Application/{apiName}.Application.csproj");

            // Add EF Core packages to the Infrastructure and WebAPI projects
            ExecuteCommand($"add {apiPath}/{apiName}.Infrastructure/{apiName}.Infrastructure.csproj package Microsoft.EntityFrameworkCore.SqlServer");
            ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.EntityFrameworkCore.Design");
            ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.EntityFrameworkCore.Tools");
            ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.AspNetCore.Hosting");
            ExecuteCommand($"add {apiPath}/{apiName}.WebAPI/{apiName}.csproj package Microsoft.Extensions.Hosting");
            ExecuteCommand("tool install --global dotnet-ef");

            UpdateLabel("generating classes...");

            string dbContextPath = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Data", "ApplicationDbContext.cs");
            GenerateApplicationDbContext(dbContextPath, $"{apiName}.Infrastructure");

            string modelClassPath = Path.Combine(apiPath, $"{apiName}.Domain", "Entities");
            GenerateModelClassesFromData(sheetsData, modelClassPath);

            // Now update ApplicationDbContext with models
            UpdateApplicationDbContextWithModels(sheetsData, dbContextPath);

            CreateStartupFile(apiName, apiPath);
            CreateOrUpdateProgramFile(apiName, apiPath);

            UpdateProgressBar(50);
            UpdateLabel("running migrations...");

            string migrationPath = Path.Combine(apiPath, $"{apiName}.WebAPI");
            string infrastructurePath = Path.Combine(apiPath, $"{apiName}.Infrastructure");
            RunMigrationsAndUpdates(migrationPath, infrastructurePath, "InitialCreate", "ApplicationDbContext");

            UpdateProgressBar(75);
            UpdateLabel("creating repositories...");

            // Generate repositories
            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                GenerateRepositoryInterface(apiName, apiPath, className);
                GenerateRepositoryImplementation(apiName, apiPath, className);
            }

            // Generate services
            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                GenerateServiceInterface(apiName, apiPath, className);
                GenerateServiceImplementation(apiName, apiPath, className);
            }

            UpdateStartupForRepositoriesAndServices(apiName, apiPath);
        }

        private void GenerateModelClassesFromData(Dictionary<string, List<Tuple<string, string>>> sheetsData, string modelClassPath)
        {
            if (!Directory.Exists(modelClassPath))
            {
                Directory.CreateDirectory(modelClassPath);
            }

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                var properties = sheetEntry.Value;

                StringBuilder classDefinition = new StringBuilder();
                classDefinition.AppendLine($"public class {className}");
                classDefinition.AppendLine("{");

                foreach (var property in properties)
                {
                    classDefinition.AppendLine($"    public {property.Item2} {property.Item1} {{ get; set; }}");
                }

                classDefinition.AppendLine("}");

                File.WriteAllText($"{modelClassPath}/{className}.cs", classDefinition.ToString());
            }
        }

        private void GenerateApplicationDbContext(string dbContextPath, string namespaceName)
        {
            StringBuilder dbContextContent = new StringBuilder();

            dbContextContent.AppendLine("using Microsoft.EntityFrameworkCore;");
            dbContextContent.AppendLine();
            dbContextContent.AppendLine($"namespace {namespaceName}.Data");
            dbContextContent.AppendLine("{");
            dbContextContent.AppendLine("    public class ApplicationDbContext : DbContext");
            dbContextContent.AppendLine("    {");
            dbContextContent.AppendLine("        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)");
            dbContextContent.AppendLine("        {");
            dbContextContent.AppendLine("        }");
            dbContextContent.AppendLine();
            dbContextContent.AppendLine("        // DBSets go here");
            dbContextContent.AppendLine("    }");
            dbContextContent.AppendLine("}");

            File.WriteAllText(dbContextPath, dbContextContent.ToString());
        }

        private void UpdateApplicationDbContextWithModels(Dictionary<string, List<Tuple<string, string>>> sheetsData, string dbContextPath)
        {
            StringBuilder dbContextAdditions = new StringBuilder();

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                dbContextAdditions.AppendLine($"public DbSet<{className}> {className}Set {{ get; set; }}");
            }

            // Now, you can append these DbSet properties to the ApplicationDbContext
            string dbContextContent = File.ReadAllText(dbContextPath);
            int insertionIndex = dbContextContent.IndexOf("// DBSets go here");

            if (insertionIndex > -1)
            {
                dbContextContent = dbContextContent.Insert(insertionIndex, dbContextAdditions.ToString());
                File.WriteAllText(dbContextPath, dbContextContent);
            }
        }

        private void SetConnectionString(string filePath, string connectionString)
        {
            if (File.Exists(filePath))
            {
                // Read the JSON file
                var json = JObject.Parse(File.ReadAllText(filePath));

                // Set the connection string
                if (json["ConnectionStrings"] == null)
                    json["ConnectionStrings"] = new JObject();

                json["ConnectionStrings"]["DefaultConnection"] = connectionString;

                // Save the updated JSON back to the file
                File.WriteAllText(filePath, json.ToString());
            }
            else
            {
                Debug.WriteLine($"Error: {filePath} does not exist.");
            }
        }

        private void CreateStartupFile(string apiName, string apiPath)
        {
            string startupFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Startup.cs");

            string startupFileContent = @"
using " + apiName + @".Application.IRepository;
using " + apiName + @".Application.IService;
using " + apiName + @".Infrastructure.Data;
using " + apiName + @".Infrastructure.Repository;
using " + apiName + @".Infrastructure.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace " + apiName + @".WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(""DefaultConnection"")));

            RegisterDependencies(services);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(""v1"", new OpenApiInfo { Title = """ + apiName + @""", Version = ""v1"" });
            });

            AddCors(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint(""/swagger/v1/swagger.json"", """ + apiName + @" v1""));

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(""AllowAll"");
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ConfigureHealthCheck(app);
        }

        private void RegisterDependencies(IServiceCollection services)
        {
            // Add dependency injection registrations here.
        }

        private void AddCors(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: ""AllowAll"",
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin()
                                             .AllowAnyMethod()
                                             .AllowAnyHeader();
                                  });
            });
        }

        private void ConfigureHealthCheck(IApplicationBuilder app)
        {
            // Add health check configurations here.
        }

        private void ConfigureSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint(""/swagger/v1/swagger.json"", """ + apiName + @" v1"");
            });
        }
    }
}";

            File.WriteAllText(startupFilePath, startupFileContent);
        }

        private void CreateOrUpdateProgramFile(string apiName, string apiPath)
        {
            string programFilePath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Program.cs");

            string programFileContent = @"
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace " + apiName + @".WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}";

            File.WriteAllText(programFilePath, programFileContent);
        }

        public void RunMigrationsAndUpdates(string apiProjectPath, string infrastructureProjectPath, string migrationName, string dbContextName)
        {
            // Add a new migration
            ExecuteCommand($"ef migrations add {migrationName} --context {dbContextName} --startup-project {apiProjectPath} --project {infrastructureProjectPath}", apiProjectPath);

            // Update the database with the new migration
            ExecuteCommand($"ef database update --context {dbContextName} --startup-project {apiProjectPath} --project {infrastructureProjectPath}", apiProjectPath);
        }

        private void GenerateRepositoryInterface(string apiName, string apiPath, string className)
        {
            StringBuilder interfaceContent = new StringBuilder();
            interfaceContent.AppendLine($"namespace {apiName}.Application.IRepository");
            interfaceContent.AppendLine("{");
            interfaceContent.AppendLine($"    public interface I{className}Repository");
            interfaceContent.AppendLine("    {");
            interfaceContent.AppendLine($"        IEnumerable<{className}> GetAll();");
            interfaceContent.AppendLine($"        {className} GetById(int id);");
            interfaceContent.AppendLine($"        void Add({className} entity);");
            interfaceContent.AppendLine($"        void Update({className} entity);");
            interfaceContent.AppendLine("        void Delete(int id);");
            interfaceContent.AppendLine("    }");
            interfaceContent.AppendLine("}");
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IRepository");
            Directory.CreateDirectory(interfaceDirectory); // Create the directory if it doesn't exist
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Repository.cs");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }

        private void GenerateRepositoryImplementation(string apiName, string apiPath, string className)
        {
            StringBuilder classContent = new StringBuilder();
            classContent.AppendLine($"using {apiName}.Infrastructure.Data;");
            classContent.AppendLine($"using {apiName}.Application.IRepository;");
            classContent.AppendLine();
            classContent.AppendLine($"namespace {apiName}.Infrastructure.Repository");
            classContent.AppendLine("{");
            classContent.AppendLine($"    public class {className}Repository : I{className}Repository");
            classContent.AppendLine("    {");
            classContent.AppendLine("        private readonly ApplicationDbContext _context;");
            classContent.AppendLine();
            classContent.AppendLine($"        public {className}Repository(ApplicationDbContext context)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _context = context;");
            classContent.AppendLine("        }");
            classContent.AppendLine();
            classContent.AppendLine($"        public IEnumerable<{className}> GetAll()");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            return _context.{className}Set.ToList();");
            classContent.AppendLine("        }");

            // Add method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Add({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            _context.{className}Set.Add(entity);");
            classContent.AppendLine("        }");

            // Update method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Update({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            _context.{className}Set.Update(entity);");
            classContent.AppendLine("        }");

            // Delete method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Delete(int id)");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            var entityToDelete = _context.{className}Set.FirstOrDefault(e => e.Id == id);");
            classContent.AppendLine($"            if (entityToDelete != null)");
            classContent.AppendLine("            {");
            classContent.AppendLine($"                _context.{className}Set.Remove(entityToDelete);");
            classContent.AppendLine("            }");
            classContent.AppendLine("        }");

            // GetById method
            classContent.AppendLine();
            classContent.AppendLine($"        public {className} GetById(int id)");
            classContent.AppendLine("        {");
            classContent.AppendLine($"            return _context.{className}Set.FirstOrDefault(e => e.Id == id);");
            classContent.AppendLine("        }");

            classContent.AppendLine("    }");
            classContent.AppendLine("}");

            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Repository");
            Directory.CreateDirectory(classDirectory); // Create the directory if it doesn't exist
            string classPath = Path.Combine(classDirectory, $"{className}Repository.cs");
            File.WriteAllText(classPath, classContent.ToString());
        }

        private void GenerateServiceInterface(string apiName, string apiPath, string className)
        {
            StringBuilder interfaceContent = new StringBuilder();
            interfaceContent.AppendLine($"namespace {apiName}.Application.IService");
            interfaceContent.AppendLine("{");
            interfaceContent.AppendLine($"    public interface I{className}Service");
            interfaceContent.AppendLine("    {");
            interfaceContent.AppendLine($"        IEnumerable<{className}> GetAll();");
            interfaceContent.AppendLine($"        {className} GetById(int id);");
            interfaceContent.AppendLine($"        void Add({className} entity);");
            interfaceContent.AppendLine($"        void Update({className} entity);");
            interfaceContent.AppendLine("        void Delete(int id);");
            interfaceContent.AppendLine("    }");
            interfaceContent.AppendLine("}");
            string interfaceDirectory = Path.Combine(apiPath, $"{apiName}.Application", "IService");
            Directory.CreateDirectory(interfaceDirectory);
            string interfacePath = Path.Combine(interfaceDirectory, $"I{className}Service.cs");
            File.WriteAllText(interfacePath, interfaceContent.ToString());
        }

        private void GenerateServiceImplementation(string apiName, string apiPath, string className)
        {
            StringBuilder classContent = new StringBuilder();
            classContent.AppendLine($"using {apiName}.Application.IRepository;");
            classContent.AppendLine($"using {apiName}.Application.IService;");
            classContent.AppendLine();
            classContent.AppendLine($"namespace {apiName}.Infrastructure.Service");
            classContent.AppendLine("{");
            classContent.AppendLine($"    public class {className}Service : I{className}Service");
            classContent.AppendLine("    {");
            classContent.AppendLine($"        private readonly I{className}Repository _repository;");
            classContent.AppendLine();
            classContent.AppendLine($"        public {className}Service(I{className}Repository repository)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _repository = repository;");
            classContent.AppendLine("        }");
            classContent.AppendLine();

            // GetAll Method
            classContent.AppendLine($"        public IEnumerable<{className}> GetAll()");
            classContent.AppendLine("        {");
            classContent.AppendLine("            return _repository.GetAll();");
            classContent.AppendLine("        }");

            // GetById Method
            classContent.AppendLine();
            classContent.AppendLine($"        public {className} GetById(int id)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            return _repository.GetById(id);");
            classContent.AppendLine("        }");

            // Add Method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Add({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _repository.Add(entity);");
            classContent.AppendLine("        }");

            // Update Method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Update({className} entity)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _repository.Update(entity);");
            classContent.AppendLine("        }");

            // Delete Method
            classContent.AppendLine();
            classContent.AppendLine($"        public void Delete(int id)");
            classContent.AppendLine("        {");
            classContent.AppendLine("            _repository.Delete(id);");
            classContent.AppendLine("        }");

            classContent.AppendLine("    }");
            classContent.AppendLine("}");

            string classDirectory = Path.Combine(apiPath, $"{apiName}.Infrastructure", "Service");
            Directory.CreateDirectory(classDirectory);
            string classPath = Path.Combine(classDirectory, $"{className}Service.cs");
            File.WriteAllText(classPath, classContent.ToString());
        }

        private void UpdateStartupForRepositoriesAndServices(string apiName, string apiPath)
        {
            string startupPath = Path.Combine(apiPath, $"{apiName}.WebAPI", "Startup.cs");
            StringBuilder sb = new StringBuilder();

            foreach (var sheetEntry in sheetsData)
            {
                string className = sheetEntry.Key;
                sb.AppendLine($"services.AddScoped<I{className}Repository, {className}Repository>();");
                sb.AppendLine($"services.AddScoped<I{className}Service, {className}Service>();");
            }

            // Read existing Startup.cs content and find a place to insert the new lines
            string existingContent = File.ReadAllText(startupPath);
            int insertionIndex = existingContent.IndexOf("// Add dependency injection registrations here.");

            if (insertionIndex > -1)
            {
                existingContent = existingContent.Insert(insertionIndex, sb.ToString());
                File.WriteAllText(startupPath, existingContent);
            }
        }

        private void ExecuteCommand(string command, string workingDirectory = null)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDirectory ?? Directory.GetCurrentDirectory() // use the provided directory or the current one
                }
            };

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd(); // Capture error output

            process.WaitForExit();

            if (!string.IsNullOrWhiteSpace(error))
            {
                Debug.WriteLine("Error: " + error);
            }
            Debug.WriteLine(output);
        }

        private void UpdateProgressBar(int value)
        {
            if (generateProgressBar.InvokeRequired)
            {
                // If this method is being called from a different thread, invoke it on the main UI thread.
                this.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                generateProgressBar.Value = value;
            }
        }

        private void UpdateLabel(string text)
        {
            if (generateLabel.InvokeRequired)
            {
                // If this method is being called from a different thread, invoke it on the main UI thread.
                this.Invoke(new Action<string>(UpdateLabel), text);
            }
            else
            {
                generateLabel.Text = text;
            }
        }

        private void ShowOrHideProgressBar(string text)
        {
            if (generateProgressBar.InvokeRequired)
            {
                // If this method is being called from a different thread, invoke it on the main UI thread.
                this.Invoke(new Action<string>(ShowOrHideProgressBar), text);
            }
            else
            {
                if (text == "show")
                {
                    generateProgressBar.Visible = true;  // Show the ProgressBar
                }
                else
                {
                    generateProgressBar.Visible = false;  // Hide the ProgressBar
                }
            }

        }

        private void ShowOrHideLabel(string text)
        {
            if (generateLabel.InvokeRequired)
            {
                // If this method is being called from a different thread, invoke it on the main UI thread.
                this.Invoke(new Action<string>(ShowOrHideLabel), text);
            }
            else
            {
                if (text == "show")
                {
                    generateLabel.Visible = true;  // Show the Label
                }
                else
                {
                    generateLabel.Visible = false;  // Hide the Label
                }
            }

        }
    }
}