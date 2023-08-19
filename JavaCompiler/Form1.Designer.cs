namespace JavaCompiler
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createFile = new ToolStripMenuItem();
            openFile = new ToolStripMenuItem();
            saveFile = new ToolStripMenuItem();
            saveAsFile = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1333, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createFile, openFile, saveFile, saveAsFile });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // createFile
            // 
            createFile.BackColor = Color.Black;
            createFile.ForeColor = Color.White;
            createFile.Name = "createFile";
            createFile.Size = new Size(185, 34);
            createFile.Text = "Create";
            createFile.Click += createFile_Click;
            // 
            // openFile
            // 
            openFile.BackColor = Color.Black;
            openFile.ForeColor = Color.White;
            openFile.Name = "openFile";
            openFile.Size = new Size(185, 34);
            openFile.Text = "Open";
            openFile.Click += openFile_Click;
            // 
            // saveFile
            // 
            saveFile.BackColor = Color.Black;
            saveFile.ForeColor = Color.White;
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(185, 34);
            saveFile.Text = "Save";
            // 
            // saveAsFile
            // 
            saveAsFile.BackColor = Color.Black;
            saveAsFile.ForeColor = Color.White;
            saveAsFile.Name = "saveAsFile";
            saveAsFile.Size = new Size(185, 34);
            saveAsFile.Text = "Save as...";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(11, 11, 11);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(12, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(773, 660);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            ClientSize = new Size(1333, 756);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createFile;
        private ToolStripMenuItem openFile;
        private ToolStripMenuItem saveFile;
        private ToolStripMenuItem saveAsFile;
        private RichTextBox richTextBox1;
    }
}