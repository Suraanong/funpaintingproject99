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
    public partial class justinian : Form
    {
        public justinian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _1homage homage = new _1homage();
            homage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _4_tension tension = new _4_tension();
            tension.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _5_authorities authorities = new _5_authorities();
            authorities.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medievalera medievalera = new medievalera();
            medievalera.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _6_the_lamentation_of_Christ lamentation = new _6_the_lamentation_of_Christ();
            lamentation.Show();
            this.Hide();
        }
    }
}
