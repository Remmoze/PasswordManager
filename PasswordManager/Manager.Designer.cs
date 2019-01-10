namespace PasswordManager {
    partial class PasswordManager {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.passwords = new System.Windows.Forms.FlowLayoutPanel();
            this.NewPasswordBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwords
            // 
            this.passwords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwords.AutoScroll = true;
            this.passwords.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.passwords.Location = new System.Drawing.Point(0, 27);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(272, 422);
            this.passwords.TabIndex = 3;
            this.passwords.WrapContents = false;
            // 
            // NewPasswordBTN
            // 
            this.NewPasswordBTN.Name = "NewPasswordBTN";
            this.NewPasswordBTN.Size = new System.Drawing.Size(96, 20);
            this.NewPasswordBTN.Text = "New Password";
            this.NewPasswordBTN.Click += new System.EventHandler(this.Create);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPasswordBTN,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.passwords);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PasswordManager";
            this.Text = "Password Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel passwords;
        private System.Windows.Forms.ToolStripMenuItem NewPasswordBTN;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

