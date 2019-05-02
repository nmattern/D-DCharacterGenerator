using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterGenerator
{
    public partial class Form1 : Form
    {
        private string _CharacterName;
        public string CharacterName
        {
            get { return _CharacterName; }
            set { _CharacterName = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CharacterNameTextBox.Text = CharacterName;
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
