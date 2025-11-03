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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            medievalera medievalera = new medievalera();
            medievalera.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medievalera medievalera = new medievalera();
            medievalera.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
