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
    public partial class loginpage : Form
    {
        String otp1;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\DOT.NET Practical\EWALLET.mdb");
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox4;
        private Label label13;
        private TextBox textBox5;
        private Label label14;
        private TextBox textBox6;
        private Button button1;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox textBox10;
        private Button button2;
        private ComboBox comboBox6;
        private Label label21;
        private TextBox textBox11;
        private TextBox textBox14;
        private TextBox textBox15;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;


        



        public loginpage()
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mr",
            "Ms",
            "Master"});
            this.comboBox1.Location = new System.Drawing.Point(78, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(136, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(264, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(421, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(698, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 568);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(264, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(233, 207);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 28);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.White;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(309, 207);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 28);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.White;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(407, 207);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 28);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Others";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "State";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(417, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "District";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(556, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(136, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Pincode";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(264, 317);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 29);
            this.textBox4.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(132, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "Contact no";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(264, 363);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 29);
            this.textBox5.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(136, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "Email";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(136, 453);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 29);
            this.textBox6.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(398, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Send OTP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(724, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 24);
            this.label15.TabIndex = 31;
            this.label15.Text = "User ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(724, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 24);
            this.label16.TabIndex = 32;
            this.label16.Text = "Password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(724, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 24);
            this.label17.TabIndex = 33;
            this.label17.Text = "Confirm Password";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(913, 124);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 29);
            this.textBox7.TabIndex = 34;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(913, 186);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(212, 29);
            this.textBox8.TabIndex = 35;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(913, 241);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(212, 29);
            this.textBox9.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(161, 668);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "<<< Back To Login";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(727, 302);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 24);
            this.label19.TabIndex = 38;
            this.label19.Text = "Security Question";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(132, 502);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 24);
            this.label20.TabIndex = 41;
            this.label20.Text = "Enter OTP";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(136, 541);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(136, 29);
            this.textBox10.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(284, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 43;
            this.button2.Text = "Verify";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "What is your favorite color ?",
            "What is your favorite car ?",
            "What is your favorite food ?",
            "What is your favorite bike ?",
            "What is your favorite game ?"});
            this.comboBox6.Location = new System.Drawing.Point(913, 299);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(221, 32);
            this.comboBox6.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(727, 368);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 24);
            this.label21.TabIndex = 45;
            this.label21.Text = "Answer";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(913, 363);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(121, 29);
            this.textBox11.TabIndex = 46;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(421, 271);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(115, 29);
            this.textBox14.TabIndex = 49;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(560, 270);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(115, 29);
            this.textBox15.TabIndex = 50;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 270);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 32);
            this.comboBox2.TabIndex = 52;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(284, 270);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 32);
            this.comboBox3.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1355, 735);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(894, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // loginpage
            // 
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.loginpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void loginpage_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("India");//country
            comboBox2.Items.Add("America");//country
            comboBox2.Items.Add("Australia");//country
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0://India
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("Maharashtra");//state
                    comboBox3.Items.Add("Gujarat");//state
                    comboBox3.Items.Add("Punjab");//state
                    break;
                case 1://america
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("New York");//state
                    comboBox3.Items.Add("California");//state
                    comboBox3.Items.Add("Washington");//state
                    break;
                case 2://aus
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("Queensland");//state
                    comboBox3.Items.Add("Victoria");//state
                    comboBox3.Items.Add("Western Australia");//state
                    break;
                default:
                    break;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    OleDbCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "Insert into EWALLET values('"
        //                        + textBox1.Text + "','"
        //                        + textBox2.Text + "','"
        //                        + textBox3.Text + "','"
        //                        + comboBox2.Text + "','"
        //                        + comboBox3.Text + "','"
        //                        + textBox14.Text + "','"
        //                        + textBox15.Text + "','"
        //                        + textBox4.Text + "','"
        //                        + textBox5.Text + "','"
        //                        + textBox6.Text + "','"
        //                        + textBox1.Text + "@" + dateTimePicker1.Value.Year.ToString() + "','"
        //                        + textBox8.Text + "','"
        //                        + comboBox6.Text + "','"
        //                        +textBox11.Text + "','100')";
            
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show("Account Created Successfully!");
        //}

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = dateTimePicker1.CustomFormat.ToString;
            //dateTimePicker1.CustomFormat = "yyyy";
            //dateTimePicker1.ShowUpDown = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox7.Text = textBox1.Text + "@" + dateTimePicker1.Value.Year.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into EWALLET values('"
                                + textBox1.Text + "','"
                                + textBox2.Text + "','"
                                + textBox3.Text + "','"
                                + comboBox2.Text + "','"
                                + comboBox3.Text + "','"
                                + textBox14.Text + "','"
                                + textBox15.Text + "','"
                                + textBox4.Text + "','"
                                + textBox5.Text + "','"
                                + textBox6.Text + "','"
                                + textBox1.Text + "@" + dateTimePicker1.Value.Year.ToString() + "','"
                                + textBox8.Text + "','"
                                + comboBox6.Text + "','"
                                + textBox11.Text + "','100')";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account Created Successfully!");
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //generate otp
            otp1 = RandomString(6);

            //send otp
            // send otp to mail
            MailMessage mail = new MailMessage();
            mail.To.Add(textBox6.Text); // use ur email id for demo
            // mail.CC.Add("pranavwankhede5@gmail.com");
            mail.CC.Add("gaikwadprasad2209@gmail.com");

            mail.From = new MailAddress("ewalletproject45@gmail.com");
            mail.Subject = "OPT - Secure Login System!";
            string Body = "Your OTP is : " + otp1 + "\nDo not Share with Other!";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("ewalletproject45@gmail.com", "qlfbaskzyefylyxj");

            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            smtp.Send(mail);

            MessageBox.Show("OTP sent :" + otp1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (otp1==textBox10.Text)
            {
                MessageBox.Show("OTP match");
                pictureBox2.Visible = true;
            }
            else
            {
                MessageBox.Show("OTP not match");
            }
        }

        

        
    }
}
//private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
//{
//    switch (comboBox2.SelectedIndex) // country india
//    {
//        case 0: // india
//            switch (comboBox3.SelectedIndex) // country
//            {
//                case 0: // maha
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Thane");//dist
//                    comboBox4.Items.Add("Pune");
//                    comboBox4.Items.Add("Mumbai");
//                    break;
//                case 1://guj
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Ahmedabad");
//                    comboBox4.Items.Add("Bharuch");
//                    comboBox4.Items.Add("Surat");
//                    break;
//                case 2://panj
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Amritsar");
//                    comboBox4.Items.Add("Ludhiana");
//                    comboBox4.Items.Add("Jalandhar");
//                    break;
//                default:
//                    break;
//            }
//            break;
//        case 1://america
//            switch (comboBox3.SelectedIndex) // country america
//            {
//                case 0: // new york
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Bronx");//dist
//                    comboBox4.Items.Add("Brooklyn");
//                    comboBox4.Items.Add("Manhattan");
//                    break;
//                case 1://california
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Alpine");
//                    comboBox4.Items.Add("Fresno");
//                    comboBox4.Items.Add("Plumas");
//                    break;
//                case 2://Washigton
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Medina");
//                    comboBox4.Items.Add("Everett");
//                    comboBox4.Items.Add("Washougal");
//                    break;

