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
    public partial class _7_grief : Form
    {
        public _7_grief()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _7_2_grief _7_2_Grief = new _7_2_grief();
            _7_2_Grief.Show();
            this.Hide();
        }
    }
}
