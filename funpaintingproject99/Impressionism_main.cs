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
    public partial class Impressionism_main : Form
    {
        public Impressionism_main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Impressionism_main_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Neoclassical_main Neo_main = new Neoclassical_main();  // ✅ ใช้ new
            Neo_main.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contemporary_art_main con_main = new Contemporary_art_main();  // ✅ ใช้ new
            con_main.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน// ✅ ซ่อนฟอร์มปัจจุบัน (ถ้าต้องการ)
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Impressionism_1 Im_1 = new Impressionism_1();  // ✅ ใช้ new
            Im_1.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Impressionism_2 Im_2 = new Impressionism_2();
            Im_2.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Impressionism_3 Im_3 = new Impressionism_3();
            Im_3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
    }
    }

