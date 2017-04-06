namespace DwgListTool
{
    partial class MainForm
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
            this.BrowseForFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProcessFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseForFile
            // 
            this.BrowseForFile.Location = new System.Drawing.Point(6, 51);
            this.BrowseForFile.Name = "BrowseForFile";
            this.BrowseForFile.Size = new System.Drawing.Size(119, 23);
            this.BrowseForFile.TabIndex = 0;
            this.BrowseForFile.Text = "Select Excel File";
            this.BrowseForFile.UseVisualStyleBackColor = true;
            this.BrowseForFile.Click += new System.EventHandler(this.BrowseForFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel files|*.xls?";
            this.openFileDialog1.Title = "Select Excel File for updating";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(6, 19);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(547, 20);
            this.FileName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.ProcessFile);
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Controls.Add(this.BrowseForFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select File";
            // 
            // ProcessFile
            // 
            this.ProcessFile.Location = new System.Drawing.Point(131, 51);
            this.ProcessFile.Name = "ProcessFile";
            this.ProcessFile.Size = new System.Drawing.Size(129, 23);
            this.ProcessFile.TabIndex = 2;
            this.ProcessFile.Text = "Process Selected File";
            this.ProcessFile.UseVisualStyleBackColor = true;
            this.ProcessFile.Click += new System.EventHandler(this.ProcessFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(547, 32);
            this.progressBar1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 383);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "D.L.T. (DRAWING LIST TOOL)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button BrowseForFile;
        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ProcessFile;
    }
}