//                default:
//                    break;
//            }
//            break;
//        case 2://aus
//            switch (comboBox3.SelectedIndex) // country Austrilia
//            {
//                case 0: //Queensland 
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Brisbane");//dist
//                    comboBox4.Items.Add("Gold Coast");
//                    comboBox4.Items.Add("North Queensland");
//                    break;
//                case 1://Victoria
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Albert Park");//dist
//                    comboBox4.Items.Add("Bellarine");
//                    comboBox4.Items.Add("Melbourne");
//                    break;
//                case 2://Western Australia
//                    comboBox4.Items.Clear();
//                    comboBox4.Items.Add("Albany");//dist
//                    comboBox4.Items.Add("Ashburton");
//                    comboBox4.Items.Add("Beverley");
//                    break;

//                default:
//                    break;
//            }

//            break;

//        default:
//            break;
//    }
//}

//        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)//dist box selected
//        {
//            switch (comboBox2.SelectedIndex) // country india
//            {
//                case 0: // india
//                    switch (comboBox3.SelectedIndex) // country
//                    {
//                        case 0: // maha

//                            //comboBox4.Items.Clear();
//                            //comboBox4.Items.Add("Thane");//dist
//                            //comboBox4.Items.Add("Pune");
//                            //comboBox4.Items.Add("Mumbai");
//                            switch (comboBox4.SelectedIndex)//city name
//                            {
//                                case 0://thane
//                                    comboBox5.Items.Clear();
//                                    comboBox5.Items.Add("Badlapur");
//                                    comboBox5.Items.Add("Ambernath");
//                                    comboBox5.Items.Add("Kalyan");
//                                    break;
//                                case 1://pune
//                                    comboBox5.Items.Clear();
//                                    comboBox5.Items.Add("Hadapsar");
//                                    comboBox5.Items.Add("Shivajinagar");
//                                    comboBox5.Items.Add("Fursungi");
//                                    break;
//                                case 2://mumbai
//                                    comboBox5.Items.Clear();
//                                    comboBox5.Items.Add("Andheri");
//                                    comboBox5.Items.Add("Bandra");
//                                    comboBox5.Items.Add("Goregaon");
//                                    break;
//                                default:
//                                    break;
//                            }
//                            break;
//                            }

