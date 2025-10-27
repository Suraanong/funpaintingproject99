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
    public partial class Contemporary_art_1_3 : Form
    {
        public Contemporary_art_1_3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contemporary_art_1 Con_1 = new Contemporary_art_1();
            Con_1.Show();
            this.Hide();
        }
    }
}
