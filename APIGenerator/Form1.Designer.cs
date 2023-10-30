namespace APIGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.apiNameLabel = new System.Windows.Forms.Label();
            this.apiNameText = new System.Windows.Forms.TextBox();
            this.apiPathLabel = new System.Windows.Forms.Label();
            this.apiPathText = new System.Windows.Forms.TextBox();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.connectionStringText = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.modelClassUploadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.apiGeneratorLabel = new System.Windows.Forms.Label();
            this.generateProgressBar = new System.Windows.Forms.ProgressBar();
            this.generateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apiNameLabel
            // 
            this.apiNameLabel.AutoSize = true;
            this.apiNameLabel.Location = new System.Drawing.Point(75, 112);
            this.apiNameLabel.Name = "apiNameLabel";
            this.apiNameLabel.Size = new System.Drawing.Size(149, 41);
            this.apiNameLabel.TabIndex = 1;
            this.apiNameLabel.Text = "API Name";
            // 
            // apiNameText
            // 
            this.apiNameText.Location = new System.Drawing.Point(350, 109);
            this.apiNameText.Name = "apiNameText";
            this.apiNameText.Size = new System.Drawing.Size(345, 47);
            this.apiNameText.TabIndex = 2;
            // 
            // apiPathLabel
            // 
            this.apiPathLabel.AutoSize = true;
            this.apiPathLabel.Location = new System.Drawing.Point(75, 192);
            this.apiPathLabel.Name = "apiPathLabel";
            this.apiPathLabel.Size = new System.Drawing.Size(128, 41);
            this.apiPathLabel.TabIndex = 3;
            this.apiPathLabel.Text = "API Path";
            // 
            // apiPathText
            // 
            this.apiPathText.Location = new System.Drawing.Point(350, 189);
            this.apiPathText.Name = "apiPathText";
            this.apiPathText.Size = new System.Drawing.Size(345, 47);
            this.apiPathText.TabIndex = 4;
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Location = new System.Drawing.Point(75, 277);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(256, 41);
            this.connectionStringLabel.TabIndex = 5;
            this.connectionStringLabel.Text = "Connection String";
            // 
            // connectionStringText
            // 
            this.connectionStringText.Location = new System.Drawing.Point(350, 274);
            this.connectionStringText.Name = "connectionStringText";
            this.connectionStringText.Size = new System.Drawing.Size(345, 47);
            this.connectionStringText.TabIndex = 6;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.generateButton.Location = new System.Drawing.Point(304, 456);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(191, 57);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "GENERATE";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // modelClassUploadButton
            // 
            this.modelClassUploadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modelClassUploadButton.Location = new System.Drawing.Point(254, 360);
            this.modelClassUploadButton.Name = "modelClassUploadButton";
            this.modelClassUploadButton.Size = new System.Drawing.Size(291, 50);
            this.modelClassUploadButton.TabIndex = 8;
            this.modelClassUploadButton.Text = "ADD MODEL CLASS";
            this.modelClassUploadButton.UseVisualStyleBackColor = false;
            this.modelClassUploadButton.Click += new System.EventHandler(this.modelClassUploadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // apiGeneratorLabel
            // 
            this.apiGeneratorLabel.AutoSize = true;
            this.apiGeneratorLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.apiGeneratorLabel.Location = new System.Drawing.Point(254, 19);
            this.apiGeneratorLabel.Name = "apiGeneratorLabel";
            this.apiGeneratorLabel.Size = new System.Drawing.Size(274, 41);
            this.apiGeneratorLabel.TabIndex = 9;
            this.apiGeneratorLabel.Text = "   API GENERATOR  ";
            // 
            // generateProgressBar
            // 
            this.generateProgressBar.Location = new System.Drawing.Point(1, 580);
            this.generateProgressBar.Name = "generateProgressBar";
            this.generateProgressBar.Size = new System.Drawing.Size(745, 40);
            this.generateProgressBar.TabIndex = 10;
            this.generateProgressBar.Visible = false;
            // 
            // generateLabel
            // 
            this.generateLabel.AutoSize = true;
            this.generateLabel.Location = new System.Drawing.Point(1, 536);
            this.generateLabel.Name = "generateLabel";
            this.generateLabel.Size = new System.Drawing.Size(67, 41);
            this.generateLabel.TabIndex = 11;
            this.generateLabel.Text = ".......";
            this.generateLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 621);
            this.Controls.Add(this.generateLabel);
            this.Controls.Add(this.generateProgressBar);
            this.Controls.Add(this.apiGeneratorLabel);
            this.Controls.Add(this.modelClassUploadButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.connectionStringText);
            this.Controls.Add(this.connectionStringLabel);
            this.Controls.Add(this.apiPathText);
            this.Controls.Add(this.apiPathLabel);
            this.Controls.Add(this.apiNameText);
            this.Controls.Add(this.apiNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label apiNameLabel;
        private TextBox apiNameText;
        private Label apiPathLabel;
        private TextBox apiPathText;
        private Label connectionStringLabel;
        private TextBox connectionStringText;
        private Button generateButton;
        private Button modelClassUploadButton;
        private OpenFileDialog openFileDialog;
        private Label apiGeneratorLabel;
        private ProgressBar generateProgressBar;
        private Label generateLabel;
    }
}