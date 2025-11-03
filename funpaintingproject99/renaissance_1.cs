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
    public partial class renaissance_1 : Form
    {
        public renaissance_1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            renaissance_2 renaissance_2 = new renaissance_2();
            renaissance_2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            renaissance_2 renaissance_2 = new renaissance_2();
            renaissance_2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            renaissance_3 renaissance_3 = new renaissance_3();
            renaissance_3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            renaissance_3 renaissance_3 = new renaissance_3();
            renaissance_3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            renaissance_4 renaissance_4 = new renaissance_4();
            renaissance_4.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Neoclassical_main Neo_main = new Neoclassical_main();  // ✅ ใช้ new
            Neo_main.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medievalera medievalera = new medievalera();
            medievalera.Show();
            this.Hide();
        }
    }
}
