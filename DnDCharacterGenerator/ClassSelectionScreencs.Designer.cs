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
            this.LoadClassButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RaceDescriptionLabel = new System.Windows.Forms.Label();
            this.AlignmentSelectionScreenButton = new System.Windows.Forms.Button();
            this.Form1Button = new System.Windows.Forms.Button();
            this.SelectAClassLabel = new System.Windows.Forms.Label();
            this.ListOfClassesComboBox = new System.Windows.Forms.ComboBox();
            this.ClassSelectionGreetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadClassButton
            // 
            this.LoadClassButton.Location = new System.Drawing.Point(96, 138);
            this.LoadClassButton.Name = "LoadClassButton";
            this.LoadClassButton.Size = new System.Drawing.Size(128, 23);
            this.LoadClassButton.TabIndex = 19;
            this.LoadClassButton.Text = "Load Class Details";
            this.LoadClassButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(423, 260);
            this.textBox1.TabIndex = 18;
            // 
            // RaceDescriptionLabel
            // 
            this.RaceDescriptionLabel.AutoSize = true;
            this.RaceDescriptionLabel.Location = new System.Drawing.Point(527, 65);
            this.RaceDescriptionLabel.Name = "RaceDescriptionLabel";
            this.RaceDescriptionLabel.Size = new System.Drawing.Size(99, 13);
            this.RaceDescriptionLabel.TabIndex = 17;
            this.RaceDescriptionLabel.Text = "Description of class";
            // 
            // AlignmentSelectionScreenButton
            // 
            this.AlignmentSelectionScreenButton.Location = new System.Drawing.Point(12, 417);
            this.AlignmentSelectionScreenButton.Name = "AlignmentSelectionScreenButton";
            this.AlignmentSelectionScreenButton.Size = new System.Drawing.Size(173, 23);
            this.AlignmentSelectionScreenButton.TabIndex = 15;
            this.AlignmentSelectionScreenButton.Text = "Go back to alignment selection";
            this.AlignmentSelectionScreenButton.UseVisualStyleBackColor = true;
            this.AlignmentSelectionScreenButton.Click += new System.EventHandler(this.AlignmentSelectionScreenButton_Click);
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
            this.SelectAClassLabel.Location = new System.Drawing.Point(33, 65);
            this.SelectAClassLabel.Name = "SelectAClassLabel";
            this.SelectAClassLabel.Size = new System.Drawing.Size(287, 13);
            this.SelectAClassLabel.TabIndex = 13;
            this.SelectAClassLabel.Text = "Select a Class below and click on the button to view details";
            // 
            // ListOfClassesComboBox
            // 
            this.ListOfClassesComboBox.FormattingEnabled = true;
            this.ListOfClassesComboBox.Location = new System.Drawing.Point(70, 104);
            this.ListOfClassesComboBox.Name = "ListOfClassesComboBox";
            this.ListOfClassesComboBox.Size = new System.Drawing.Size(189, 21);
            this.ListOfClassesComboBox.TabIndex = 12;
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
            this.Controls.Add(this.LoadClassButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RaceDescriptionLabel);
            this.Controls.Add(this.AlignmentSelectionScreenButton);
            this.Controls.Add(this.Form1Button);
            this.Controls.Add(this.SelectAClassLabel);
            this.Controls.Add(this.ListOfClassesComboBox);
            this.Controls.Add(this.ClassSelectionGreetingLabel);
            this.Name = "ClassSelectionScreencs";
            this.Text = "ClassSelectionScreencs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadClassButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RaceDescriptionLabel;
        private System.Windows.Forms.Button AlignmentSelectionScreenButton;
        private System.Windows.Forms.Button Form1Button;
        private System.Windows.Forms.Label SelectAClassLabel;
        private System.Windows.Forms.ComboBox ListOfClassesComboBox;
        private System.Windows.Forms.Label ClassSelectionGreetingLabel;
    }
}