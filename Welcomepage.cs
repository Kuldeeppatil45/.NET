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
    public partial class Welcomepage : Form
    {
        int cnt = 0;
        public Welcomepage()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tomobilenumber t = new Tomobilenumber();
            t.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TobankUPIID b = new TobankUPIID();
            b.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Toselfaccount s = new Toselfaccount();
            s.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Checkbankbalance c = new Checkbankbalance();
            c.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Mobilerecharge m = new Mobilerecharge();
            m.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            DTH d = new DTH();
            d.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Electricity l = new Electricity();
            l.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            seemore s = new seemore();
            s.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (cnt%5)
            {
                case  0:
                    pictureBox18.Image = Image.FromFile("D:\\img\\1.jpg");
                    break;

                case 1:
                    pictureBox18.Image = Image.FromFile("D:\\img\\2.jpeg");
                    break;

                case 2:
                    pictureBox18.Image = Image.FromFile("D:\\img\\3.jpeg");
                    break;

                case 3:
                    pictureBox18.Image = Image.FromFile("D:\\img\\4.jpg");
                    break;

                case 4:
                    pictureBox18.Image = Image.FromFile("D:\\img\\5..jpg");
                    break;

                default:
                    break;
            }
            cnt++;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
