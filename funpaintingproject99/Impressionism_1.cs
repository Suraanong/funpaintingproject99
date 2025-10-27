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
    public partial class Impressionism_1 : Form
    {
        public Impressionism_1()
        {
            InitializeComponent();
        }

        private void Impressionism_1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Impressionism_1_1 Im_1_1 = new Impressionism_1_1();  // ✅ ใช้ new
            Im_1_1.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Impressionism_1_2 Im_1_2 = new Impressionism_1_2();  // ✅ ใช้ new
            Im_1_2.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Impressionism_1_3 Im_1_3 = new Impressionism_1_3();  // ✅ ใช้ new
            Im_1_3.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Impressionism_main Im_main = new Impressionism_main();  // ✅ ใช้ new
            Im_main.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }
    }
}
