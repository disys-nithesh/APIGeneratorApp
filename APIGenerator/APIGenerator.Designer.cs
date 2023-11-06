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
            tblpnlMain = new TableLayoutPanel();
            pnlTextLable = new Panel();
            lblConnectionSting = new Label();
            lblSourceFile = new Label();
            lblProjectLocation = new Label();
            lblProjectName = new Label();
            pnlInputFields = new Panel();
            txtSourceFilePath = new TextBox();
            txtProjectLocationPath = new TextBox();
            btnSourcefile = new Button();
            txtConnectionString = new TextBox();
            btnProjectLocation = new Button();
            txtProjectName = new TextBox();
            pnlProgressBar = new Panel();
            progressBar = new ProgressBar();
            pnlProgressStatus = new Panel();
            lblProgressStatus = new Label();
            pnlCheckbox = new Panel();
            chkAddModel = new CheckBox();
            optExistingProject = new RadioButton();
            chkNewProject = new CheckBox();
            optNewProject = new RadioButton();
            btnCreate = new Button();
            chkWithEntity = new CheckBox();
            pnlLog = new Panel();
            txtLog = new RichTextBox();
            chkExistingProject = new CheckBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialogbox = new OpenFileDialog();
            tblpnlMain.SuspendLayout();
            pnlTextLable.SuspendLayout();
            pnlInputFields.SuspendLayout();
            pnlProgressBar.SuspendLayout();
            pnlProgressStatus.SuspendLayout();
            pnlCheckbox.SuspendLayout();
            pnlLog.SuspendLayout();
            SuspendLayout();
            // 
            // tblpnlMain
            // 
            tblpnlMain.BackColor = SystemColors.Window;
            tblpnlMain.ColumnCount = 3;
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 605F));
            tblpnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 285F));
            tblpnlMain.Controls.Add(pnlTextLable, 0, 0);
            tblpnlMain.Controls.Add(pnlInputFields, 1, 0);
            tblpnlMain.Controls.Add(pnlProgressBar, 0, 3);
            tblpnlMain.Controls.Add(pnlProgressStatus, 0, 2);
            tblpnlMain.Controls.Add(pnlCheckbox, 2, 0);
            tblpnlMain.Controls.Add(pnlLog, 0, 1);
            tblpnlMain.Dock = DockStyle.Fill;
            tblpnlMain.Location = new Point(0, 0);
            tblpnlMain.Name = "tblpnlMain";
            tblpnlMain.RowCount = 4;
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 218F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblpnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblpnlMain.Size = new Size(1135, 608);
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
            pnlTextLable.Size = new Size(239, 290);
            pnlTextLable.TabIndex = 0;
            // 
            // lblConnectionSting
            // 
            lblConnectionSting.AutoSize = true;
            lblConnectionSting.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblConnectionSting.Location = new Point(13, 32);
            lblConnectionSting.Name = "lblConnectionSting";
            lblConnectionSting.Size = new Size(208, 31);
            lblConnectionSting.TabIndex = 3;
            lblConnectionSting.Text = "Connection String";
            // 
            // lblSourceFile
            // 
            lblSourceFile.AutoSize = true;
            lblSourceFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSourceFile.Location = new Point(13, 224);
            lblSourceFile.Name = "lblSourceFile";
            lblSourceFile.Size = new Size(196, 31);
            lblSourceFile.TabIndex = 2;
            lblSourceFile.Text = "Source File(.xlsx)";
            // 
            // lblProjectLocation
            // 
            lblProjectLocation.AutoSize = true;
            lblProjectLocation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectLocation.Location = new Point(13, 163);
            lblProjectLocation.Name = "lblProjectLocation";
            lblProjectLocation.Size = new Size(189, 31);
            lblProjectLocation.TabIndex = 1;
            lblProjectLocation.Text = "Project Location";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjectName.Location = new Point(13, 101);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(159, 31);
            lblProjectName.TabIndex = 0;
            lblProjectName.Text = "Project Name";
            // 
            // pnlInputFields
            // 
            pnlInputFields.AutoSize = true;
            pnlInputFields.Controls.Add(txtSourceFilePath);
            pnlInputFields.Controls.Add(txtProjectLocationPath);
            pnlInputFields.Controls.Add(btnSourcefile);
            pnlInputFields.Controls.Add(txtConnectionString);
            pnlInputFields.Controls.Add(btnProjectLocation);
            pnlInputFields.Controls.Add(txtProjectName);
            pnlInputFields.Dock = DockStyle.Fill;
            pnlInputFields.Location = new Point(248, 3);
            pnlInputFields.Name = "pnlInputFields";
            pnlInputFields.Size = new Size(599, 290);
            pnlInputFields.TabIndex = 1;
            // 
            // txtSourceFilePath
            // 
            txtSourceFilePath.Cursor = Cursors.IBeam;
            txtSourceFilePath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceFilePath.Location = new Point(17, 222);
            txtSourceFilePath.Name = "txtSourceFilePath";
            txtSourceFilePath.Size = new Size(478, 31);
            txtSourceFilePath.TabIndex = 5;
            // 
            // txtProjectLocationPath
            // 
            txtProjectLocationPath.Cursor = Cursors.IBeam;
            txtProjectLocationPath.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectLocationPath.Location = new Point(17, 161);
            txtProjectLocationPath.Name = "txtProjectLocationPath";
            txtProjectLocationPath.Size = new Size(478, 31);
            txtProjectLocationPath.TabIndex = 4;
            // 
            // btnSourcefile
            // 
            btnSourcefile.BackColor = SystemColors.ControlLight;
            btnSourcefile.Cursor = Cursors.Hand;
            btnSourcefile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSourcefile.ForeColor = SystemColors.ActiveCaptionText;
            btnSourcefile.Location = new Point(501, 217);
            btnSourcefile.Name = "btnSourcefile";
            btnSourcefile.Size = new Size(88, 38);
            btnSourcefile.TabIndex = 3;
            btnSourcefile.Text = "Choose File";
            btnSourcefile.UseVisualStyleBackColor = false;
            btnSourcefile.Click += btnSourcefile_Click;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Cursor = Cursors.IBeam;
            txtConnectionString.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtConnectionString.Location = new Point(17, 32);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(478, 31);
            txtConnectionString.TabIndex = 2;
            // 
            // btnProjectLocation
            // 
            btnProjectLocation.BackColor = SystemColors.ControlLight;
            btnProjectLocation.Cursor = Cursors.Hand;
            btnProjectLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProjectLocation.ForeColor = SystemColors.ActiveCaptionText;
            btnProjectLocation.Location = new Point(501, 156);
            btnProjectLocation.Name = "btnProjectLocation";
            btnProjectLocation.Size = new Size(90, 38);
            btnProjectLocation.TabIndex = 1;
            btnProjectLocation.Text = "Choose Folder";
            btnProjectLocation.UseMnemonic = false;
            btnProjectLocation.UseVisualStyleBackColor = false;
            btnProjectLocation.Click += btnProjectLocation_Click;
            // 
            // txtProjectName
            // 
            txtProjectName.Cursor = Cursors.IBeam;
            txtProjectName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProjectName.Location = new Point(17, 101);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(478, 31);
            txtProjectName.TabIndex = 0;
            // 
            // pnlProgressBar
            // 
            tblpnlMain.SetColumnSpan(pnlProgressBar, 3);
            pnlProgressBar.Controls.Add(progressBar);
            pnlProgressBar.Dock = DockStyle.Fill;
            pnlProgressBar.Location = new Point(3, 561);
            pnlProgressBar.Name = "pnlProgressBar";
            pnlProgressBar.Size = new Size(1129, 44);
            pnlProgressBar.TabIndex = 2;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1129, 44);
            progressBar.TabIndex = 1;
            // 
            // pnlProgressStatus
            // 
            tblpnlMain.SetColumnSpan(pnlProgressStatus, 3);
            pnlProgressStatus.Controls.Add(lblProgressStatus);
            pnlProgressStatus.Dock = DockStyle.Fill;
            pnlProgressStatus.Location = new Point(3, 517);
            pnlProgressStatus.Name = "pnlProgressStatus";
            pnlProgressStatus.Size = new Size(1129, 38);
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
            // pnlCheckbox
            // 
            pnlCheckbox.Controls.Add(chkAddModel);
            pnlCheckbox.Controls.Add(optExistingProject);
            pnlCheckbox.Controls.Add(chkNewProject);
            pnlCheckbox.Controls.Add(optNewProject);
            pnlCheckbox.Controls.Add(btnCreate);
            pnlCheckbox.Controls.Add(chkWithEntity);
            pnlCheckbox.Dock = DockStyle.Fill;
            pnlCheckbox.Location = new Point(853, 3);
            pnlCheckbox.Name = "pnlCheckbox";
            pnlCheckbox.Size = new Size(279, 290);
            pnlCheckbox.TabIndex = 4;
            // 
            // chkAddModel
            // 
            chkAddModel.AutoSize = true;
            chkAddModel.Cursor = Cursors.Hand;
            chkAddModel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chkAddModel.Location = new Point(46, 183);
            chkAddModel.Name = "chkAddModel";
            chkAddModel.Size = new Size(155, 35);
            chkAddModel.TabIndex = 6;
            chkAddModel.Text = "Add Model";
            chkAddModel.UseVisualStyleBackColor = true;
            // 
            // optExistingProject
            // 
            optExistingProject.AutoSize = true;
            optExistingProject.Cursor = Cursors.Hand;
            optExistingProject.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            optExistingProject.Location = new Point(46, 79);
            optExistingProject.Name = "optExistingProject";
            optExistingProject.Size = new Size(203, 35);
            optExistingProject.TabIndex = 5;
            optExistingProject.Text = "Existing Project";
            optExistingProject.UseVisualStyleBackColor = true;
            optExistingProject.CheckedChanged += optExistingProject_CheckedChanged;
            // 
            // chkNewProject
            // 
            chkNewProject.AutoSize = true;
            chkNewProject.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chkNewProject.Location = new Point(0, 289);
            chkNewProject.Name = "chkNewProject";
            chkNewProject.Size = new Size(166, 35);
            chkNewProject.TabIndex = 0;
            chkNewProject.Text = "New Project";
            chkNewProject.UseVisualStyleBackColor = true;
            // 
            // optNewProject
            // 
            optNewProject.AutoSize = true;
            optNewProject.Checked = true;
            optNewProject.Cursor = Cursors.Hand;
            optNewProject.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            optNewProject.Location = new Point(46, 28);
            optNewProject.Name = "optNewProject";
            optNewProject.Size = new Size(165, 35);
            optNewProject.TabIndex = 0;
            optNewProject.TabStop = true;
            optNewProject.Text = "New Project";
            optNewProject.UseVisualStyleBackColor = true;
            optNewProject.CheckedChanged += optNewProject_CheckedChanged;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ControlLight;
            btnCreate.Cursor = Cursors.IBeam;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.ActiveCaptionText;
            btnCreate.Location = new Point(16, 233);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(245, 50);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // chkWithEntity
            // 
            chkWithEntity.AutoSize = true;
            chkWithEntity.Cursor = Cursors.Hand;
            chkWithEntity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chkWithEntity.Location = new Point(46, 132);
            chkWithEntity.Name = "chkWithEntity";
            chkWithEntity.Size = new Size(158, 35);
            chkWithEntity.TabIndex = 2;
            chkWithEntity.Text = "With Entity";
            chkWithEntity.UseVisualStyleBackColor = true;
            // 
            // pnlLog
            // 
            pnlLog.AutoSize = true;
            tblpnlMain.SetColumnSpan(pnlLog, 3);
            pnlLog.Controls.Add(txtLog);
            pnlLog.Controls.Add(chkExistingProject);
            pnlLog.Dock = DockStyle.Fill;
            pnlLog.Location = new Point(3, 299);
            pnlLog.Name = "pnlLog";
            pnlLog.Size = new Size(1129, 212);
            pnlLog.TabIndex = 5;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Location = new Point(0, 0);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(1129, 212);
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
            // APIGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 608);
            Controls.Add(tblpnlMain);
            MaximizeBox = false;
            Name = "APIGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "APIGenerator";
            tblpnlMain.ResumeLayout(false);
            tblpnlMain.PerformLayout();
            pnlTextLable.ResumeLayout(false);
            pnlTextLable.PerformLayout();
            pnlInputFields.ResumeLayout(false);
            pnlInputFields.PerformLayout();
            pnlProgressBar.ResumeLayout(false);
            pnlProgressStatus.ResumeLayout(false);
            pnlProgressStatus.PerformLayout();
            pnlCheckbox.ResumeLayout(false);
            pnlCheckbox.PerformLayout();
            pnlLog.ResumeLayout(false);
            pnlLog.PerformLayout();
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
        private TextBox txtConnectionString;
        private OpenFileDialog openFileDialogbox;
        private ProgressBar progressBar;
        private Panel pnlProgressBar;
        private Panel pnlProgressStatus;
        private Label lblProgressStatus;
        private Panel pnlCheckbox;
        private CheckBox chkExistingProject;
        private CheckBox chk;
        private CheckBox chkWithEntity;
        private Button btnCreate;
        private Panel pnlLog;
        private RichTextBox txtLog;
        private TextBox txtSourceFilePath;
        private TextBox txtProjectLocationPath;
        private RadioButton radioButton1;
        private CheckBox chkNewProject;
        private RadioButton optNewProject;
        private RadioButton optExistingProject;
        private CheckBox chkAddModel;
    }
}