//                        case 1://guj
//                            //comboBox4.Items.Clear();
//                            //comboBox4.Items.Add("Ahmedabad");
//                            //comboBox4.Items.Add("Bharuch");
//                            //comboBox4.Items.Add("Surat");
//                            switch (comboBox4.SelectedIndex)//city name 
//                            {
//                                case 0://Ahmedabad
//                                    comboBox5.Items.Clear();
//                                    comboBox5.Items.Add("Khadia");
//                                    comboBox5.Items.Add("Lal Darwaja");
//                                    comboBox5.Items.Add("Manek Chowk");
//                                    break;
//                                case 1://Bharuch
//                                    comboBox5.Items.Clear();
//                                    comboBox5.Items.Add("Amdada");
//                                    comboBox5.Items.Add("Navetha");
//                                    comboBox5.Items.Add("Paguthan");
//                                    break;
//                                case 2://Surat
//                                    comboBox5.Items.Clear();
//                                    comboBox5.Items.Add("Kadod");
//                                    comboBox5.Items.Add("Karchelia");
//                                    comboBox5.Items.Add("Kosamba");
//                                    break;
//                                default:
//                                    break;
//                            }
//                                case 2://panj
//                                    //comboBox4.Items.Clear();
//                                    //comboBox4.Items.Add("Amritsar");
//                                    //comboBox4.Items.Add("Ludhiana");
//                                    //comboBox4.Items.Add("Jalandhar");
//                                    switch (comboBox4.SelectedIndex)//city name 
//                                    {
//                                        case 0://Amritsar
//                                            comboBox5.Items.Clear();
//                                            comboBox5.Items.Add("Attari");//city
//                                            comboBox5.Items.Add("Bhagtupura");
//                                            comboBox5.Items.Add("Jhanjarpur");
//                                            break;
//                                        case 1://Ludhiana
//                                            comboBox5.Items.Clear();
//                                            comboBox5.Items.Add("Dehlon");
//                                            comboBox5.Items.Add("Mullanpur Dakha");
//                                            comboBox5.Items.Add("Sidhwan Bet");
//                                            break;
//                                        case 2://Jalandhar
//                                            comboBox5.Items.Clear();
//                                            comboBox5.Items.Add("Bhogpur");
//                                            comboBox5.Items.Add("Kartarpur");
//                                            comboBox5.Items.Add("Talwan");
//                                            break;
//                                        default:
//                                            break;
//                                    }

