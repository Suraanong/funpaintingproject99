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
    public partial class _91_protection : Form
    {
        public _91_protection()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _91The_Little_Garden_of_Paradise littleGarden = new _91The_Little_Garden_of_Paradise();
            littleGarden.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _911protection_2 protection2 = new _911protection_2();
            protection2.Show();
            this.Hide();
        }
    }
}
