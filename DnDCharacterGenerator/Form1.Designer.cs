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
            this.FinalCharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.StartOverButton = new System.Windows.Forms.Button();
            this.OpenCharacterImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.FinalCharacterDescriptionTextBox = new System.Windows.Forms.TextBox();
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
            // FinalCharacterNameTextBox
            // 
            this.FinalCharacterNameTextBox.Location = new System.Drawing.Point(110, 8);
            this.FinalCharacterNameTextBox.Name = "FinalCharacterNameTextBox";
            this.FinalCharacterNameTextBox.ReadOnly = true;
            this.FinalCharacterNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.FinalCharacterNameTextBox.TabIndex = 3;
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
            // OpenCharacterImageDialog
            // 
            this.OpenCharacterImageDialog.FileName = "openFileDialog1";
            this.OpenCharacterImageDialog.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP";
            // 
            // FinalCharacterDescriptionTextBox
            // 
            this.FinalCharacterDescriptionTextBox.Location = new System.Drawing.Point(313, 46);
            this.FinalCharacterDescriptionTextBox.Multiline = true;
            this.FinalCharacterDescriptionTextBox.Name = "FinalCharacterDescriptionTextBox";
            this.FinalCharacterDescriptionTextBox.ReadOnly = true;
            this.FinalCharacterDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FinalCharacterDescriptionTextBox.Size = new System.Drawing.Size(475, 392);
            this.FinalCharacterDescriptionTextBox.TabIndex = 29;
            // 
            // CharacterFeaturesLabel
            // 
            this.CharacterFeaturesLabel.AutoSize = true;
            this.CharacterFeaturesLabel.Location = new System.Drawing.Point(476, 15);
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
            this.Controls.Add(this.FinalCharacterDescriptionTextBox);
            this.Controls.Add(this.StartOverButton);
            this.Controls.Add(this.FinalCharacterNameTextBox);
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
        private System.Windows.Forms.Button StartOverButton;
        private System.Windows.Forms.OpenFileDialog OpenCharacterImageDialog;
        private System.Windows.Forms.Label CharacterFeaturesLabel;
        public System.Windows.Forms.TextBox FinalCharacterNameTextBox;
        public System.Windows.Forms.TextBox FinalCharacterDescriptionTextBox;
    }
}

