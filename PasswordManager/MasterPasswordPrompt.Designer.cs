namespace PasswordManager {
    partial class MasterPasswordPrompt {
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
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordBox.Location = new System.Drawing.Point(3, 16);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(263, 20);
            this.PasswordBox.TabIndex = 0;
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // Submit
            // 
            this.Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit.Location = new System.Drawing.Point(272, 10);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 30);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(3, 42);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(99, 23);
            this.Export.TabIndex = 2;
            this.Export.Text = "Export Passports";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(108, 42);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(99, 23);
            this.Import.TabIndex = 3;
            this.Import.Text = "Import Passports";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // MasterPasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PasswordBox);
            this.Name = "MasterPasswordPrompt";
            this.Size = new System.Drawing.Size(350, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Submit;
        public System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
    }
}
