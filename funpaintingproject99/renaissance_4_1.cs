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
    public partial class renaissance_4_1 : Form
    {
        public renaissance_4_1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            renaissance_4 renaissance_4 = new renaissance_4();
            renaissance_4.Show();
            this.Hide();
        }
    }
}
