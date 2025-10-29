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
    public partial class renaissance_4 : Form
    {
        public renaissance_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renaissance_4_1 renaissance_4_1 = new renaissance_4_1();
            renaissance_4_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renaissance_4_2 renaissance_4_2 = new renaissance_4_2();
            renaissance_4_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            renaissance_4_4 renaissance_4_4 = new renaissance_4_4();
            renaissance_4_4.Show();
            this.Hide();
        }
    }
}
