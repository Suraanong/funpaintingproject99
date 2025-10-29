using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funpaintingproject99
{
    public partial class _9_senseofmovement : Form
    {
        public _9_senseofmovement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _6_the_lamentation_of_Christ _6_thelamentaton_of_Christ = new _6_the_lamentation_of_Christ();
            _6_thelamentaton_of_Christ.Show();
            this.Hide();
        }
    }
}
