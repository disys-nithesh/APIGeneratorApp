namespace APIGenerator
{
    partial class TestConnection
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
            panel1 = new Panel();
            cmbAuthetication = new ComboBox();
            btnTestConnection = new Button();
            txtUserName = new TextBox();
            txtPassword = new MaskedTextBox();
            txtServerName = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblAuthentication = new Label();
            lblServerName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbAuthetication);
            panel1.Controls.Add(btnTestConnection);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtServerName);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblAuthentication);
            panel1.Controls.Add(lblServerName);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 270);
            panel1.TabIndex = 1;
            // 
            // cmbAuthetication
            // 
            cmbAuthetication.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAuthetication.FormattingEnabled = true;
            cmbAuthetication.Items.AddRange(new object[] { "SQL Server Authentication", "Windows Authentication" });
            cmbAuthetication.Location = new Point(207, 67);
            cmbAuthetication.Name = "cmbAuthetication";
            cmbAuthetication.Size = new Size(444, 28);
            cmbAuthetication.TabIndex = 11;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.FromArgb(54, 168, 85);
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(435, 216);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(213, 42);
            btnTestConnection.TabIndex = 10;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += button3_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(207, 117);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(444, 28);
            txtUserName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(207, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(444, 28);
            txtPassword.TabIndex = 6;
            txtPassword.TextMaskFormat = MaskFormat.IncludePrompt;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtServerName
            // 
            txtServerName.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtServerName.Location = new Point(207, 17);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(444, 28);
            txtServerName.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(26, 171);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(26, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(104, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblAuthentication
            // 
            lblAuthentication.AutoSize = true;
            lblAuthentication.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthentication.Location = new Point(26, 70);
            lblAuthentication.Name = "lblAuthentication";
            lblAuthentication.Size = new Size(150, 20);
            lblAuthentication.TabIndex = 1;
            lblAuthentication.Text = "Authentication";
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblServerName.Location = new Point(26, 18);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new Size(130, 20);
            lblServerName.TabIndex = 0;
            lblServerName.Text = "Server Name";
            // 
            // TestConnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 270);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TestConnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestConnection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbAuthetication;
        private Button btnTestConnection;
        private TextBox txtUserName;
        private MaskedTextBox txtPassword;
        private TextBox txtServerName;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblAuthentication;
        private Label lblServerName;
    }
}