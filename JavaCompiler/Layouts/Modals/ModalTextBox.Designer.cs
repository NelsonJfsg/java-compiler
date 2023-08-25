namespace JavaCompiler
{
    partial class ModalTextBox
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
            tbFileName = new System.Windows.Forms.TextBox();
            butCreateFile = new Button();
            description = new Label();
            SuspendLayout();
            // 
            // tbFileName
            // 
            tbFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbFileName.Location = new Point(110, 82);
            tbFileName.Name = "tbFileName";
            tbFileName.Size = new Size(276, 39);
            tbFileName.TabIndex = 0;
            // 
            // butCreateFile
            // 
            butCreateFile.Location = new Point(191, 151);
            butCreateFile.Name = "butCreateFile";
            butCreateFile.Size = new Size(112, 34);
            butCreateFile.TabIndex = 1;
            butCreateFile.Text = "Create file";
            butCreateFile.UseVisualStyleBackColor = true;
            butCreateFile.Click += butCreateFile_Click;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            description.Location = new Point(167, 25);
            description.Name = "description";
            description.Size = new Size(152, 38);
            description.TabIndex = 2;
            description.Text = "File name:";
            // 
            // ModalTextBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 242);
            Controls.Add(description);
            Controls.Add(butCreateFile);
            Controls.Add(tbFileName);
            Name = "ModalTextBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModalTextBox";
            Load += ModalTextBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbFileName;
        private Button butCreateFile;
        private Label description;
    }
}