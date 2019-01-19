﻿namespace PasswordManager {
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
            this.PasswordsGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.NewPasswordBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportABackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecretLegs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.PasswordsGrid.Location = new System.Drawing.Point(0, 27);
            this.PasswordsGrid.Name = "PasswordsGrid";
            this.PasswordsGrid.Size = new System.Drawing.Size(272, 422);
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportABackupToolStripMenuItem,
            this.SecretLegs});
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
            // exportABackupToolStripMenuItem
            // 
            this.exportABackupToolStripMenuItem.Name = "exportABackupToolStripMenuItem";
            this.exportABackupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportABackupToolStripMenuItem.Text = "Export a backup";
            // 
            // SecretLegs
            // 
            this.SecretLegs.Name = "SecretLegs";
            this.SecretLegs.Size = new System.Drawing.Size(180, 22);
            this.SecretLegs.Text = "?";
            this.SecretLegs.Click += new System.EventHandler(this.SecretLegs_Click);
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PasswordsGrid);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PasswordManager";
            this.Text = "Password Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel PasswordsGrid;
        private System.Windows.Forms.ToolStripMenuItem NewPasswordBTN;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportABackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SecretLegs;
    }
}

