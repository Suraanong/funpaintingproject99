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
    public partial class Neoclassical_3_2 : Form
    {
        public Neoclassical_3_2()
        {
            InitializeComponent();
        }

        private void Neoclassical_3_2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Neoclassical_3 Neo33 = new Neoclassical_3();  // ✅ ใช้ new
            Neo33.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }
    }
}
