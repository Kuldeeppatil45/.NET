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
    public partial class Tomobilenumber : Form
    {
        int bal = 0;
        public static string Email = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DOT.NET Practical\EWALLET.mdb");

        public Tomobilenumber()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Welcomepage w = new Welcomepage();
            w.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Some Data is Missing");
            }
            else
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
                if (bal < Convert.ToInt32(textBox2.Text))
                {
                    MessageBox.Show("Insuffient Balance");
                }
                else
                {


                    bal -= Convert.ToInt32(textBox2.Text);

                    // update bal
                    con.Open();
                    OleDbCommand cmd1 = new OleDbCommand();
                    cmd1.Connection = con;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "UPDATE EWALLET SET wbalance = '" + bal + "' WHERE Email = '" + login.Email + "' ";
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    OleDbCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "Insert into Transcation values('"
                                        + login.Email + "','"
                                        + comboBox1.Text + "','"
                                        + textBox1.Text + "','"
                                        + textBox2.Text + "')";
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Money Has Send Successfully");
                }
            }
        }
    }
}