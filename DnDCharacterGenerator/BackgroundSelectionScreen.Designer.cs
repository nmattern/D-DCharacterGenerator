namespace DnDCharacterGenerator
{
    partial class BackgroundSelectionScreen
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
            this.LoadBackgroundButton = new System.Windows.Forms.Button();
            this.BackgroundDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundDescriptionLabel = new System.Windows.Forms.Label();
            this.RaceSelectionScreenButton = new System.Windows.Forms.Button();
            this.AlignmentSelectionScreenButton = new System.Windows.Forms.Button();
            this.SelectABackgroundLabel = new System.Windows.Forms.Label();
            this.ListOfBackgroundsComboBox = new System.Windows.Forms.ComboBox();
            this.BackgroundSelectionGreetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadBackgroundButton
            // 
            this.LoadBackgroundButton.Location = new System.Drawing.Point(96, 138);
            this.LoadBackgroundButton.Name = "LoadBackgroundButton";
            this.LoadBackgroundButton.Size = new System.Drawing.Size(128, 23);
            this.LoadBackgroundButton.TabIndex = 27;
            this.LoadBackgroundButton.Text = "Load Background Details";
            this.LoadBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // BackgroundDescriptionTextBox
            // 
            this.BackgroundDescriptionTextBox.Location = new System.Drawing.Point(365, 104);
            this.BackgroundDescriptionTextBox.Multiline = true;
            this.BackgroundDescriptionTextBox.Name = "BackgroundDescriptionTextBox";
            this.BackgroundDescriptionTextBox.ReadOnly = true;
            this.BackgroundDescriptionTextBox.Size = new System.Drawing.Size(423, 260);
            this.BackgroundDescriptionTextBox.TabIndex = 26;
            // 
            // BackgroundDescriptionLabel
            // 
            this.BackgroundDescriptionLabel.AutoSize = true;
            this.BackgroundDescriptionLabel.Location = new System.Drawing.Point(527, 65);
            this.BackgroundDescriptionLabel.Name = "BackgroundDescriptionLabel";
            this.BackgroundDescriptionLabel.Size = new System.Drawing.Size(132, 13);
            this.BackgroundDescriptionLabel.TabIndex = 25;
            this.BackgroundDescriptionLabel.Text = "Description of background";
            // 
            // RaceSelectionScreenButton
            // 
            this.RaceSelectionScreenButton.Location = new System.Drawing.Point(12, 417);
            this.RaceSelectionScreenButton.Name = "RaceSelectionScreenButton";
            this.RaceSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.RaceSelectionScreenButton.TabIndex = 24;
            this.RaceSelectionScreenButton.Text = "Go back to race selection";
            this.RaceSelectionScreenButton.UseVisualStyleBackColor = true;
            this.RaceSelectionScreenButton.Click += new System.EventHandler(this.RaceSelectionScreenButton_Click);
            // 
            // AlignmentSelectionScreenButton
            // 
            this.AlignmentSelectionScreenButton.Location = new System.Drawing.Point(615, 417);
            this.AlignmentSelectionScreenButton.Name = "AlignmentSelectionScreenButton";
            this.AlignmentSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.AlignmentSelectionScreenButton.TabIndex = 23;
            this.AlignmentSelectionScreenButton.Text = "Continue to alignment selection";
            this.AlignmentSelectionScreenButton.UseVisualStyleBackColor = true;
            this.AlignmentSelectionScreenButton.Click += new System.EventHandler(this.AlignmentSelectionScreenButton_Click);
            // 
            // SelectABackgroundLabel
            // 
            this.SelectABackgroundLabel.AutoSize = true;
            this.SelectABackgroundLabel.Location = new System.Drawing.Point(33, 65);
            this.SelectABackgroundLabel.Name = "SelectABackgroundLabel";
            this.SelectABackgroundLabel.Size = new System.Drawing.Size(320, 13);
            this.SelectABackgroundLabel.TabIndex = 22;
            this.SelectABackgroundLabel.Text = "Select a Background below and click on the button to view details";
            // 
            // ListOfBackgroundsComboBox
            // 
            this.ListOfBackgroundsComboBox.FormattingEnabled = true;
            this.ListOfBackgroundsComboBox.Location = new System.Drawing.Point(70, 104);
            this.ListOfBackgroundsComboBox.Name = "ListOfBackgroundsComboBox";
            this.ListOfBackgroundsComboBox.Size = new System.Drawing.Size(189, 21);
            this.ListOfBackgroundsComboBox.TabIndex = 21;
            // 
            // BackgroundSelectionGreetingLabel
            // 
            this.BackgroundSelectionGreetingLabel.AutoSize = true;
            this.BackgroundSelectionGreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundSelectionGreetingLabel.Location = new System.Drawing.Point(289, 11);
            this.BackgroundSelectionGreetingLabel.Name = "BackgroundSelectionGreetingLabel";
            this.BackgroundSelectionGreetingLabel.Size = new System.Drawing.Size(278, 31);
            this.BackgroundSelectionGreetingLabel.TabIndex = 20;
            this.BackgroundSelectionGreetingLabel.Text = "Background Selection";
            // 
            // BackgroundSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadBackgroundButton);
            this.Controls.Add(this.BackgroundDescriptionTextBox);
            this.Controls.Add(this.BackgroundDescriptionLabel);
            this.Controls.Add(this.RaceSelectionScreenButton);
            this.Controls.Add(this.AlignmentSelectionScreenButton);
            this.Controls.Add(this.SelectABackgroundLabel);
            this.Controls.Add(this.ListOfBackgroundsComboBox);
            this.Controls.Add(this.BackgroundSelectionGreetingLabel);
            this.Name = "BackgroundSelectionScreen";
            this.Text = "BackgroundSelectionScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBackgroundButton;
        private System.Windows.Forms.TextBox BackgroundDescriptionTextBox;
        private System.Windows.Forms.Label BackgroundDescriptionLabel;
        private System.Windows.Forms.Button RaceSelectionScreenButton;
        private System.Windows.Forms.Button AlignmentSelectionScreenButton;
        private System.Windows.Forms.Label SelectABackgroundLabel;
        private System.Windows.Forms.ComboBox ListOfBackgroundsComboBox;
        private System.Windows.Forms.Label BackgroundSelectionGreetingLabel;
    }
}