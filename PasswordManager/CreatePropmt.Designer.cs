namespace PasswordManager {
    partial class CreatePropmt {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePropmt));
            this.Add = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ScrambleBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumbersCheck = new System.Windows.Forms.CheckBox();
            this.SymbolsCheck = new System.Windows.Forms.CheckBox();
            this.LowerCaseCheck = new System.Windows.Forms.CheckBox();
            this.UpperCaseCheck = new System.Windows.Forms.CheckBox();
            this.LengthDisplay = new System.Windows.Forms.Label();
            this.LengthSlider = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.LoadURL = new System.Windows.Forms.Button();
            this.SelectFile = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.FilePath = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlider)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(303, 148);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(164, 38);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add password";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(303, 122);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(164, 20);
            this.NameBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(300, 106);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Name:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(9, 32);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(273, 20);
            this.PasswordBox.TabIndex = 4;
            // 
            // ScrambleBTN
            // 
            this.ScrambleBTN.Location = new System.Drawing.Point(183, 127);
            this.ScrambleBTN.Name = "ScrambleBTN";
            this.ScrambleBTN.Size = new System.Drawing.Size(99, 40);
            this.ScrambleBTN.TabIndex = 5;
            this.ScrambleBTN.Text = "Scramble";
            this.ScrambleBTN.UseVisualStyleBackColor = true;
            this.ScrambleBTN.Click += new System.EventHandler(this.ScrambleBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumbersCheck);
            this.groupBox1.Controls.Add(this.SymbolsCheck);
            this.groupBox1.Controls.Add(this.LowerCaseCheck);
            this.groupBox1.Controls.Add(this.UpperCaseCheck);
            this.groupBox1.Controls.Add(this.LengthDisplay);
            this.groupBox1.Controls.Add(this.LengthSlider);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.ScrambleBTN);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Settings";
            // 
            // NumbersCheck
            // 
            this.NumbersCheck.AutoSize = true;
            this.NumbersCheck.Checked = true;
            this.NumbersCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumbersCheck.Location = new System.Drawing.Point(97, 150);
            this.NumbersCheck.Name = "NumbersCheck";
            this.NumbersCheck.Size = new System.Drawing.Size(68, 17);
            this.NumbersCheck.TabIndex = 11;
            this.NumbersCheck.Text = "Numbers";
            this.NumbersCheck.UseVisualStyleBackColor = true;
            this.NumbersCheck.CheckedChanged += new System.EventHandler(this.OptionsCheck);
            // 
            // SymbolsCheck
            // 
            this.SymbolsCheck.AutoSize = true;
            this.SymbolsCheck.Location = new System.Drawing.Point(97, 127);
            this.SymbolsCheck.Name = "SymbolsCheck";
            this.SymbolsCheck.Size = new System.Drawing.Size(65, 17);
            this.SymbolsCheck.TabIndex = 10;
            this.SymbolsCheck.Text = "Symbols";
            this.SymbolsCheck.UseVisualStyleBackColor = true;
            this.SymbolsCheck.CheckedChanged += new System.EventHandler(this.OptionsCheck);
            // 
            // LowerCaseCheck
            // 
            this.LowerCaseCheck.AutoSize = true;
            this.LowerCaseCheck.Checked = true;
            this.LowerCaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCaseCheck.Location = new System.Drawing.Point(9, 150);
            this.LowerCaseCheck.Name = "LowerCaseCheck";
            this.LowerCaseCheck.Size = new System.Drawing.Size(82, 17);
            this.LowerCaseCheck.TabIndex = 9;
            this.LowerCaseCheck.Text = "Lower Case";
            this.LowerCaseCheck.UseVisualStyleBackColor = true;
            this.LowerCaseCheck.CheckedChanged += new System.EventHandler(this.OptionsCheck);
            // 
            // UpperCaseCheck
            // 
            this.UpperCaseCheck.AutoSize = true;
            this.UpperCaseCheck.Checked = true;
            this.UpperCaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCaseCheck.Location = new System.Drawing.Point(9, 127);
            this.UpperCaseCheck.Name = "UpperCaseCheck";
            this.UpperCaseCheck.Size = new System.Drawing.Size(82, 17);
            this.UpperCaseCheck.TabIndex = 8;
            this.UpperCaseCheck.Text = "Upper Case";
            this.UpperCaseCheck.UseVisualStyleBackColor = true;
            this.UpperCaseCheck.CheckedChanged += new System.EventHandler(this.OptionsCheck);
            // 
            // LengthDisplay
            // 
            this.LengthDisplay.AutoSize = true;
            this.LengthDisplay.Location = new System.Drawing.Point(6, 60);
            this.LengthDisplay.Name = "LengthDisplay";
            this.LengthDisplay.Size = new System.Drawing.Size(64, 13);
            this.LengthDisplay.TabIndex = 7;
            this.LengthDisplay.Text = "Length (25):";
            // 
            // LengthSlider
            // 
            this.LengthSlider.Location = new System.Drawing.Point(9, 76);
            this.LengthSlider.Maximum = 50;
            this.LengthSlider.Minimum = 1;
            this.LengthSlider.Name = "LengthSlider";
            this.LengthSlider.Size = new System.Drawing.Size(273, 45);
            this.LengthSlider.TabIndex = 6;
            this.LengthSlider.Value = 25;
            this.LengthSlider.Scroll += new System.EventHandler(this.Scrolled);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Reset);
            this.groupBox2.Controls.Add(this.LoadURL);
            this.groupBox2.Controls.Add(this.SelectFile);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.IconBox);
            this.groupBox2.Location = new System.Drawing.Point(297, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon Settings";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(89, 42);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset Icon";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // LoadURL
            // 
            this.LoadURL.Location = new System.Drawing.Point(89, 71);
            this.LoadURL.Name = "LoadURL";
            this.LoadURL.Size = new System.Drawing.Size(75, 23);
            this.LoadURL.TabIndex = 3;
            this.LoadURL.Text = "Load with url";
            this.LoadURL.UseVisualStyleBackColor = true;
            this.LoadURL.Click += new System.EventHandler(this.LoadURL_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(6, 71);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(75, 23);
            this.SelectFile.TabIndex = 2;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Current icon:";
            // 
            // IconBox
            // 
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(9, 32);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(32, 32);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconBox.TabIndex = 0;
            this.IconBox.TabStop = false;
            // 
            // FilePath
            // 
            this.FilePath.FileName = "openFileDialog1";
            // 
            // CreatePropmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Add);
            this.Name = "CreatePropmt";
            this.Size = new System.Drawing.Size(475, 192);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ScrambleBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox NumbersCheck;
        private System.Windows.Forms.CheckBox SymbolsCheck;
        private System.Windows.Forms.CheckBox LowerCaseCheck;
        private System.Windows.Forms.CheckBox UpperCaseCheck;
        private System.Windows.Forms.Label LengthDisplay;
        private System.Windows.Forms.TrackBar LengthSlider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadURL;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.OpenFileDialog FilePath;
        private System.Windows.Forms.Button Reset;
    }
}
