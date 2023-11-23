namespace APIGenerator
{
    partial class APIGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIGenerator));
            tblpnlMain = new TableLayoutPanel();
            pnlTextLable = new Panel();
            lblConnectionSting = new Label();
            lblSourceFile = new Label();
            lblProjectLocation = new Label();
            lblProjectName = new Label();
            pnlInputFields = new Panel();
            txtConnectionString = new TextBox();
            btnAdd = new Button();
            txtSourceFilePath = new TextBox();
            btnCreate = new Button();
            txtProjectLocationPath = new TextBox();
            btnSourcefile = new Button();
            btnProjectLocation = new Button();
            txtProjectName = new TextBox();
            pnlProgressBar = new Panel();
            progressBar = new ProgressBar();
            pnlProgressStatus = new Panel();
            lblProgressStatus = new Label();
            pnlLog = new Panel();
            txtLog = new RichTextBox();
            chkExistingProject = new CheckBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialogbox = new OpenFileDialog();
            pnlHeader = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new Button();
            CreateProjectContainer = new FlowLayoutPanel();
            btnCreateProject = new Button();
            btnCPWithoutEntity = new Button();
            btnCPWithEntity = new Button();
            existingProjectContainer = new FlowLayoutPanel();
            btnExistingProject = new Button();
            btnEPWithEntity = new Button();
            btnEPWithoutEntity = new Button();
            btnCreateModal = new Button();
            CreateProjectTranstion = new System.Windows.Forms.Timer(components);
            existingProjectTanstion = new System.Windows.Forms.Timer(components);
            tblpnlMain.SuspendLayout();
            pnlTextLable.SuspendLayout();
            pnlInputFields.SuspendLayout();
            pnlProgressBar.SuspendLayout();
            pnlProgressStatus.SuspendLayout();
            pnlLog.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            CreateProjectContainer.SuspendLayout();
            existingProjectContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tblpnlMain
            // 
            tblpnlMain.BackColor = SystemColors.Window;
            tblpnlMain.ColumnCount = 2;
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 644F));
            tblpnlMain.Controls.Add(pnlTextLable, 0, 0);
            tblpnlMain.Controls.Add(pnlInputFields, 1, 0);
            tblpnlMain.Controls.Add(pnlProgressBar, 0, 3);
            tblpnlMain.Controls.Add(pnlProgressStatus, 0, 2);
            tblpnlMain.Controls.Add(pnlLog, 0, 1);
            tblpnlMain.Location = new Point(309, 57);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 4;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 218F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblpnlMain.Size = new Size(1018, 602);
            tblpnlMain.TabIndex = 0;
            // 
            // pnlTextLable
            // 
            pnlTextLable.Controls.Add(lblConnectionSting);
            pnlTextLable.Controls.Add(lblSourceFile);
            pnlTextLable.Controls.Add(lblProjectLocation);
            pnlTextLable.Controls.Add(lblProjectName);
            pnlTextLable.Dock = DockStyle.Fill;
            pnlTextLable.Location = new Point(3, 3);
            pnlTextLable.Name = "pnlTextLable";
            pnlTextLable.Size = new Size(368, 284);
            pnlTextLable.TabIndex = 0;
            // 
            // lblConnectionSting
            // 
            lblConnectionSting.AutoSize = true;
            lblConnectionSting.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblConnectionSting.Location = new Point(20, 32);
            lblConnectionSting.Name = "lblConnectionSting";
            lblConnectionSting.Size = new Size(180, 20);
            lblConnectionSting.TabIndex = 3;
            lblConnectionSting.Text = "Connection String";
            // 
            // lblSourceFile
            // 
            lblSourceFile.AutoSize = true;
            lblSourceFile.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSourceFile.Location = new Point(20, 187);
            lblSourceFile.Name = "lblSourceFile";
            lblSourceFile.Size = new Size(176, 20);
            lblSourceFile.TabIndex = 2;
            lblSourceFile.Text = "Source File(.xlsx)";
            // 
            // lblProjectLocation
            // 
            lblProjectLocation.AutoSize = true;
            lblProjectLocation.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectLocation.Location = new Point(20, 137);
            lblProjectLocation.Name = "lblProjectLocation";
            lblProjectLocation.Size = new Size(165, 20);
            lblProjectLocation.TabIndex = 1;
            lblProjectLocation.Text = "Project Location";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectName.Location = new Point(20, 86);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(137, 20);
            lblProjectName.TabIndex = 0;
            lblProjectName.Text = "Project Name";
            // 
            // pnlInputFields
            // 
            pnlInputFields.AutoSize = true;
            pnlInputFields.Controls.Add(txtConnectionString);
            pnlInputFields.Controls.Add(btnAdd);
            pnlInputFields.Controls.Add(txtSourceFilePath);
            pnlInputFields.Controls.Add(btnCreate);
            pnlInputFields.Controls.Add(txtProjectLocationPath);
            pnlInputFields.Controls.Add(btnSourcefile);
            pnlInputFields.Controls.Add(btnProjectLocation);
            pnlInputFields.Controls.Add(txtProjectName);
            pnlInputFields.Dock = DockStyle.Fill;
            pnlInputFields.Location = new Point(377, 3);
            pnlInputFields.Name = "pnlInputFields";
            pnlInputFields.Size = new Size(638, 284);
            pnlInputFields.TabIndex = 1;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Cursor = Cursors.IBeam;
            txtConnectionString.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtConnectionString.Location = new Point(20, 31);
            txtConnectionString.Margin = new Padding(0);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(478, 31);
            txtConnectionString.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(54, 168, 85);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(524, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 37);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Build";
            btnAdd.TextAlign = ContentAlignment.TopCenter;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSourceFilePath
            // 
            txtSourceFilePath.Cursor = Cursors.IBeam;
            txtSourceFilePath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceFilePath.Location = new Point(20, 176);
            txtSourceFilePath.Name = "txtSourceFilePath";
            txtSourceFilePath.Size = new Size(478, 31);
            txtSourceFilePath.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(54, 168, 85);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(137, 224);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(245, 50);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtProjectLocationPath
            // 
            txtProjectLocationPath.Cursor = Cursors.IBeam;
            txtProjectLocationPath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectLocationPath.Location = new Point(20, 126);
            txtProjectLocationPath.Name = "txtProjectLocationPath";
            txtProjectLocationPath.Size = new Size(478, 31);
            txtProjectLocationPath.TabIndex = 4;
            // 
            // btnSourcefile
            // 
            btnSourcefile.BackColor = Color.FromArgb(54, 168, 85);
            btnSourcefile.Cursor = Cursors.Hand;
            btnSourcefile.FlatStyle = FlatStyle.Flat;
            btnSourcefile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSourcefile.ForeColor = Color.White;
            btnSourcefile.Location = new Point(524, 171);
            btnSourcefile.Name = "btnSourcefile";
            btnSourcefile.Size = new Size(90, 38);
            btnSourcefile.TabIndex = 3;
            btnSourcefile.Text = "Select";
            btnSourcefile.UseVisualStyleBackColor = false;
            btnSourcefile.Click += btnSourcefile_Click;
            // 
            // btnProjectLocation
            // 
            btnProjectLocation.BackColor = Color.FromArgb(54, 168, 85);
            btnProjectLocation.Cursor = Cursors.Hand;
            btnProjectLocation.FlatStyle = FlatStyle.Flat;
            btnProjectLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProjectLocation.ForeColor = Color.White;
            btnProjectLocation.Location = new Point(524, 123);
            btnProjectLocation.Name = "btnProjectLocation";
            btnProjectLocation.Size = new Size(90, 38);
            btnProjectLocation.TabIndex = 1;
            btnProjectLocation.Text = "Select";
            btnProjectLocation.UseMnemonic = false;
            btnProjectLocation.UseVisualStyleBackColor = false;
            btnProjectLocation.Click += btnProjectLocation_Click;
            // 
            // txtProjectName
            // 
            txtProjectName.Cursor = Cursors.IBeam;
            txtProjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectName.Location = new Point(21, 75);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(478, 31);
            txtProjectName.TabIndex = 0;
            // 
            // pnlProgressBar
            // 
            tblpnlMain.SetColumnSpan(pnlProgressBar, 2);
            pnlProgressBar.Controls.Add(progressBar);
            pnlProgressBar.Dock = DockStyle.Fill;
            pnlProgressBar.Location = new Point(3, 555);
            pnlProgressBar.Name = "pnlProgressBar";
            pnlProgressBar.Size = new Size(1012, 44);
            pnlProgressBar.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1012, 44);
            progressBar.TabIndex = 1;
            // 
            // pnlProgressStatus
            // 
            tblpnlMain.SetColumnSpan(pnlProgressStatus, 2);
            pnlProgressStatus.Controls.Add(lblProgressStatus);
            pnlProgressStatus.Dock = DockStyle.Fill;
            pnlProgressStatus.Location = new Point(3, 511);
            pnlProgressStatus.Name = "pnlProgressStatus";
            pnlProgressStatus.Size = new Size(1012, 38);
            pnlProgressStatus.TabIndex = 3;
            // 
            // lblProgressStatus
            // 
            lblProgressStatus.AutoSize = true;
            lblProgressStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgressStatus.Location = new Point(3, 8);
            lblProgressStatus.Name = "lblProgressStatus";
            lblProgressStatus.Size = new Size(0, 23);
            lblProgressStatus.TabIndex = 0;
            // 
            // pnlLog
            // 
            pnlLog.AutoSize = true;
            tblpnlMain.SetColumnSpan(pnlLog, 2);
            pnlLog.Controls.Add(txtLog);
            pnlLog.Controls.Add(chkExistingProject);
            pnlLog.Dock = DockStyle.Fill;
            pnlLog.Location = new Point(3, 293);
            pnlLog.Name = "pnlLog";
            pnlLog.Size = new Size(1012, 212);
            pnlLog.TabIndex = 5;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Location = new Point(0, 0);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(1012, 212);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            // 
            // chkExistingProject
            // 
            chkExistingProject.AutoSize = true;
            chkExistingProject.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chkExistingProject.Location = new Point(640, 0);
            chkExistingProject.Name = "chkExistingProject";
            chkExistingProject.Size = new Size(204, 35);
            chkExistingProject.TabIndex = 1;
            chkExistingProject.Text = "Existing Project";
            chkExistingProject.UseVisualStyleBackColor = true;
            // 
            // openFileDialogbox
            // 
            openFileDialogbox.FileName = "openFileDialog1";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Black;
            pnlHeader.Controls.Add(panel3);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1328, 56);
            pnlHeader.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 85);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 51);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1282, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 29);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(219, 70, 59);
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(CreateProjectContainer);
            flowLayoutPanel1.Controls.Add(existingProjectContainer);
            flowLayoutPanel1.Controls.Add(btnCreateModal);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(308, 603);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(306, 72);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // CreateProjectContainer
            // 
            CreateProjectContainer.BackColor = Color.FromArgb(219, 70, 59);
            CreateProjectContainer.Controls.Add(btnCreateProject);
            CreateProjectContainer.Controls.Add(btnCPWithoutEntity);
            CreateProjectContainer.Controls.Add(btnCPWithEntity);
            CreateProjectContainer.Location = new Point(0, 72);
            CreateProjectContainer.Margin = new Padding(0);
            CreateProjectContainer.Name = "CreateProjectContainer";
            CreateProjectContainer.Size = new Size(306, 72);
            CreateProjectContainer.TabIndex = 6;
            // 
            // btnCreateProject
            // 
            btnCreateProject.FlatAppearance.BorderSize = 0;
            btnCreateProject.FlatStyle = FlatStyle.Flat;
            btnCreateProject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateProject.ForeColor = Color.White;
            btnCreateProject.Location = new Point(0, 0);
            btnCreateProject.Margin = new Padding(0);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(306, 72);
            btnCreateProject.TabIndex = 1;
            btnCreateProject.Text = "Create Project";
            btnCreateProject.UseVisualStyleBackColor = true;
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // btnCPWithoutEntity
            // 
            btnCPWithoutEntity.BackColor = Color.Black;
            btnCPWithoutEntity.FlatAppearance.BorderSize = 0;
            btnCPWithoutEntity.FlatStyle = FlatStyle.Flat;
            btnCPWithoutEntity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPWithoutEntity.ForeColor = Color.White;
            btnCPWithoutEntity.Location = new Point(0, 72);
            btnCPWithoutEntity.Margin = new Padding(0);
            btnCPWithoutEntity.Name = "btnCPWithoutEntity";
            btnCPWithoutEntity.Size = new Size(306, 82);
            btnCPWithoutEntity.TabIndex = 2;
            btnCPWithoutEntity.Text = "Without Entity";
            btnCPWithoutEntity.UseVisualStyleBackColor = false;
            btnCPWithoutEntity.Click += btnCPWithoutEntity_Click;
            // 
            // btnCPWithEntity
            // 
            btnCPWithEntity.BackColor = Color.Black;
            btnCPWithEntity.FlatAppearance.BorderSize = 0;
            btnCPWithEntity.FlatStyle = FlatStyle.Flat;
            btnCPWithEntity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCPWithEntity.ForeColor = Color.White;
            btnCPWithEntity.Location = new Point(0, 154);
            btnCPWithEntity.Margin = new Padding(0);
            btnCPWithEntity.Name = "btnCPWithEntity";
            btnCPWithEntity.Size = new Size(306, 72);
            btnCPWithEntity.TabIndex = 0;
            btnCPWithEntity.Text = "With Entity";
            btnCPWithEntity.UseVisualStyleBackColor = false;
            // 
            // existingProjectContainer
            // 
            existingProjectContainer.BackColor = Color.FromArgb(219, 70, 59);
            existingProjectContainer.Controls.Add(btnExistingProject);
            existingProjectContainer.Controls.Add(btnEPWithEntity);
            existingProjectContainer.Controls.Add(btnEPWithoutEntity);
            existingProjectContainer.Location = new Point(0, 144);
            existingProjectContainer.Margin = new Padding(0);
            existingProjectContainer.Name = "existingProjectContainer";
            existingProjectContainer.Size = new Size(306, 72);
            existingProjectContainer.TabIndex = 7;
            // 
            // btnExistingProject
            // 
            btnExistingProject.FlatAppearance.BorderSize = 0;
            btnExistingProject.FlatStyle = FlatStyle.Flat;
            btnExistingProject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExistingProject.ForeColor = Color.White;
            btnExistingProject.Location = new Point(0, 0);
            btnExistingProject.Margin = new Padding(0);
            btnExistingProject.Name = "btnExistingProject";
            btnExistingProject.Size = new Size(306, 72);
            btnExistingProject.TabIndex = 1;
            btnExistingProject.Text = "Enhance Project";
            btnExistingProject.UseVisualStyleBackColor = true;
            btnExistingProject.Click += btnExistingProject_Click;
            // 
            // btnEPWithEntity
            // 
            btnEPWithEntity.BackColor = Color.Black;
            btnEPWithEntity.FlatAppearance.BorderSize = 0;
            btnEPWithEntity.FlatStyle = FlatStyle.Flat;
            btnEPWithEntity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEPWithEntity.ForeColor = Color.White;
            btnEPWithEntity.Location = new Point(0, 72);
            btnEPWithEntity.Margin = new Padding(0);
            btnEPWithEntity.Name = "btnEPWithEntity";
            btnEPWithEntity.Size = new Size(306, 72);
            btnEPWithEntity.TabIndex = 0;
            btnEPWithEntity.Text = "With Entity";
            btnEPWithEntity.UseVisualStyleBackColor = false;
            // 
            // btnEPWithoutEntity
            // 
            btnEPWithoutEntity.BackColor = Color.Black;
            btnEPWithoutEntity.FlatAppearance.BorderSize = 0;
            btnEPWithoutEntity.FlatStyle = FlatStyle.Flat;
            btnEPWithoutEntity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEPWithoutEntity.ForeColor = Color.White;
            btnEPWithoutEntity.Location = new Point(0, 144);
            btnEPWithoutEntity.Margin = new Padding(0);
            btnEPWithoutEntity.Name = "btnEPWithoutEntity";
            btnEPWithoutEntity.Size = new Size(306, 82);
            btnEPWithoutEntity.TabIndex = 2;
            btnEPWithoutEntity.Text = "Without Entity";
            btnEPWithoutEntity.UseVisualStyleBackColor = false;
            // 
            // btnCreateModal
            // 
            btnCreateModal.FlatAppearance.BorderSize = 0;
            btnCreateModal.FlatStyle = FlatStyle.Flat;
            btnCreateModal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateModal.ForeColor = Color.White;
            btnCreateModal.Location = new Point(0, 216);
            btnCreateModal.Margin = new Padding(0);
            btnCreateModal.Name = "btnCreateModal";
            btnCreateModal.Size = new Size(306, 72);
            btnCreateModal.TabIndex = 8;
            btnCreateModal.Text = "Create Model";
            btnCreateModal.UseVisualStyleBackColor = true;
            // 
            // CreateProjectTranstion
            // 
            CreateProjectTranstion.Interval = 1;
            CreateProjectTranstion.Tick += CreateProjectTranstion_Tick;
            // 
            // existingProjectTanstion
            // 
            existingProjectTanstion.Interval = 1;
            existingProjectTanstion.Tick += existingProjectTanstion_Tick;
            // 
            // APIGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 659);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            Controls.Add(tblpnlMain);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "APIGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APIGenerator";
            Load += APIGenerator_Load;
            tblpnlMain.ResumeLayout(false);
            tblpnlMain.PerformLayout();
            pnlTextLable.ResumeLayout(false);
            pnlTextLable.PerformLayout();
            pnlInputFields.ResumeLayout(false);
            pnlInputFields.PerformLayout();
            pnlProgressBar.ResumeLayout(false);
            pnlProgressStatus.ResumeLayout(false);
            pnlProgressStatus.PerformLayout();
            pnlLog.ResumeLayout(false);
            pnlLog.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            CreateProjectContainer.ResumeLayout(false);
            existingProjectContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpnlMain;
        private Panel pnlTextLable;
        private Label lblSourceFile;
        private Label lblProjectLocation;
        private Label lblProjectName;
        private Panel pnlInputFields;
        private TextBox txtProjectName;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnProjectLocation;
        private Label lblConnectionSting;
        private Button btnSourcefile;
        private OpenFileDialog openFileDialogbox;
        private ProgressBar progressBar;
        private Panel pnlProgressBar;
        private Panel pnlProgressStatus;
        private Label lblProgressStatus;
        private CheckBox chkExistingProject;
        private CheckBox chk;
        private Button btnCreate;
        private Panel pnlLog;
        private RichTextBox txtLog;
        private TextBox txtSourceFilePath;
        private TextBox txtProjectLocationPath;
        private RadioButton radioButton1;
        private Panel pnlHeader;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHome;
        private FlowLayoutPanel CreateProjectContainer;
        private Button btnCreateProject;
        private Button btnCPWithEntity;
        private Button btnCPWithoutEntity;
        private System.Windows.Forms.Timer CreateProjectTranstion;
        private FlowLayoutPanel existingProjectContainer;
        private Button btnExistingProject;
        private Button btnEPWithoutEntity;
        private Button btnEPWithEntity;
        private System.Windows.Forms.Timer existingProjectTanstion;
        private Button btnCreateModal;
        private Button btnAdd;
        public TextBox txtConnectionString;
    }
}