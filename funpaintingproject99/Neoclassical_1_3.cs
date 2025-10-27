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
    public partial class Neoclassical_1_3 : Form
    {
        public Neoclassical_1_3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Neoclassical_1 Neo = new Neoclassical_1();  // ✅ ใช้ new
            Neo.Show();  // ✅ เปิดฟอร์มใหม่
            this.Hide();     // ✅ ซ่อนฟอร์มปัจจุบัน
        }
    }
}
