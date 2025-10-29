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
    public partial class _1homage : Form
    {
        public _1homage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            justinian justinian = new justinian();
            justinian.Show();
            this.Hide();
        }

        private void _1homage_Load(object sender, EventArgs e)
        {

        }
    }
}
