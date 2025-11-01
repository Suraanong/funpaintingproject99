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
    public partial class Impressionism_2_2 : Form
    {
        public Impressionism_2_2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Impressionism_2 Im_2 = new Impressionism_2();
            Im_2.Show();
            this.Hide();
        }
    }
}
