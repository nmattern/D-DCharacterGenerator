namespace DnDCharacterGenerator
{
    partial class ClassSelectionScreencs
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
            this.ClassDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.RaceDescriptionLabel = new System.Windows.Forms.Label();
            this.RaceSelectionScreenButton = new System.Windows.Forms.Button();
            this.Form1Button = new System.Windows.Forms.Button();
            this.SelectAClassLabel = new System.Windows.Forms.Label();
            this.ListOfClassesComboBox = new System.Windows.Forms.ComboBox();
            this.ClassSelectionGreetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassDescriptionTextBox
            // 
            this.ClassDescriptionTextBox.Location = new System.Drawing.Point(280, 104);
            this.ClassDescriptionTextBox.Multiline = true;
            this.ClassDescriptionTextBox.Name = "ClassDescriptionTextBox";
            this.ClassDescriptionTextBox.ReadOnly = true;
            this.ClassDescriptionTextBox.Size = new System.Drawing.Size(508, 260);
            this.ClassDescriptionTextBox.TabIndex = 18;
            // 
            // RaceDescriptionLabel
            // 
            this.RaceDescriptionLabel.AutoSize = true;
            this.RaceDescriptionLabel.Location = new System.Drawing.Point(479, 75);
            this.RaceDescriptionLabel.Name = "RaceDescriptionLabel";
            this.RaceDescriptionLabel.Size = new System.Drawing.Size(99, 13);
            this.RaceDescriptionLabel.TabIndex = 17;
            this.RaceDescriptionLabel.Text = "Description of class";
            // 
            // RaceSelectionScreenButton
            // 
            this.RaceSelectionScreenButton.Location = new System.Drawing.Point(12, 417);
            this.RaceSelectionScreenButton.Name = "RaceSelectionScreenButton";
            this.RaceSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.RaceSelectionScreenButton.TabIndex = 15;
            this.RaceSelectionScreenButton.Text = "Go back to race selection";
            this.RaceSelectionScreenButton.UseVisualStyleBackColor = true;
            this.RaceSelectionScreenButton.Click += new System.EventHandler(this.RaceSelectionScreenButton_Click);
            // 
            // Form1Button
            // 
            this.Form1Button.Location = new System.Drawing.Point(615, 417);
            this.Form1Button.Name = "Form1Button";
            this.Form1Button.Size = new System.Drawing.Size(173, 23);
            this.Form1Button.TabIndex = 14;
            this.Form1Button.Text = "Generate Character";
            this.Form1Button.UseVisualStyleBackColor = true;
            this.Form1Button.Click += new System.EventHandler(this.Form1Button_Click);
            // 
            // SelectAClassLabel
            // 
            this.SelectAClassLabel.AutoSize = true;
            this.SelectAClassLabel.Location = new System.Drawing.Point(8, 65);
            this.SelectAClassLabel.Name = "SelectAClassLabel";
            this.SelectAClassLabel.Size = new System.Drawing.Size(287, 13);
            this.SelectAClassLabel.TabIndex = 13;
            this.SelectAClassLabel.Text = "Select a Class below and click on the button to view details";
            // 
            // ListOfClassesComboBox
            // 
            this.ListOfClassesComboBox.FormattingEnabled = true;
            this.ListOfClassesComboBox.Location = new System.Drawing.Point(45, 104);
            this.ListOfClassesComboBox.Name = "ListOfClassesComboBox";
            this.ListOfClassesComboBox.Size = new System.Drawing.Size(189, 21);
            this.ListOfClassesComboBox.TabIndex = 12;
            this.ListOfClassesComboBox.SelectedIndexChanged += new System.EventHandler(this.ListOfClassesComboBox_SelectedIndexChanged);
            // 
            // ClassSelectionGreetingLabel
            // 
            this.ClassSelectionGreetingLabel.AutoSize = true;
            this.ClassSelectionGreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassSelectionGreetingLabel.Location = new System.Drawing.Point(289, 11);
            this.ClassSelectionGreetingLabel.Name = "ClassSelectionGreetingLabel";
            this.ClassSelectionGreetingLabel.Size = new System.Drawing.Size(202, 31);
            this.ClassSelectionGreetingLabel.TabIndex = 11;
            this.ClassSelectionGreetingLabel.Text = "Class Selection";
            // 
            // ClassSelectionScreencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassDescriptionTextBox);
            this.Controls.Add(this.RaceDescriptionLabel);
            this.Controls.Add(this.RaceSelectionScreenButton);
            this.Controls.Add(this.Form1Button);
            this.Controls.Add(this.SelectAClassLabel);
            this.Controls.Add(this.ListOfClassesComboBox);
            this.Controls.Add(this.ClassSelectionGreetingLabel);
            this.Name = "ClassSelectionScreencs";
            this.Text = "ClassSelectionScreencs";
            this.Load += new System.EventHandler(this.ClassSelectionScreencs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ClassDescriptionTextBox;
        private System.Windows.Forms.Label RaceDescriptionLabel;
        private System.Windows.Forms.Button RaceSelectionScreenButton;
        private System.Windows.Forms.Button Form1Button;
        private System.Windows.Forms.Label SelectAClassLabel;
        private System.Windows.Forms.ComboBox ListOfClassesComboBox;
        private System.Windows.Forms.Label ClassSelectionGreetingLabel;
    }
}