namespace plex_file_list
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
            this.BrowseFolderButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.Location = new System.Drawing.Point(83, 39);
            this.BrowseFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.Size = new System.Drawing.Size(114, 40);
            this.BrowseFolderButton.TabIndex = 0;
            this.BrowseFolderButton.Text = "button1";
            this.BrowseFolderButton.UseVisualStyleBackColor = true;
            this.BrowseFolderButton.Click += new System.EventHandler(this.BrowseFolderButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 106);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(615, 31);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colDir,
            this.colSize});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(68, 190);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1621, 854);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colFile
            // 
            this.colFile.Text = "FileName";
            this.colFile.Width = 359;
            // 
            // colDir
            // 
            this.colDir.Text = "Directory";
            this.colDir.Width = 454;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 100;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1674, 1229);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrowseFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseFolderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader colSize;
    }
}

