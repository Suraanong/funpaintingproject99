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
    public partial class Impressionism_3 : Form
    {
        public Impressionism_3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Impressionism_main Im_main = new Impressionism_main();  // ✅ ใช้ new
            Im_main.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Impressionism_3_1 Im_3_1 = new Impressionism_3_1();  // ✅ ใช้ new
            Im_3_1.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impressionism_3_2 Im_3_2 = new Impressionism_3_2();  // ✅ ใช้ new
            Im_3_2.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Impressionism_3_3 Im_3_3 = new Impressionism_3_3();  // ✅ ใช้ new
            Im_3_3.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }
    }
}
