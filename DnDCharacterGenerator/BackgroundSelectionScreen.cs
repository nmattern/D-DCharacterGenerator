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
    public partial class BackgroundSelectionScreen : Form
    {
        public BackgroundSelectionScreen()
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

        private void AlignmentSelectionScreenButton_Click(object sender, EventArgs e)
        {
            var alignmentSelectionScreenForm = new AlignmentSelectionScreen();
            alignmentSelectionScreenForm.Show();
            alignmentSelectionScreenForm.Location = this.Location;
            this.Hide();
            alignmentSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }
    }
}
