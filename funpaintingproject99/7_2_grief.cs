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
    public partial class _7_2_grief : Form
    {
        public _7_2_grief()
        {
            InitializeComponent();
        }

        private void _7_2_grief_Load(object sender, EventArgs e)
        {

        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _7_3_grief _7_3_Grief = new _7_3_grief();
            _7_3_Grief.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _7_grief _7_Grief = new _7_grief();
            _7_Grief.Show();
            this.Hide();
        }
    }
}
