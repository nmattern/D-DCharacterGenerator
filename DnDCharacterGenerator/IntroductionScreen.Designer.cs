namespace DnDCharacterGenerator
{
    partial class IntroductionScreen
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
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.IntroductionExplanationLabel = new System.Windows.Forms.Label();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.RaceSelectionScreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel.Location = new System.Drawing.Point(138, 47);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(519, 31);
            this.GreetingLabel.TabIndex = 0;
            this.GreetingLabel.Text = "Welcome to the DnD Character Generator";
            // 
            // IntroductionExplanationLabel
            // 
            this.IntroductionExplanationLabel.AutoSize = true;
            this.IntroductionExplanationLabel.Location = new System.Drawing.Point(232, 104);
            this.IntroductionExplanationLabel.Name = "IntroductionExplanationLabel";
            this.IntroductionExplanationLabel.Size = new System.Drawing.Size(331, 13);
            this.IntroductionExplanationLabel.TabIndex = 1;
            this.IntroductionExplanationLabel.Text = "Please enter a name below to being, or generate a random character";
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(232, 171);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(90, 13);
            this.EnterNameLabel.TabIndex = 2;
            this.EnterNameLabel.Text = "Character Name: ";
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(329, 168);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.CharacterNameTextBox.TabIndex = 3;
            // 
            // RaceSelectionScreenButton
            // 
            this.RaceSelectionScreenButton.Location = new System.Drawing.Point(615, 415);
            this.RaceSelectionScreenButton.Name = "RaceSelectionScreenButton";
            this.RaceSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.RaceSelectionScreenButton.TabIndex = 4;
            this.RaceSelectionScreenButton.Text = "Continue to race selection";
            this.RaceSelectionScreenButton.UseVisualStyleBackColor = true;
            this.RaceSelectionScreenButton.Click += new System.EventHandler(this.RaceSelectionScreenButton_Click);
            // 
            // IntroductionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RaceSelectionScreenButton);
            this.Controls.Add(this.CharacterNameTextBox);
            this.Controls.Add(this.EnterNameLabel);
            this.Controls.Add(this.IntroductionExplanationLabel);
            this.Controls.Add(this.GreetingLabel);
            this.Name = "IntroductionScreen";
            this.Text = "Introduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Label IntroductionExplanationLabel;
        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Button RaceSelectionScreenButton;
    }
}