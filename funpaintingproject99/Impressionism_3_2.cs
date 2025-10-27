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
    public partial class Impressionism_3_2 : Form
    {
        public Impressionism_3_2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Impressionism_3 Im_3 = new Impressionism_3();
            Im_3.Show();
            this.Hide();
        }
    }
}
