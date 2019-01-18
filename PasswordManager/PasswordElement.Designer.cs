namespace PasswordManager {
    partial class PasswordElement {
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
            this.NameTag = new System.Windows.Forms.Label();
            this.CopyBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTag
            // 
            this.NameTag.AutoSize = true;
            this.NameTag.Location = new System.Drawing.Point(41, 13);
            this.NameTag.Name = "NameTag";
            this.NameTag.Size = new System.Drawing.Size(39, 13);
            this.NameTag.TabIndex = 1;
            this.NameTag.Text = "default";
            // 
            // CopyBTN
            // 
            this.CopyBTN.Location = new System.Drawing.Point(3, 41);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(155, 23);
            this.CopyBTN.TabIndex = 2;
            this.CopyBTN.Text = "Copy Password";
            this.CopyBTN.UseVisualStyleBackColor = true;
            this.CopyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Location = new System.Drawing.Point(164, 41);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(53, 23);
            this.EditBTN.TabIndex = 3;
            this.EditBTN.Text = "Edit";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // Delete
            // 
            this.Delete.Image = global::PasswordManager.Properties.Resources.deleteicon;
            this.Delete.Location = new System.Drawing.Point(223, 41);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(23, 23);
            this.Delete.TabIndex = 4;
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // icon
            // 
            this.icon.Image = global::PasswordManager.Properties.Resources.defaulticon;
            this.icon.Location = new System.Drawing.Point(3, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(32, 32);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // PasswordElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.CopyBTN);
            this.Controls.Add(this.NameTag);
            this.Controls.Add(this.icon);
            this.Name = "PasswordElement";
            this.Size = new System.Drawing.Size(249, 70);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox icon;
        public System.Windows.Forms.Label NameTag;
        public System.Windows.Forms.Button CopyBTN;
        public System.Windows.Forms.Button EditBTN;
        public System.Windows.Forms.Button Delete;
    }
}
