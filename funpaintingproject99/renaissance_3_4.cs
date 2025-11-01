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
    public partial class renaissance_3_4 : Form
    {
        public renaissance_3_4()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            renaissance_3 renaissance_3 = new renaissance_3();
            renaissance_3.Show();
            this.Hide();
        }
    }
}