//                                    break;
//                            }
//        }
//                        case 1://america
//                            switch (comboBox3.SelectedIndex)// country america
//                            {
//                                case 0: // new york
//                                    //comboBox4.Items.Clear();
//                                    //comboBox4.Items.Add("Bronx");//dist
//                                    //comboBox4.Items.Add("Brooklyn");
//                                    //comboBox4.Items.Add("Manhattan");
//                                    switch (comboBox4.SelectedIndex)//city name
//                                    {
//                                        case 0://Bronx
//                                            comboBox5.Items.Clear();
//                                            comboBox5.Items.Add("Allerton");//city
//                                            comboBox5.Items.Add("Baychester");
//                                            comboBox5.Items.Add("Eastchester");
//                                            break;
//                                        case 1://Brooklyn
//                                            comboBox5.Items.Clear();
//                                            comboBox5.Items.Add("Brownsville");//city
//                                            comboBox5.Items.Add("Carroll Gardens");
//                                            comboBox5.Items.Add("Clinton Hill");
//                                            break;
//                                        case 2://Manhattan
//                                            comboBox5.Items.Clear();
//                                            comboBox5.Items.Add("Greenwich Village");//city
//                                            comboBox5.Items.Add("NoHo");
//                                            comboBox5.Items.Add("Bowery");
//                                            break;
//                                        default:
//                                            break;
//                                    }
//                                    break;
//                                case 1://california
//                                    //comboBox4.Items.Clear();
//                                    //comboBox4.Items.Add("Alpine");
//                                    //comboBox4.Items.Add("Fresno");
//                                    //comboBox4.Items.Add("Plumas");
//                                    switch (comboBox4.SelectedIndex)
//                                    {
//                                      case 0://Alpine
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Grenoble");//city
//                                        comboBox4.Items.Add("France");
//                                        comboBox4.Items.Add("Austria ");
//                                        break;
//                                      case 1://Fresno
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Burrel");//city
//                                        comboBox4.Items.Add("Auberry");
//                                        comboBox4.Items.Add("Clovis");
//                                        break;
//                                      case 3://Plumas
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Chester");//city
//                                        comboBox4.Items.Add("Blairsden");
//                                        comboBox4.Items.Add("Beckwourth");
//                                        break;
//                                        default:
//                                        break;
//                                    }
//                                    break;
//                                case 2://Washigton
//                                    //comboBox4.Items.Clear();
//                                    //comboBox4.Items.Add("Medina");
//                                    //comboBox4.Items.Add("Everett");
//                                    //comboBox4.Items.Add("Washougal");
//                                    switch (comboBox4.SelectedIndex)
//                                    {
//                                      case 0://Medina
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Brunswick");//city
//                                        comboBox4.Items.Add("Hinckley");
//                                        comboBox4.Items.Add("Lodi");
//                                        break;
//                                      case 1://Everett
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Missouri");//city
//                                        comboBox4.Items.Add("Nebraska");
//                                        comboBox4.Items.Add("New Jersey");
//                                        break;
//                                      case 3://Washougal
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Seattle");//city
//                                        comboBox4.Items.Add("Tacoma");
//                                        comboBox4.Items.Add("Kent");
//                                        break;
//                                        default:
//                                        break;
//                                    }
//                                default:
//                                    break;
//                            }

//                        case 2://aus
//                            switch (comboBox3.SelectedIndex) // country Austrilia
//                            {
//                                case 0: //Queensland 
//                                    //comboBox4.Items.Clear();
//                                    //comboBox4.Items.Add("Brisbane");//dist
//                                    //comboBox4.Items.Add("Gold Coast");
//                                    //comboBox4.Items.Add("North Queensland");
//                                    //break;
//                            switch (comboBox4.SelectedIndex)//city name
//                                    {
//                                      case 0://Brisbane
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Logan");//city
//                                        comboBox4.Items.Add("Moreton");
//                                        comboBox4.Items.Add("Redland");
//                                        break;
//                                      case 1://Gold Coast
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Robina");//city
//                                        comboBox4.Items.Add("Southport");
//                                        comboBox4.Items.Add("Surfers Paradise");
//                                        break;
//                                      case 2://North Queensland
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Cairns");//city
//                                        comboBox4.Items.Add("Cardwell");
//                                        comboBox4.Items.Add("Karumba");
//                                        break;
//                                        default:
//                                        break;
//                                    }
//                                case 1://Victoria
//                                    //comboBox4.Items.Clear();
//                                    //comboBox4.Items.Add("Albert Park");
//                                    //comboBox4.Items.Add("Bellarine");
//                                    //comboBox4.Items.Add("Melbourne");
//                                    //break;
//                            switch (comboBox4.SelectedIndex)//city name
//                                    {
//                                      case 0://Albert Park
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Southbank");//city
//                                        comboBox4.Items.Add("South Yarra");
//                                        comboBox4.Items.Add("Docklands");
//                                        break;
//                                      case 1://Bellarine
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Curlewis");//city
//                                        comboBox4.Items.Add("Leopold");
//                                        comboBox4.Items.Add("Mannerim");
//                                        break;
//                                      case 2://Melbourne
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Jolimont");//city
//                                        comboBox4.Items.Add("Ascot Vale");
//                                        comboBox4.Items.Add("Carlton North");
//                                        break;
//                                        default:
//                                        break;
//                                    }
//                                case 2://Western Australia
//                                    //comboBox4.Items.Clear();
//                                    //comboBox4.Items.Add("Albany");
//                                    //comboBox4.Items.Add("Ashburton");
//                                    //comboBox4.Items.Add("Beverley");
//                                    //break;
//                            switch (comboBox4.SelectedIndex)//city name
//                                    {
//                                      case 0://Albany
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Torbay");//city
//                                        comboBox4.Items.Add("Denmark");
//                                        comboBox4.Items.Add("Nornalup");
//                                        break;
//                                      case 1://Ashburton
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Ashwood");//city
//                                        comboBox4.Items.Add("Burwood");
//                                        comboBox4.Items.Add("Chadstone");
//                                        break;
//                                      case 2://Beverley
//                                        comboBox4.Items.Clear();
//                                        comboBox4.Items.Add("Beverley");//city
//                                        comboBox4.Items.Add("Dale Bridge");
//                                        comboBox4.Items.Add("Morbinning");
//                                        break;
//                                        default:
//                                        break;
//                                    }

