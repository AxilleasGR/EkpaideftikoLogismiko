using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Windows;
using System.Diagnostics.Eventing.Reader;

namespace LogismikoMain
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public bool connect = false;
        public static string user;
        public bool connectteach = false;
      
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        //checks if username and password matches the ones in DB
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var connString = "Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                NpgsqlTransaction tran = conn.BeginTransaction();
                NpgsqlCommand query = new NpgsqlCommand("Select * from users where username = '" + textboxName.Text.Trim() + "' and pwd = '" + textboxPsw.Text.Trim() + "' ", conn);
                NpgsqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows == true)
                    {
                        user = textboxName.Text.Trim();
                        this.Hide();
                        Form1 f = new Form1();
                        f.Show();
                        conn.Close();
                        connect = true;                       
                    }                    
                }
                if (connect == false)
                {
                    textboxName.ResetText();
                    textboxPsw.ResetText();
                    MessageBox.Show("WRONG USERNAME OR PASSWORD");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelnewaccount);
            panel1.Controls.Add(textNewpass);
            panel1.Controls.Add(textNewpass1);
            panel1.Controls.Add(textNewuser);
        }
        //for sign up
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textNewpass.ResetText();
            textNewpass1.ResetText();
            textNewuser.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks if username exists it must NOT exist to be able to sign up
            var connString = "Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string pass = textNewpass.Text.Trim();
                string usern = textNewuser.Text.Trim();
                bool userexists = false;                                              
                 NpgsqlCommand query = new NpgsqlCommand("Select username from users where username = '" + textNewuser.Text.Trim() + "' ", conn);
                 NpgsqlDataReader reader = query.ExecuteReader();                
                 while (reader.Read())
                 {
                    string name = reader["username"].ToString();
                    if (textNewuser.Text == name)
                    {
                        MessageBox.Show("Username already exists, please choose another. ");
                        textNewuser.ResetText();
                        conn.Close();
                        userexists = true;
                    }
                }
                conn.Close();
                //if not continue the process  
                var length = textNewpass.Text.Length;
                bool passok = true;
                if (textNewpass.Text != textNewpass1.Text)
                {
                    MessageBox.Show("passwords dont match");
                    passok = false;
                }
                if (length <= 4)
                {
                    MessageBox.Show("use longer password");
                    passok = false;
                }
                if (userexists == false && textNewpass.TextLength != 0 && passok )
                {
                    conn.Open();

                    try
                    {
                        NpgsqlCommand command = new NpgsqlCommand("INSERT INTO " + "users(username, pwd) VALUES (:usr ,:pwd)", conn);
                        //add parameter
                        command.Parameters.Add(new NpgsqlParameter("usr", NpgsqlTypes.NpgsqlDbType.Varchar));
                        command.Parameters.Add(new NpgsqlParameter("pwd", NpgsqlTypes.NpgsqlDbType.Varchar));
                        //prepare
                        command.Prepare();
                        //add value to param
                        command.Parameters[0].Value = usern;
                        command.Parameters[1].Value = pass;
                        //ecxecutesql
                        int recordAffected = command.ExecuteNonQuery();
                        if (Convert.ToBoolean(recordAffected))
                        {
                            MessageBox.Show("Data Successfully saved, Please log in now");
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show(ex.ToString());     
                    }
                    conn.Close();
                    panel1.Visible = false;
                }                
            }    
            //checks for password
           
        }

        private void buttonTEACHER_Click(object sender, EventArgs e)
        {
            panelTeacher.Visible = true;

        }
        //teacher log in 
        private void buttonTeacherLogIN_Click(object sender, EventArgs e)
        {
           
            var connString = "Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                NpgsqlTransaction tran = conn.BeginTransaction();
                NpgsqlCommand query = new NpgsqlCommand("Select * from teachers where username = '" + textBox1.Text.Trim() + "' and pwd = '" + textBox2.Text.Trim() + "' ", conn);
                NpgsqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows == true)
                    {
                        this.Hide();
                        Teachers t = new Teachers();
                        t.Show();
                        conn.Close();
                        connectteach = true;
                    }
                }
                if (connectteach == false)
                {
                    MessageBox.Show("incorrect username or password");
                    textBox1.ResetText();
                    textBox2.ResetText();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            panelTeacher.Visible = false;
        }

        private void panelTeacher_Paint(object sender, PaintEventArgs e)
        {
            panelTeacher.Controls.Add(label5);
            panelTeacher.Controls.Add(label4);
            panelTeacher.Controls.Add(textBox1);
            panelTeacher.Controls.Add(textBox2);
            panelTeacher.Controls.Add(buttonTeacherLogIN);
            panelTeacher.Controls.Add(button2);
        }
    }
}
