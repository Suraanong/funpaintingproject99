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
    public partial class renaissance_3 : Form
    {
        public renaissance_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renaissance_3_1 renaissance_3_1 = new renaissance_3_1();
            renaissance_3_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renaissance_3_3 renaissance_3_2 = new renaissance_3_3();
            renaissance_3_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            renaissance_3_4 renaissance_3_4 = new renaissance_3_4();
            renaissance_3_4.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            renaissance_1 renaissance_1 = new renaissance_1();
            renaissance_1.Show();
            this.Hide();
        }
    }
}
