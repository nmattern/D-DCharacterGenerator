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
    public partial class RaceSelectionScreen : Form
    {
        public RaceSelectionScreen()
        {
            InitializeComponent();
        }


        private void IntroductionScreenButton_Click(object sender, EventArgs e)
        {
            var introductionSelectionScreenForm = new IntroductionScreen();
            introductionSelectionScreenForm.Show();
            introductionSelectionScreenForm.Location = this.Location;
            this.Hide();
            introductionSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }

        private void BackgroundSelectionScreenButton_Click(object sender, EventArgs e)
        {
            var backgroundSelectionScreenForm = new BackgroundSelectionScreen();
            backgroundSelectionScreenForm.Show();
            backgroundSelectionScreenForm.Location = this.Location;
            this.Hide();
            backgroundSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }

        private void ListOfRacesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ListOfRacesComboBox.SelectedIndex)
            {
                case 0:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/468/150/150/636377891490355427.jpeg";
                        break;
                    }
                case 1:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/456/150/150/636377890325250045.jpeg";
                        break;
                    }
                case 2:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/449/150/150/636377889693945829.jpeg";
                        break;
                    }
                case 3:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/415/150/150/636377885173419481.jpeg";
                        break;
                    }
                case 4:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/400/150/150/636377883039596116.jpeg";
                        break;
                    }
                case 5:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/214/150/150/636377841114911601.jpeg";
                        break;
                    }
                case 6:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/460/150/150/636377890745985870.jpeg";
                        break;
                    }
                case 7:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/746/150/150/636378331319294770.jpeg";
                        break;
                    }
                case 8:
                    {
                        RacePictureImageBox.ImageLocation = "https://media-waterdeep.cursecdn.com/avatars/thumbnails/17/931/150/150/636378855466216266.png";
                        break;
                    }
            }
        }

        private void RaceSelectionScreen_Load(object sender, EventArgs e)
        {
            ListOfRacesComboBox.Items.Add("Dwarf");
            ListOfRacesComboBox.Items.Add("Elf");
            ListOfRacesComboBox.Items.Add("Halfling");
            ListOfRacesComboBox.Items.Add("Human");
            ListOfRacesComboBox.Items.Add("Dragonborn");
            ListOfRacesComboBox.Items.Add("Gnome");
            ListOfRacesComboBox.Items.Add("Half-Elf");
            ListOfRacesComboBox.Items.Add("Half-Orc");
            ListOfRacesComboBox.Items.Add("Tiefling");
        }
    }
}
