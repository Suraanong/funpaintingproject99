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
    public partial class Contemporary_art_1 : Form
    {
        public Contemporary_art_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contemporary_art_1_1 Con_1_1 = new Contemporary_art_1_1();
            Con_1_1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Contemporary_art_1_2 Con_1_2 = new Contemporary_art_1_2();
            Con_1_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Contemporary_art_1_3 Con_1_3 = new Contemporary_art_1_3();
            Con_1_3.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contemporary_art_main Con_main = new Contemporary_art_main();
            Con_main.Show();
            this.Hide();

        }
    }
}
