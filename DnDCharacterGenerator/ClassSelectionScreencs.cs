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
    public partial class ClassSelectionScreencs : Form
    {
        public ClassSelectionScreencs()
        {
            InitializeComponent();
        }

        private void RaceSelectionScreenButton_Click(object sender, EventArgs e)
        {
            var alignmentSelectionScreenForm = new RaceSelectionScreen();
            alignmentSelectionScreenForm.Show();
            alignmentSelectionScreenForm.Location = this.Location;
            this.Hide();
            alignmentSelectionScreenForm.FormClosed += (s, args) => this.Close();
        }

        private void Form1Button_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            form1.Location = this.Location;
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }
    }
}
