using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EWALLET
{
    public partial class vouchar : Form
    {
        public vouchar()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            seemore s = new seemore();
            s.Show();
            this.Hide();
        }
    }
}
