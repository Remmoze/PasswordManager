namespace PasswordManager {
    partial class IconLoader {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LinkBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ImageLink = new System.Windows.Forms.Button();
            this.SiteUrl = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.PictureBox();
            this.ResizeCheck = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkBox
            // 
            this.LinkBox.Location = new System.Drawing.Point(6, 21);
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(286, 20);
            this.LinkBox.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(3, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(139, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Enter Image Link or Site Url:";
            // 
            // ImageLink
            // 
            this.ImageLink.Location = new System.Drawing.Point(6, 55);
            this.ImageLink.Name = "ImageLink";
            this.ImageLink.Size = new System.Drawing.Size(140, 23);
            this.ImageLink.TabIndex = 2;
            this.ImageLink.Text = "Load using Image Link";
            this.ImageLink.UseVisualStyleBackColor = true;
            this.ImageLink.Click += new System.EventHandler(this.ImageLink_Click);
            // 
            // SiteUrl
            // 
            this.SiteUrl.Location = new System.Drawing.Point(152, 55);
            this.SiteUrl.Name = "SiteUrl";
            this.SiteUrl.Size = new System.Drawing.Size(140, 23);
            this.SiteUrl.TabIndex = 3;
            this.SiteUrl.Text = "Load using Site Url";
            this.SiteUrl.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(316, 5);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Preview:";
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(322, 21);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(32, 32);
            this.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Preview.TabIndex = 5;
            this.Preview.TabStop = false;
            // 
            // ResizeCheck
            // 
            this.ResizeCheck.AutoSize = true;
            this.ResizeCheck.Checked = true;
            this.ResizeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResizeCheck.Location = new System.Drawing.Point(234, 3);
            this.ResizeCheck.Name = "ResizeCheck";
            this.ResizeCheck.Size = new System.Drawing.Size(58, 17);
            this.ResizeCheck.TabIndex = 6;
            this.ResizeCheck.Text = "Resize";
            this.ResizeCheck.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(310, 55);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(57, 23);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // IconLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ResizeCheck);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.SiteUrl);
            this.Controls.Add(this.ImageLink);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LinkBox);
            this.Name = "IconLoader";
            this.Size = new System.Drawing.Size(382, 81);
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LinkBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ImageLink;
        private System.Windows.Forms.Button SiteUrl;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.CheckBox ResizeCheck;
        public System.Windows.Forms.Button Submit;
    }
}
