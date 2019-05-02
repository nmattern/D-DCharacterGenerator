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
    public partial class AlignmentSelectionScreen : Form
    {
        public AlignmentSelectionScreen()
        {
            InitializeComponent();
        }

        private void BackgroundSelectionScreenButton_Click(object sender, EventArgs e)
        {
            var backgroundSelectionScreenForm = new BackgroundSelectionScreen();
            backgroundSelectionScreenForm.Show();
            backgroundSelectionScreenForm.Location = this.Location;
            this.Hide();
            backgroundSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }

        private void ClassSelectionScreenButton_Click(object sender, EventArgs e)
        {
            var classSelectionScreenForm = new ClassSelectionScreencs();
            classSelectionScreenForm.Show();
            classSelectionScreenForm.Location = this.Location;
            this.Hide();
            classSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }
    }
}
