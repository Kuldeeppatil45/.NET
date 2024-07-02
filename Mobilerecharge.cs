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
    public partial class Mobilerecharge : Form
    {
        int bal = 0;
        //public static string sname = "";
        public static string Email = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DOT.NET Practical\EWALLET.mdb");
        public Mobilerecharge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 10)
            {
                MessageBox.Show("Invalid Mobile Number");
            }
            else
            {


                if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
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
                                        + textBox1.Text + "','"
                                        + comboBox1.Text + "','"
                                        + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("1 record inserted");
                    pictureBox5.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    button3.Visible = false;
                    comboBox1.Visible = false;
                    label9.Text = textBox1.Text;
                    label10.Text = comboBox1.Text;
                    label12.Text = textBox3.Text;
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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "155";
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "299";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "329";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "459";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "699";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox3.Text = "999";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox3.Visible = true;
            pictureBox7.Visible = true;
            pictureBox6.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
        }

        private void Mobilerecharge_Load(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox3.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Welcomepage w = new Welcomepage();
            w.Show();
            this.Hide();
        }
        }

          }
