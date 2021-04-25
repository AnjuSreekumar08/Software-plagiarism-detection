namespace SoftwarePlagiarismFinder
{
    partial class OTO_BrowseFiles
    {
       
       private System.ComponentModel.Container components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

     
        private void InitializeComponent()
        {
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdDestination = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.cmdSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCompare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmdClose.ForeColor = System.Drawing.Color.White;
            this.cmdClose.Location = new System.Drawing.Point(570, 352);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(118, 43);
            this.cmdClose.TabIndex = 19;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdDestination
            // 
            this.cmdDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.cmdDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmdDestination.ForeColor = System.Drawing.Color.White;
            this.cmdDestination.Location = new System.Drawing.Point(646, 206);
            this.cmdDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdDestination.Name = "cmdDestination";
            this.cmdDestination.Size = new System.Drawing.Size(42, 43);
            this.cmdDestination.TabIndex = 15;
            this.cmdDestination.Text = "...";
            this.cmdDestination.UseVisualStyleBackColor = false;
            this.cmdDestination.Click += new System.EventHandler(this.cmdDestination_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtDestination.Location = new System.Drawing.Point(272, 214);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(364, 28);
            this.txtDestination.TabIndex = 14;
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtSource.Location = new System.Drawing.Point(272, 137);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(364, 28);
            this.txtSource.TabIndex = 11;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // cmdSource
            // 
            this.cmdSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.cmdSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmdSource.ForeColor = System.Drawing.Color.White;
            this.cmdSource.Location = new System.Drawing.Point(646, 125);
            this.cmdSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSource.Name = "cmdSource";
            this.cmdSource.Size = new System.Drawing.Size(42, 43);
            this.cmdSource.TabIndex = 12;
            this.cmdSource.Text = "...";
            this.cmdSource.UseVisualStyleBackColor = false;
            this.cmdSource.Click += new System.EventHandler(this.cmdSource_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(267, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(267, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdCompare
            // 
            this.cmdCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(171)))));
            this.cmdCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmdCompare.ForeColor = System.Drawing.Color.White;
            this.cmdCompare.Location = new System.Drawing.Point(452, 352);
            this.cmdCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Size = new System.Drawing.Size(118, 43);
            this.cmdCompare.TabIndex = 18;
            this.cmdCompare.Text = "Compare";
            this.cmdCompare.UseVisualStyleBackColor = false;
            this.cmdCompare.Click += new System.EventHandler(this.cmdCompare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 24.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 67);
            this.label3.TabIndex = 20;
            this.label3.Text = "Browse Files..";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftwarePlagiarismFinder.Properties.Resources.iconfinder_document_search_48758;
            this.pictureBox1.Location = new System.Drawing.Point(21, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // OTO_BrowseFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 434);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.cmdSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OTO_BrowseFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTO_BrowseFiles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button cmdSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCompare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}