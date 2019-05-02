namespace DnDCharacterGenerator
{
    partial class AlignmentSelectionScreen
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
            this.LoadAlignmentButton = new System.Windows.Forms.Button();
            this.AlignmentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AlignmentDescriptionLabel = new System.Windows.Forms.Label();
            this.BackgroundSelectionScreenButton = new System.Windows.Forms.Button();
            this.ClassSelectionScreenButton = new System.Windows.Forms.Button();
            this.SelectAnAlignmentLabel = new System.Windows.Forms.Label();
            this.ListOfAlignmentsComboBox = new System.Windows.Forms.ComboBox();
            this.AlignmentSelectionGreetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadAlignmentButton
            // 
            this.LoadAlignmentButton.Location = new System.Drawing.Point(96, 138);
            this.LoadAlignmentButton.Name = "LoadAlignmentButton";
            this.LoadAlignmentButton.Size = new System.Drawing.Size(128, 23);
            this.LoadAlignmentButton.TabIndex = 35;
            this.LoadAlignmentButton.Text = "Load Background Details";
            this.LoadAlignmentButton.UseVisualStyleBackColor = true;
            // 
            // AlignmentDescriptionTextBox
            // 
            this.AlignmentDescriptionTextBox.Location = new System.Drawing.Point(365, 104);
            this.AlignmentDescriptionTextBox.Multiline = true;
            this.AlignmentDescriptionTextBox.Name = "AlignmentDescriptionTextBox";
            this.AlignmentDescriptionTextBox.ReadOnly = true;
            this.AlignmentDescriptionTextBox.Size = new System.Drawing.Size(423, 260);
            this.AlignmentDescriptionTextBox.TabIndex = 34;
            // 
            // AlignmentDescriptionLabel
            // 
            this.AlignmentDescriptionLabel.AutoSize = true;
            this.AlignmentDescriptionLabel.Location = new System.Drawing.Point(527, 65);
            this.AlignmentDescriptionLabel.Name = "AlignmentDescriptionLabel";
            this.AlignmentDescriptionLabel.Size = new System.Drawing.Size(120, 13);
            this.AlignmentDescriptionLabel.TabIndex = 33;
            this.AlignmentDescriptionLabel.Text = "Description of alignment";
            // 
            // BackgroundSelectionScreenButton
            // 
            this.BackgroundSelectionScreenButton.Location = new System.Drawing.Point(12, 417);
            this.BackgroundSelectionScreenButton.Name = "BackgroundSelectionScreenButton";
            this.BackgroundSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.BackgroundSelectionScreenButton.TabIndex = 32;
            this.BackgroundSelectionScreenButton.Text = "Go back to background selection";
            this.BackgroundSelectionScreenButton.UseVisualStyleBackColor = true;
            this.BackgroundSelectionScreenButton.Click += new System.EventHandler(this.BackgroundSelectionScreenButton_Click);
            // 
            // ClassSelectionScreenButton
            // 
            this.ClassSelectionScreenButton.Location = new System.Drawing.Point(615, 417);
            this.ClassSelectionScreenButton.Name = "ClassSelectionScreenButton";
            this.ClassSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.ClassSelectionScreenButton.TabIndex = 31;
            this.ClassSelectionScreenButton.Text = "Continue to class selection";
            this.ClassSelectionScreenButton.UseVisualStyleBackColor = true;
            this.ClassSelectionScreenButton.Click += new System.EventHandler(this.ClassSelectionScreenButton_Click);
            // 
            // SelectAnAlignmentLabel
            // 
            this.SelectAnAlignmentLabel.AutoSize = true;
            this.SelectAnAlignmentLabel.Location = new System.Drawing.Point(33, 65);
            this.SelectAnAlignmentLabel.Name = "SelectAnAlignmentLabel";
            this.SelectAnAlignmentLabel.Size = new System.Drawing.Size(314, 13);
            this.SelectAnAlignmentLabel.TabIndex = 30;
            this.SelectAnAlignmentLabel.Text = "Select an Alignment below and click on the button to view details";
            // 
            // ListOfAlignmentsComboBox
            // 
            this.ListOfAlignmentsComboBox.FormattingEnabled = true;
            this.ListOfAlignmentsComboBox.Location = new System.Drawing.Point(70, 104);
            this.ListOfAlignmentsComboBox.Name = "ListOfAlignmentsComboBox";
            this.ListOfAlignmentsComboBox.Size = new System.Drawing.Size(189, 21);
            this.ListOfAlignmentsComboBox.TabIndex = 29;
            // 
            // AlignmentSelectionGreetingLabel
            // 
            this.AlignmentSelectionGreetingLabel.AutoSize = true;
            this.AlignmentSelectionGreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlignmentSelectionGreetingLabel.Location = new System.Drawing.Point(289, 11);
            this.AlignmentSelectionGreetingLabel.Name = "AlignmentSelectionGreetingLabel";
            this.AlignmentSelectionGreetingLabel.Size = new System.Drawing.Size(253, 31);
            this.AlignmentSelectionGreetingLabel.TabIndex = 28;
            this.AlignmentSelectionGreetingLabel.Text = "Alignment Selection";
            // 
            // AlignmentSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadAlignmentButton);
            this.Controls.Add(this.AlignmentDescriptionTextBox);
            this.Controls.Add(this.AlignmentDescriptionLabel);
            this.Controls.Add(this.BackgroundSelectionScreenButton);
            this.Controls.Add(this.ClassSelectionScreenButton);
            this.Controls.Add(this.SelectAnAlignmentLabel);
            this.Controls.Add(this.ListOfAlignmentsComboBox);
            this.Controls.Add(this.AlignmentSelectionGreetingLabel);
            this.Name = "AlignmentSelectionScreen";
            this.Text = "AlignmentSelectionScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadAlignmentButton;
        private System.Windows.Forms.TextBox AlignmentDescriptionTextBox;
        private System.Windows.Forms.Label AlignmentDescriptionLabel;
        private System.Windows.Forms.Button BackgroundSelectionScreenButton;
        private System.Windows.Forms.Button ClassSelectionScreenButton;
        private System.Windows.Forms.Label SelectAnAlignmentLabel;
        private System.Windows.Forms.ComboBox ListOfAlignmentsComboBox;
        private System.Windows.Forms.Label AlignmentSelectionGreetingLabel;
    }
}