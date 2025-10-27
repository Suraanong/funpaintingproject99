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
    public partial class Contemporary_art_2 : Form
    {
        public Contemporary_art_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contemporary_art_2_1 Con_2_1 = new Contemporary_art_2_1();
            Con_2_1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contemporary_art_main Con_main = new Contemporary_art_main();
            Con_main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contemporary_art_2_2 Con_2_2 = new Contemporary_art_2_2();
            Con_2_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contemporary_art_2_3 Con_2_3 = new Contemporary_art_2_3();
            Con_2_3.Show();
            this.Hide();
        }
    }
}
