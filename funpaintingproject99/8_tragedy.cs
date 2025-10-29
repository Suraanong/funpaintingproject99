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
    public partial class _8_tragedy : Form
    {
        public _8_tragedy()
        {
            InitializeComponent();
        }

        private void _8_tragedy_Load(object sender, EventArgs e)
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
