namespace DnDCharacterGenerator
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
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.CharacterImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ChracterNameLabel = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.StrengthTextBox = new System.Windows.Forms.TextBox();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.ConstitutionTextBox = new System.Windows.Forms.TextBox();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.WisdomTextBox = new System.Windows.Forms.TextBox();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.IntelligenceTextBox = new System.Windows.Forms.TextBox();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.CharismaTextBox = new System.Windows.Forms.TextBox();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.DexterityTextBox = new System.Windows.Forms.TextBox();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StartOverButton = new System.Windows.Forms.Button();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.OpenCharacterImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.AlignmentTextBox = new System.Windows.Forms.TextBox();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CharacterFeaturesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(13, 99);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(260, 23);
            this.LoadImageButton.TabIndex = 0;
            this.LoadImageButton.Text = "Import Character Image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // CharacterImagePictureBox
            // 
            this.CharacterImagePictureBox.Location = new System.Drawing.Point(13, 128);
            this.CharacterImagePictureBox.Name = "CharacterImagePictureBox";
            this.CharacterImagePictureBox.Size = new System.Drawing.Size(260, 295);
            this.CharacterImagePictureBox.TabIndex = 1;
            this.CharacterImagePictureBox.TabStop = false;
            // 
            // ChracterNameLabel
            // 
            this.ChracterNameLabel.AutoSize = true;
            this.ChracterNameLabel.Location = new System.Drawing.Point(17, 12);
            this.ChracterNameLabel.Name = "ChracterNameLabel";
            this.ChracterNameLabel.Size = new System.Drawing.Size(90, 13);
            this.ChracterNameLabel.TabIndex = 2;
            this.ChracterNameLabel.Text = "Character Name: ";
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(110, 8);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.ReadOnly = true;
            this.CharacterNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.CharacterNameTextBox.TabIndex = 3;
            // 
            // StrengthTextBox
            // 
            this.StrengthTextBox.Location = new System.Drawing.Point(636, 11);
            this.StrengthTextBox.Name = "StrengthTextBox";
            this.StrengthTextBox.ReadOnly = true;
            this.StrengthTextBox.Size = new System.Drawing.Size(41, 20);
            this.StrengthTextBox.TabIndex = 5;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(573, 15);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(53, 13);
            this.StrengthLabel.TabIndex = 4;
            this.StrengthLabel.Text = "Strength: ";
            // 
            // ConstitutionTextBox
            // 
            this.ConstitutionTextBox.Location = new System.Drawing.Point(753, 12);
            this.ConstitutionTextBox.Name = "ConstitutionTextBox";
            this.ConstitutionTextBox.ReadOnly = true;
            this.ConstitutionTextBox.Size = new System.Drawing.Size(41, 20);
            this.ConstitutionTextBox.TabIndex = 11;
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.Location = new System.Drawing.Point(686, 16);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(68, 13);
            this.ConstitutionLabel.TabIndex = 10;
            this.ConstitutionLabel.Text = "Constitution: ";
            // 
            // WisdomTextBox
            // 
            this.WisdomTextBox.Location = new System.Drawing.Point(753, 90);
            this.WisdomTextBox.Name = "WisdomTextBox";
            this.WisdomTextBox.ReadOnly = true;
            this.WisdomTextBox.Size = new System.Drawing.Size(41, 20);
            this.WisdomTextBox.TabIndex = 15;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.AutoSize = true;
            this.WisdomLabel.Location = new System.Drawing.Point(686, 94);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(45, 13);
            this.WisdomLabel.TabIndex = 14;
            this.WisdomLabel.Text = "Wisdom";
            // 
            // IntelligenceTextBox
            // 
            this.IntelligenceTextBox.Location = new System.Drawing.Point(636, 89);
            this.IntelligenceTextBox.Name = "IntelligenceTextBox";
            this.IntelligenceTextBox.ReadOnly = true;
            this.IntelligenceTextBox.Size = new System.Drawing.Size(41, 20);
            this.IntelligenceTextBox.TabIndex = 13;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Location = new System.Drawing.Point(573, 93);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(64, 13);
            this.IntelligenceLabel.TabIndex = 12;
            this.IntelligenceLabel.Text = "Intelligence:";
            // 
            // CharismaTextBox
            // 
            this.CharismaTextBox.Location = new System.Drawing.Point(753, 50);
            this.CharismaTextBox.Name = "CharismaTextBox";
            this.CharismaTextBox.ReadOnly = true;
            this.CharismaTextBox.Size = new System.Drawing.Size(41, 20);
            this.CharismaTextBox.TabIndex = 19;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Location = new System.Drawing.Point(686, 54);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(56, 13);
            this.CharismaLabel.TabIndex = 18;
            this.CharismaLabel.Text = "Charisma: ";
            // 
            // DexterityTextBox
            // 
            this.DexterityTextBox.Location = new System.Drawing.Point(636, 49);
            this.DexterityTextBox.Name = "DexterityTextBox";
            this.DexterityTextBox.ReadOnly = true;
            this.DexterityTextBox.Size = new System.Drawing.Size(41, 20);
            this.DexterityTextBox.TabIndex = 17;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Location = new System.Drawing.Point(573, 53);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(48, 13);
            this.DexterityLabel.TabIndex = 16;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // StartOverButton
            // 
            this.StartOverButton.Location = new System.Drawing.Point(13, 46);
            this.StartOverButton.Name = "StartOverButton";
            this.StartOverButton.Size = new System.Drawing.Size(260, 23);
            this.StartOverButton.TabIndex = 20;
            this.StartOverButton.Text = "Start Over";
            this.StartOverButton.UseVisualStyleBackColor = true;
            this.StartOverButton.Click += new System.EventHandler(this.StartOverButton_Click);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(355, 16);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(39, 13);
            this.RaceLabel.TabIndex = 21;
            this.RaceLabel.Text = "Race: ";
            // 
            // OpenCharacterImageDialog
            // 
            this.OpenCharacterImageDialog.FileName = "openFileDialog1";
            this.OpenCharacterImageDialog.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP";
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Location = new System.Drawing.Point(428, 9);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.ReadOnly = true;
            this.RaceTextBox.Size = new System.Drawing.Size(137, 20);
            this.RaceTextBox.TabIndex = 22;
            // 
            // BackgroundTextBox
            // 
            this.BackgroundTextBox.Location = new System.Drawing.Point(428, 35);
            this.BackgroundTextBox.Name = "BackgroundTextBox";
            this.BackgroundTextBox.ReadOnly = true;
            this.BackgroundTextBox.Size = new System.Drawing.Size(137, 20);
            this.BackgroundTextBox.TabIndex = 24;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Location = new System.Drawing.Point(351, 42);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(71, 13);
            this.BackgroundLabel.TabIndex = 23;
            this.BackgroundLabel.Text = "Background: ";
            // 
            // AlignmentTextBox
            // 
            this.AlignmentTextBox.Location = new System.Drawing.Point(428, 62);
            this.AlignmentTextBox.Name = "AlignmentTextBox";
            this.AlignmentTextBox.ReadOnly = true;
            this.AlignmentTextBox.Size = new System.Drawing.Size(137, 20);
            this.AlignmentTextBox.TabIndex = 26;
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.Location = new System.Drawing.Point(351, 65);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(59, 13);
            this.AlignmentLabel.TabIndex = 25;
            this.AlignmentLabel.Text = "Alignment: ";
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Location = new System.Drawing.Point(428, 89);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.ReadOnly = true;
            this.ClassTextBox.Size = new System.Drawing.Size(137, 20);
            this.ClassTextBox.TabIndex = 28;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(351, 92);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(59, 13);
            this.ClassLabel.TabIndex = 27;
            this.ClassLabel.Text = "Alignment: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 161);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(434, 277);
            this.textBox1.TabIndex = 29;
            // 
            // CharacterFeaturesLabel
            // 
            this.CharacterFeaturesLabel.AutoSize = true;
            this.CharacterFeaturesLabel.Location = new System.Drawing.Point(479, 142);
            this.CharacterFeaturesLabel.Name = "CharacterFeaturesLabel";
            this.CharacterFeaturesLabel.Size = new System.Drawing.Size(172, 13);
            this.CharacterFeaturesLabel.TabIndex = 30;
            this.CharacterFeaturesLabel.Text = "Features and bonuses of character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CharacterFeaturesLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClassTextBox);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.AlignmentTextBox);
            this.Controls.Add(this.AlignmentLabel);
            this.Controls.Add(this.BackgroundTextBox);
            this.Controls.Add(this.BackgroundLabel);
            this.Controls.Add(this.RaceTextBox);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.StartOverButton);
            this.Controls.Add(this.CharismaTextBox);
            this.Controls.Add(this.CharismaLabel);
            this.Controls.Add(this.DexterityTextBox);
            this.Controls.Add(this.DexterityLabel);
            this.Controls.Add(this.WisdomTextBox);
            this.Controls.Add(this.WisdomLabel);
            this.Controls.Add(this.IntelligenceTextBox);
            this.Controls.Add(this.IntelligenceLabel);
            this.Controls.Add(this.ConstitutionTextBox);
            this.Controls.Add(this.ConstitutionLabel);
            this.Controls.Add(this.StrengthTextBox);
            this.Controls.Add(this.StrengthLabel);
            this.Controls.Add(this.CharacterNameTextBox);
            this.Controls.Add(this.ChracterNameLabel);
            this.Controls.Add(this.CharacterImagePictureBox);
            this.Controls.Add(this.LoadImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.PictureBox CharacterImagePictureBox;
        private System.Windows.Forms.Label ChracterNameLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Button StartOverButton;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.OpenFileDialog OpenCharacterImageDialog;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Label AlignmentLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label CharacterFeaturesLabel;
        public System.Windows.Forms.TextBox CharacterNameTextBox;
        public System.Windows.Forms.TextBox StrengthTextBox;
        public System.Windows.Forms.TextBox ConstitutionTextBox;
        public System.Windows.Forms.TextBox WisdomTextBox;
        public System.Windows.Forms.TextBox IntelligenceTextBox;
        public System.Windows.Forms.TextBox CharismaTextBox;
        public System.Windows.Forms.TextBox DexterityTextBox;
        public System.Windows.Forms.TextBox RaceTextBox;
        public System.Windows.Forms.TextBox BackgroundTextBox;
        public System.Windows.Forms.TextBox AlignmentTextBox;
        public System.Windows.Forms.TextBox ClassTextBox;
        public System.Windows.Forms.TextBox textBox1;
    }
}

