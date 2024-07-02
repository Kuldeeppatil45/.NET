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
    public partial class Form1 : Form
    {
        int tm = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tm++;
            if (tm == 5)
            {
                timer1.Enabled = false;
                timer1.Enabled = false;
                login l = new login();
                l.Show();
                this.Hide();
                
            }
        }
    }
}
