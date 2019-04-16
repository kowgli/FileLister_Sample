namespace FileLister
{
    partial class Form1
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
            this.lbRootDir = new System.Windows.Forms.Label();
            this.tbRootDir = new System.Windows.Forms.TextBox();
            this.bPickRootDir = new System.Windows.Forms.Button();
            this.fbdRootDir = new System.Windows.Forms.FolderBrowserDialog();
            this.lbMaxDepth = new System.Windows.Forms.Label();
            this.nudMaxDepth = new System.Windows.Forms.NumericUpDown();
            this.bSearch = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lboxResult = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRootDir
            // 
            this.lbRootDir.AutoSize = true;
            this.lbRootDir.Location = new System.Drawing.Point(21, 38);
            this.lbRootDir.Name = "lbRootDir";
            this.lbRootDir.Size = new System.Drawing.Size(55, 13);
            this.lbRootDir.TabIndex = 0;
            this.lbRootDir.Text = "Zacznij w:";
            // 
            // tbRootDir
            // 
            this.tbRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootDir.Location = new System.Drawing.Point(121, 35);
            this.tbRootDir.Name = "tbRootDir";
            this.tbRootDir.ReadOnly = true;
            this.tbRootDir.Size = new System.Drawing.Size(439, 20);
            this.tbRootDir.TabIndex = 1;
            this.tbRootDir.Text = "C:\\";
            // 
            // bPickRootDir
            // 
            this.bPickRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPickRootDir.Location = new System.Drawing.Point(579, 34);
            this.bPickRootDir.Name = "bPickRootDir";
            this.bPickRootDir.Size = new System.Drawing.Size(28, 23);
            this.bPickRootDir.TabIndex = 2;
            this.bPickRootDir.Text = "...";
            this.bPickRootDir.UseVisualStyleBackColor = true;
            this.bPickRootDir.Click += new System.EventHandler(this.BPickRootDir_Click);
            // 
            // fbdRootDir
            // 
            this.fbdRootDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdRootDir.ShowNewFolderButton = false;
            // 
            // lbMaxDepth
            // 
            this.lbMaxDepth.AutoSize = true;
            this.lbMaxDepth.Location = new System.Drawing.Point(21, 85);
            this.lbMaxDepth.Name = "lbMaxDepth";
            this.lbMaxDepth.Size = new System.Drawing.Size(90, 13);
            this.lbMaxDepth.TabIndex = 3;
            this.lbMaxDepth.Text = "Maks głębokość:";
            // 
            // nudMaxDepth
            // 
            this.nudMaxDepth.Location = new System.Drawing.Point(121, 81);
            this.nudMaxDepth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDepth.Name = "nudMaxDepth";
            this.nudMaxDepth.Size = new System.Drawing.Size(120, 20);
            this.nudMaxDepth.TabIndex = 4;
            this.nudMaxDepth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // bSearch
            // 
            this.bSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bSearch.Location = new System.Drawing.Point(240, 151);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(160, 23);
            this.bSearch.TabIndex = 5;
            this.bSearch.Text = "Wyszukaj pliki";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(21, 242);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(40, 13);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "Wynik:";
            // 
            // lboxResult
            // 
            this.lboxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.Location = new System.Drawing.Point(88, 242);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(519, 173);
            this.lboxResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.nudMaxDepth);
            this.Controls.Add(this.lbMaxDepth);
            this.Controls.Add(this.bPickRootDir);
            this.Controls.Add(this.tbRootDir);
            this.Controls.Add(this.lbRootDir);
            this.MinimumSize = new System.Drawing.Size(419, 326);
            this.Name = "Form1";
            this.Text = "Listowanie plików";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRootDir;
        private System.Windows.Forms.TextBox tbRootDir;
        private System.Windows.Forms.Button bPickRootDir;
        private System.Windows.Forms.FolderBrowserDialog fbdRootDir;
        private System.Windows.Forms.Label lbMaxDepth;
        private System.Windows.Forms.NumericUpDown nudMaxDepth;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ListBox lboxResult;
    }
}

