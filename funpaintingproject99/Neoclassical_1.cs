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
    public partial class Neoclassical_1 : Form
    {
        public Neoclassical_1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Neoclassical_1_1 Neo_1 = new Neoclassical_1_1();  // ✅ ใช้ new
            Neo_1.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Neoclassical_1_2 Neo_2 = new Neoclassical_1_2();  // ✅ ใช้ new
            Neo_2.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Neoclassical_1_3 Neo_3 = new Neoclassical_1_3();  // ✅ ใช้ new
            Neo_3.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Neoclassical_main Neo_main = new Neoclassical_main();  // ✅ ใช้ new
            Neo_main.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }
    }
}
