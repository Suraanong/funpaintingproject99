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
    public partial class medievalera : Form
    {
        public medievalera()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            justinian justinian = new justinian();
            justinian.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           justinian justinian = new justinian();
              justinian.Show();
                this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home home = new home();
           home.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home home = new home();
                home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _6_the_lamentation_of_Christ _6_thelamentaton_of_Christ = new _6_the_lamentation_of_Christ();
                _6_thelamentaton_of_Christ.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            _6_the_lamentation_of_Christ _6_thelamentaton_of_Christ = new _6_the_lamentation_of_Christ();
                _6_thelamentaton_of_Christ.Show();
            this.Hide();
        }

        private void medievalera_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _91The_Little_Garden_of_Paradise littleGarden = new _91The_Little_Garden_of_Paradise();
                littleGarden.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            _91The_Little_Garden_of_Paradise littleGarden = new _91The_Little_Garden_of_Paradise();
                littleGarden.Show();    
            this.Hide();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            renaissance_1 renaissance_1 = new renaissance_1();
                renaissance_1.Show();
            this.Hide();
        }
    }
}
