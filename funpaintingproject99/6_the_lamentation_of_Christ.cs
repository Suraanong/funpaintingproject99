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
    public partial class _6_the_lamentation_of_Christ : Form
    {
        public _6_the_lamentation_of_Christ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _7_grief grief = new _7_grief();
            grief.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medievalera medievalera = new medievalera();
            medievalera.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _8_tragedy tragedy = new _8_tragedy();
            tragedy.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _9_senseofmovement senseofmovement = new _9_senseofmovement();
            senseofmovement.Show();
            this.Hide();
        }

        private void _6_the_lamentation_of_Christ_Load(object sender, EventArgs e)
        {

        }
    }
}
