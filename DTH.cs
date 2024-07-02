using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EWALLET
{
    public partial class DTH : Form
    {
        int bal = 0;
        public static string Email = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DOT.NET Practical\EWALLET.mdb");
      
        public DTH()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Welcomepage w = new Welcomepage();
            w.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 10)
            {
                MessageBox.Show("Invalid Mobile Number");
            }
            else
            {
                if (textBox2.Text == "" || textBox1.Text == "" || comboBox1.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Some Data is Missing");
                }
                else
                {


                    pictureBox4.Location = new Point(150, 147);
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Transcation values('"
                                        + login.Email + "','"
                        // + textBox2.Text + "','"
                                        + comboBox1.Text + "','"
                                        + textBox1.Text + "','"
                                        + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("1 record inserted");
                    pictureBox2.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    button3.Visible = false;
                    label9.Text = textBox2.Text;
                    label10.Text = comboBox1.Text;
                    label12.Text = textBox1.Text;
                    label13.Text = textBox3.Text;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // fetch current bal
            con.Open();
            String query = "select * from EWALLET where Email = '"
                                + login.Email + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                bal = Convert.ToInt32(dr["wbalance"].ToString());

            }

            con.Close();
            // add operation
            if (bal < Convert.ToInt32(textBox3.Text))
            {
                MessageBox.Show("Insuffient Balance");
            }
            else
            {
                bal -= Convert.ToInt32(textBox3.Text);

                // update bal
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = con;
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "UPDATE EWALLET SET wbalance = '" + bal + "' WHERE Email = '" + login.Email + "' ";
                cmd1.ExecuteNonQuery();
                con.Close();

                pictureBox4.Location = new Point(700, 147);
                RechargeMessage r = new RechargeMessage();
                r.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "247";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "208";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "25";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "145";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "175";
        }

        private void DTH_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox6.Visible = true;
            pictureBox5.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
        }
    }
}
