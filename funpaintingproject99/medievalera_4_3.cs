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
    public partial class _92_Spiritual_benefits : Form
    {
        public _92_Spiritual_benefits()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _91The_Little_Garden_of_Paradise littleGarden = new _91The_Little_Garden_of_Paradise();
            littleGarden.Show();
            this.Hide();
        }
    }
}
