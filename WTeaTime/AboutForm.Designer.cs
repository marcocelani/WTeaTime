namespace WTeaTime
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLAuthor = new System.Windows.Forms.LinkLabel();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.picOctocat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picFlickr = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOctocat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlickr)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLAuthor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHomePage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.picOctocat, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.picFlickr, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 181);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "WTeaTime";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(41, 38);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // lblLAuthor
            // 
            this.lblLAuthor.AutoSize = true;
            this.lblLAuthor.Location = new System.Drawing.Point(132, 38);
            this.lblLAuthor.Name = "lblLAuthor";
            this.lblLAuthor.Size = new System.Drawing.Size(69, 13);
            this.lblLAuthor.TabIndex = 3;
            this.lblLAuthor.TabStop = true;
            this.lblLAuthor.Text = "Marco Celani";
            this.lblLAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkAuthor);
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Location = new System.Drawing.Point(41, 51);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(66, 13);
            this.lblHomePage.TabIndex = 4;
            this.lblHomePage.Text = "Home Page:";
            // 
            // picOctocat
            // 
            this.picOctocat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOctocat.Image = global::WTeaTime.Properties.Resources.Octocat;
            this.picOctocat.Location = new System.Drawing.Point(132, 54);
            this.picOctocat.Name = "picOctocat";
            this.picOctocat.Size = new System.Drawing.Size(109, 50);
            this.picOctocat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOctocat.TabIndex = 5;
            this.picOctocat.TabStop = false;
            this.picOctocat.Click += new System.EventHandler(this.picOctocat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WTeaTime.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Other resources:";
            // 
            // picFlickr
            // 
            this.picFlickr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFlickr.Image = global::WTeaTime.Properties.Resources.white_im_on_flickr;
            this.picFlickr.Location = new System.Drawing.Point(132, 110);
            this.picFlickr.Name = "picFlickr";
            this.picFlickr.Size = new System.Drawing.Size(109, 42);
            this.picFlickr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFlickr.TabIndex = 8;
            this.picFlickr.TabStop = false;
            this.picFlickr.Click += new System.EventHandler(this.picFlickr_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 198);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOctocat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlickr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.LinkLabel lblLAuthor;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.PictureBox picOctocat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFlickr;
    }
}
