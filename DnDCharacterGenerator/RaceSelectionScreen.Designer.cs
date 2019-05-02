namespace DnDCharacterGenerator
{
    partial class RaceSelectionScreen
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
            this.RaceSelectionGreetingLabel = new System.Windows.Forms.Label();
            this.ListOfRacesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundSelectionScreenButton = new System.Windows.Forms.Button();
            this.IntroductionScreenButton = new System.Windows.Forms.Button();
            this.RacePictureImageBox = new System.Windows.Forms.PictureBox();
            this.RaceDescriptionLabel = new System.Windows.Forms.Label();
            this.RaceDescriptionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceSelectionGreetingLabel
            // 
            this.RaceSelectionGreetingLabel.AutoSize = true;
            this.RaceSelectionGreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceSelectionGreetingLabel.Location = new System.Drawing.Point(289, 9);
            this.RaceSelectionGreetingLabel.Name = "RaceSelectionGreetingLabel";
            this.RaceSelectionGreetingLabel.Size = new System.Drawing.Size(197, 31);
            this.RaceSelectionGreetingLabel.TabIndex = 0;
            this.RaceSelectionGreetingLabel.Text = "Race Selection";
            // 
            // ListOfRacesComboBox
            // 
            this.ListOfRacesComboBox.FormattingEnabled = true;
            this.ListOfRacesComboBox.Location = new System.Drawing.Point(70, 102);
            this.ListOfRacesComboBox.Name = "ListOfRacesComboBox";
            this.ListOfRacesComboBox.Size = new System.Drawing.Size(189, 21);
            this.ListOfRacesComboBox.TabIndex = 1;
            this.ListOfRacesComboBox.SelectedIndexChanged += new System.EventHandler(this.ListOfRacesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Race below";
            // 
            // BackgroundSelectionScreenButton
            // 
            this.BackgroundSelectionScreenButton.Location = new System.Drawing.Point(615, 415);
            this.BackgroundSelectionScreenButton.Name = "BackgroundSelectionScreenButton";
            this.BackgroundSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.BackgroundSelectionScreenButton.TabIndex = 5;
            this.BackgroundSelectionScreenButton.Text = "Continue to background selection";
            this.BackgroundSelectionScreenButton.UseVisualStyleBackColor = true;
            this.BackgroundSelectionScreenButton.Click += new System.EventHandler(this.BackgroundSelectionScreenButton_Click);
            // 
            // IntroductionScreenButton
            // 
            this.IntroductionScreenButton.Location = new System.Drawing.Point(12, 415);
            this.IntroductionScreenButton.Name = "IntroductionScreenButton";
            this.IntroductionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.IntroductionScreenButton.TabIndex = 6;
            this.IntroductionScreenButton.Text = "Go back to beginning";
            this.IntroductionScreenButton.UseVisualStyleBackColor = true;
            this.IntroductionScreenButton.Click += new System.EventHandler(this.IntroductionScreenButton_Click);
            // 
            // RacePictureImageBox
            // 
            this.RacePictureImageBox.Location = new System.Drawing.Point(86, 165);
            this.RacePictureImageBox.Name = "RacePictureImageBox";
            this.RacePictureImageBox.Size = new System.Drawing.Size(150, 150);
            this.RacePictureImageBox.TabIndex = 7;
            this.RacePictureImageBox.TabStop = false;
            // 
            // RaceDescriptionLabel
            // 
            this.RaceDescriptionLabel.AutoSize = true;
            this.RaceDescriptionLabel.Location = new System.Drawing.Point(527, 63);
            this.RaceDescriptionLabel.Name = "RaceDescriptionLabel";
            this.RaceDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            this.RaceDescriptionLabel.TabIndex = 8;
            this.RaceDescriptionLabel.Text = "Description of race";
            // 
            // RaceDescriptionTextBox
            // 
            this.RaceDescriptionTextBox.Location = new System.Drawing.Point(365, 102);
            this.RaceDescriptionTextBox.Multiline = true;
            this.RaceDescriptionTextBox.Name = "RaceDescriptionTextBox";
            this.RaceDescriptionTextBox.ReadOnly = true;
            this.RaceDescriptionTextBox.Size = new System.Drawing.Size(423, 260);
            this.RaceDescriptionTextBox.TabIndex = 9;
            // 
            // RaceSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RaceDescriptionTextBox);
            this.Controls.Add(this.RaceDescriptionLabel);
            this.Controls.Add(this.RacePictureImageBox);
            this.Controls.Add(this.IntroductionScreenButton);
            this.Controls.Add(this.BackgroundSelectionScreenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOfRacesComboBox);
            this.Controls.Add(this.RaceSelectionGreetingLabel);
            this.Name = "RaceSelectionScreen";
            this.Text = "RaceSelectionScreen";
            this.Load += new System.EventHandler(this.RaceSelectionScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RaceSelectionGreetingLabel;
        private System.Windows.Forms.ComboBox ListOfRacesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackgroundSelectionScreenButton;
        private System.Windows.Forms.Button IntroductionScreenButton;
        private System.Windows.Forms.PictureBox RacePictureImageBox;
        private System.Windows.Forms.Label RaceDescriptionLabel;
        private System.Windows.Forms.TextBox RaceDescriptionTextBox;
    }
}