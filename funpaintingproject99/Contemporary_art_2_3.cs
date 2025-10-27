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
    public partial class Contemporary_art_2_3 : Form
    {
        public Contemporary_art_2_3()
        {
            InitializeComponent();
        }

        private void Contemporary_art_2_3_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contemporary_art_2 Con_2 = new Contemporary_art_2();
            Con_2.Show();
            this.Hide();
        }
    }
}
