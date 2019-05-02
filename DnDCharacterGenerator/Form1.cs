using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FinalCharacterNameTextBox.Text = PlayerCharacter.CharacterName;
            FinalCharacterDescriptionTextBox.Text += PlayerCharacter.RaceText + "\r\n" + PlayerCharacter.ClassText;
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            if (OpenCharacterImageDialog.ShowDialog() == DialogResult.OK)
            {
                CharacterImagePictureBox.Image = Image.FromFile(OpenCharacterImageDialog.FileName);
            }
        }

        private void StartOverButton_Click(object sender, EventArgs e)
        {
            var introductionScreenForm = new IntroductionScreen();
            introductionScreenForm.Show();
            introductionScreenForm.Location = this.Location;
            this.Hide();
            introductionScreenForm.FormClosed += (s, args) => this.Close();
        }
    }
}
