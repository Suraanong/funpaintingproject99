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
    public partial class Contemporary_art_3_1 : Form
    {
        public Contemporary_art_3_1()
        {
            InitializeComponent();
        }

        private void Contemporary_art_3_1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contemporary_art_3 Con_3 = new Contemporary_art_3();
            Con_3.Show();
            this.Hide();
        }
    }
}
