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
    public partial class ForgetPasswardpage : Form
    {
        public String ans = "", pass = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DOT.NET Practical\EWALLET.mdb");
        public ForgetPasswardpage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPasswardpage_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "select * from EWALLET where Email = '"
                                + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ans = dr["SecAns"].ToString();
                pass = dr["Passward"].ToString();
                label3.Text = dr["SecQue"].ToString();
            }
            else
            {
                textBox1.Text = "";
                textBox4.Text = "";
                MessageBox.Show("No Account Found !");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (ans == textBox4.Text)
                {
                    MessageBox.Show("Your password is : " + pass);
                }
                else
                {
                    MessageBox.Show("Wrong Answer");
                    textBox4.Text = "";
                }
            }
            else
            {
                if (ans == textBox4.Text)
                {
                    label7.Visible = true;
                    label8.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    button4.Visible = true;
                    pictureBox3.Visible = false;
                }
                else
                {
                    MessageBox.Show("Wrong Ans");
                    textBox4.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update EWALLET set Passward = '"
                                + textBox5.Text + "' where Email = '"
                                + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Password updated, Pls Login again.");
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
