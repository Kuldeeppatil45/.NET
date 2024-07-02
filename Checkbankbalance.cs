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
    public partial class Checkbankbalance : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DOT.NET Practical\EWALLET.mdb");
        public Checkbankbalance()
        {
            InitializeComponent();
        }

        private void Checkbankbalance_Load(object sender, EventArgs e)
        {
            con.Open();
            String query = "select * from EWALLET where Email = '"
                                + login.Email + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["wbalance"].ToString();
            }
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Welcomepage w = new Welcomepage();
            w.Show();
            this.Hide();
        }
    }
}
