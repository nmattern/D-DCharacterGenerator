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
    public partial class IntroductionScreen : Form
    {
        public IntroductionScreen()
        {
            InitializeComponent();
        }


        private void RaceSelectionScreenButton_Click(object sender, EventArgs e)
        {
            var raceSelectionScreenForm = new RaceSelectionScreen();
            raceSelectionScreenForm.Show();
            raceSelectionScreenForm.Location = this.Location;
            this.Hide();
            raceSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }
    }
}