//                                default:
//                                    break;
//                            }
//}
//                        //    break;
//                        //default:
//                        //    break;
//                    }
//            }
//        }
//}
//}
////---------------------------------------------------------------------
//private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
//{
//    switch (comboBox3.SelectedIndex)
//    {
//        case 0:
//            comboBox4.Items.Clear();
//            comboBox4.Items.Add("Thane");
//            comboBox4.Items.Add("Ratnagiri");
//            comboBox4.Items.Add("Nagpur");
//            comboBox4.Items.Add("Nashik");
//            comboBox4.Items.Add("Pune");
//            break;

//        case 1:
//            comboBox4.Items.Clear();
//            comboBox4.Items.Add("Srikulam");
//            comboBox4.Items.Add("Vizianagaram");
//            comboBox4.Items.Add("Visakhapatnam");
//            comboBox4.Items.Add("Parvathipuram");
//            comboBox4.Items.Add("Tirupati");
//            break;

//        case 2:
//            comboBox4.Items.Clear();
//            comboBox4.Items.Add("Chennai");
//            comboBox4.Items.Add("Dharmapuri");
//            comboBox4.Items.Add("Chengalpattu");
//            comboBox4.Items.Add("Coimbatore");
//            comboBox4.Items.Add("Ariyalur");
//            break;

//        case 3:
//            comboBox4.Items.Clear();
//            comboBox4.Items.Add("Hardoi");
//            comboBox4.Items.Add("Lakhimpur Kheri");
//            comboBox4.Items.Add("Lucknow");
//            comboBox4.Items.Add("Sitapur");
//            comboBox4.Items.Add("Raebareli");
//            break;

//        case 4:
//            comboBox4.Items.Clear();
//            comboBox4.Items.Add("Alipurduar");
//            comboBox4.Items.Add("Kolkata");
//            comboBox4.Items.Add("Bankura");
//            comboBox4.Items.Add("Cooch Behar");
//            comboBox4.Items.Add("Darjeeling");
//            break;
//        default:
//            break;
//    }
//}

//private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
//{
//    switch (comboBox2.SelectedIndex)
//    {
//        case 0:
//            comboBox3.Items.Clear();
//            comboBox3.Items.Add("Maharahtra");
//            comboBox3.Items.Add("Andhra Pradesh");
//            comboBox3.Items.Add("Tamil Nadu");
//            comboBox3.Items.Add("Uttar Pradesh");
//            comboBox3.Items.Add("West Bengal");
//            break;

//        case 1:
//            comboBox3.Items.Clear();
//            comboBox3.Items.Add("New York");
//            comboBox3.Items.Add("California");
//            comboBox3.Items.Add("Illinois");
//            comboBox3.Items.Add("Texas");
//            comboBox3.Items.Add("Arizona");
//            break;

//        case 2:
//            comboBox3.Items.Clear();
//            comboBox3.Items.Add("Sydney");
//            comboBox3.Items.Add("Melbourne");
//            comboBox3.Items.Add("Brisbane");
//            comboBox3.Items.Add("Perth");
//            comboBox3.Items.Add("Adelaide");
//            break;

//        case 3:
//            comboBox3.Items.Clear();
//            comboBox3.Items.Add("Balochistan");
//            comboBox3.Items.Add("Gilgit-Baltistan");
//            comboBox3.Items.Add("Punjab");
//            comboBox3.Items.Add("Sindh");
//            comboBox3.Items.Add("Khyber Pakhtunkhwa");
//            break;

//        case 4:
//            comboBox3.Items.Clear();
//            comboBox3.Items.Add("Auckland");
//            comboBox3.Items.Add("Marlborough");
//            comboBox3.Items.Add("Northland");
//            comboBox3.Items.Add("West Coast");
//            comboBox3.Items.Add("Taranaki");
//            break;

//        case 5:
//            comboBox3.Items.Clear();
//            comboBox3.Items.Add("Aichi");
//            comboBox3.Items.Add("Ehime");
//            comboBox3.Items.Add("Fukushima");
//            comboBox3.Items.Add("Kyoto");
//            comboBox3.Items.Add("Tokyo");
//            break;
//        default:
//            break;
//    }
//}
