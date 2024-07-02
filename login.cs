using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;

namespace EWALLET
{
    public partial class login : Form
    {
        public static string sname = "";
        String otp1="ABCD";

        public static string Email = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DOT.NET Practical\EWALLET.mdb");
        public login()
        {
            InitializeComponent();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            loginpage l = new loginpage();
            l.Show();
            this.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            ForgetPasswardpage f = new ForgetPasswardpage();
            f.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {


 
                con.Open();
                String query = "select * from EWALLET where UserID = '"
                                    + textBox1.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Passward"].ToString() == textBox2.Text)
                    {
                        sname = dr["sName"].ToString();
                        Email = dr["Email"].ToString();
                        //Email = dr["sName"].ToString();
                        Welcomepage w = new Welcomepage();
                        w.Show();
                        this.Hide();
                        MessageBox.Show("Welcome " + sname + " !");
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                        textBox2.Text = "";
                    }
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("No Account Found!");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Invaild Captcha");
            }
        }
        public void genCaptcha(int l)
        { 

        }

        private void login_Load(object sender, EventArgs e)
        {
            // generate ccapcha
            otp1 = RandomString(6);

            textBox3.Text = otp1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            otp1 = RandomString(6);

            textBox3.Text = otp1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "select * from EWALLET where UserID = '"
                                + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Passward"].ToString() == textBox2.Text)
                {
                    sname = dr["sName"].ToString();
                    Email = dr["Email"].ToString();
                    //

                    //send otp
                    //generate otp
                    otp1 = RandomString(6);

                    //send otp
                    // send otp to mail
                    MailMessage mail = new MailMessage();
                    mail.To.Add(Email); 
                  
                    mail.From = new MailAddress("Email");
                    mail.Subject = "OPT - Secure Login System!";
                    string Body = "Your OTP is : " + otp1 + "\nDo not Share with Other!";
                    mail.Body = Body;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("Your email", "Your email password");

                    //Or your Smtp Email ID and Password
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    MessageBox.Show("OTP sent : to " + Email);

                    // 
                    //Email = dr["sName"].ToString();
                    //Welcomepage w = new Welcomepage();
                    //w.Show();
                    //this.Hide();
                    //MessageBox.Show("Welcome " + sname + " !");
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    textBox2.Text = "";
                }
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("No Account Found!");
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (otp1 == textBox10.Text)
            {
                MessageBox.Show("OTP match");
                pictureBox5.Visible = true;
            }
            else
            {
                MessageBox.Show("OTP not match");
            }

        }
    }
}
