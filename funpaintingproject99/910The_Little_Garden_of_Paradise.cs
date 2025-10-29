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
    public partial class _91The_Little_Garden_of_Paradise : Form
    {
        public _91The_Little_Garden_of_Paradise()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medievalera medievalera = new medievalera();
            medievalera.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _91_protection _91_protection = new _91_protection();
            _91_protection.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _92_Spiritual_benefits _92_Spiritual_benefits = new _92_Spiritual_benefits();
            _92_Spiritual_benefits.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _93_Place_of_happiness _93_Place_of_happiness = new _93_Place_of_happiness();
            _93_Place_of_happiness.Show();
            this.Hide();
        }
    }
}
