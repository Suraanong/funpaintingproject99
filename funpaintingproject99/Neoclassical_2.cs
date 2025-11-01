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
    public partial class Neoclassical_2 : Form
    {
        public Neoclassical_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Neoclassical_2_1 Neo_2_1 = new Neoclassical_2_1();  // ✅ ใช้ new
            Neo_2_1.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Neoclassical_2_2 Neo_2_2 = new Neoclassical_2_2();  // ✅ ใช้ new
            Neo_2_2.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Neoclassical_2_3 Neo_2_3 = new Neoclassical_2_3();  // ✅ ใช้ new
            Neo_2_3.Show();  // ✅ เปิดฟอร์มใหม่
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
