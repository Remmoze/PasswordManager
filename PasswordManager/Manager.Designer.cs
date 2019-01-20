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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManager));
            this.PasswordsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.NewPasswordBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.SecretLegs = new System.Windows.Forms.ToolStripMenuItem();
            this.Options = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBackup = new System.Windows.Forms.SaveFileDialog();
            this.Search = new System.Windows.Forms.TextBox();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordsGrid
            // 
            this.PasswordsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordsGrid.AutoScroll = true;
            this.PasswordsGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordsGrid.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PasswordsGrid.Location = new System.Drawing.Point(0, 43);
            this.PasswordsGrid.Name = "PasswordsGrid";
            this.PasswordsGrid.Size = new System.Drawing.Size(272, 406);
            this.PasswordsGrid.TabIndex = 3;
            this.PasswordsGrid.WrapContents = false;
            // 
            // NewPasswordBTN
            // 
            this.NewPasswordBTN.Name = "NewPasswordBTN";
            this.NewPasswordBTN.Size = new System.Drawing.Size(96, 20);
            this.NewPasswordBTN.Text = "New Password";
            this.NewPasswordBTN.Click += new System.EventHandler(this.Create);
            // 
            // Settings
            // 
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportBackup,
            this.SecretLegs});
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(61, 20);
            this.Settings.Text = "Settings";
            // 
            // ExportBackup
            // 
            this.ExportBackup.Name = "ExportBackup";
            this.ExportBackup.Size = new System.Drawing.Size(158, 22);
            this.ExportBackup.Text = "Export a backup";
            this.ExportBackup.Click += new System.EventHandler(this.ExportBackup_Click);
            // 
            // SecretLegs
            // 
            this.SecretLegs.Name = "SecretLegs";
            this.SecretLegs.Size = new System.Drawing.Size(158, 22);
            this.SecretLegs.Text = "?";
            this.SecretLegs.Click += new System.EventHandler(this.SecretLegs_Click);
            // 
            // Options
            // 
            this.Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPasswordBTN,
            this.Settings,
            this.toolStripMenuItem1});
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(272, 24);
            this.Options.TabIndex = 9;
            this.Options.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(0, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(272, 20);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search..";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 461);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.PasswordsGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Options;
            this.Name = "PasswordManager";
            this.Text = "Password Manager";
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PasswordsGrid;
        private System.Windows.Forms.ToolStripMenuItem NewPasswordBTN;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem ExportBackup;
        private System.Windows.Forms.ToolStripMenuItem SecretLegs;
        private System.Windows.Forms.MenuStrip Options;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog SaveBackup;
        private System.Windows.Forms.TextBox Search;
    }
}

