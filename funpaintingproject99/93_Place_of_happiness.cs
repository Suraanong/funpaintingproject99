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
    public partial class _93_Place_of_happiness : Form
    {
        public _93_Place_of_happiness()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _91The_Little_Garden_of_Paradise littleGarden = new _91The_Little_Garden_of_Paradise();
            littleGarden.Show();
            this.Hide();
        }
    }
}
