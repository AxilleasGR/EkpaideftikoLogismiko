﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Timers;

namespace LogismikoMain
{
    public partial class DVO1 : UserControl
    {
        public System.Timers.Timer t;
        public int h, m, s;
        public int number ;
        public int cat;
        public int correct = 0;
        public int mistake = 0; 
        public static string time;        
        string answer;
        public string categ,usr=LoginForm.user;
        public bool back = false;
        public static bool completed1 = false;
        public static bool completed2 = false;
        public static bool completed3 = false;
        public static bool completed4 = false;
        int counter = 0;


        public DVO1()
        {
            InitializeComponent();            
        }
                        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DVO1_Load(object sender, EventArgs e)
        {
            //timer 
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;          
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        { //sets the timer
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                labelTimer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));  
        }
        //pressing start button selects questions
        private void buttonStartexc_Click(object sender, EventArgs e)
        {
            //gets questions etc from the database
            buttonA1.Enabled = true;
            buttonA2.Enabled = true;
            buttonA3.Enabled = true;
            buttonA4.Enabled = true;
            buttonSubmit.Enabled = true;
            t.Start();
            labelquestion.Text = ($"Question {number} :");                            
                var connString = "Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA";
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand($"SELECT question,a1,a2,a3,a4 FROM questions WHERE qid= {number}", conn))
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            labelQ.Text = reader["Question"].ToString();
                            labelA.Text = reader["a1"].ToString();
                            labelB.Text = reader["a2"].ToString();
                            labelC.Text = reader["a3"].ToString();
                            labelD.Text = reader["a4"].ToString();                       
                        
                        }
                }

            //every if for diff category
            if (cat == 1 && number > 7)
            {
                labelQ.Text = "You have finished all the questions, please choose another category";
                labelA.ResetText();
                labelB.ResetText();
                labelC.ResetText();
                labelD.ResetText();
                labelquestion.ResetText();
                Nextbutton.Visible = false;
                buttonSubmit.Visible = false;
                time = labelTimer.Text;
                categ = "Data types,Variables,Operators";
                t.Stop();
                completed1 = true;
            }
            else if (cat == 2 && number > 14)
            {
                labelQ.Text = "You have finished all the questions, please choose another category";
                labelA.ResetText();
                labelB.ResetText();
                labelC.ResetText();
                labelD.ResetText();
                labelquestion.ResetText();
                Nextbutton.Visible = false;
                buttonSubmit.Visible = false;
                time = labelTimer.Text;
                categ = "Looping Statements";
                t.Stop();
                completed2 = true;

            }
            else if (cat == 3 && number > 21)
            {
                labelQ.Text = "You have finished all the questions, please choose another category";
                labelA.ResetText();
                labelB.ResetText();
                labelC.ResetText();
                labelD.ResetText();
                labelquestion.ResetText();
                Nextbutton.Visible = false;
                buttonSubmit.Visible = false;
                time = labelTimer.Text;
                categ = "Classes";
                t.Stop();
                completed3 = true;
            }
            else if (cat == 4 && number > 28)
            {
                labelQ.Text = "You have finished all the questions, please choose another category";
                labelA.ResetText();
                labelB.ResetText();
                labelC.ResetText();
                labelD.ResetText();
                labelquestion.ResetText();
                Nextbutton.Visible = false;
                buttonSubmit.Visible = false;
                time = labelTimer.Text;
                categ = "Arrays and Strings";
                t.Stop();
                completed4 = true;
            }
            if (DVO1.completed1 == true || DVO1.completed2 == true || DVO1.completed3 == true || DVO1.completed4 == true)
            {
                double atime = RandomNumberBetween(2.56, 38.15);
                int cor = correct;
                int mis = mistake;

                NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA");
                conn.Open();
                try
                {
                    //create insert              
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO " + "stats(correct, mistake, qcategory, time, username) VALUES (:corr, :mis," + " :cat, :time, :user)", conn);
                    //add parameters                
                    cmd.Parameters.Add(new NpgsqlParameter("corr", NpgsqlTypes.NpgsqlDbType.Integer));
                    cmd.Parameters.Add(new NpgsqlParameter("mis", NpgsqlTypes.NpgsqlDbType.Integer));
                    cmd.Parameters.Add(new NpgsqlParameter("cat", NpgsqlTypes.NpgsqlDbType.Varchar));
                    cmd.Parameters.Add(new NpgsqlParameter("time", NpgsqlTypes.NpgsqlDbType.Real));
                    cmd.Parameters.Add(new NpgsqlParameter("user", NpgsqlTypes.NpgsqlDbType.Varchar));

                    cmd.Prepare();
                    //add values
                    cmd.Parameters[0].Value = cor;
                    cmd.Parameters[1].Value = mis;
                    cmd.Parameters[2].Value = categ;
                    cmd.Parameters[3].Value = atime;
                    cmd.Parameters[4].Value = usr;
                    Console.WriteLine(cor + " " + mis + " " + categ + " " + atime + " " + usr + " AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

                    //executesql
                    int recordAffected = cmd.ExecuteNonQuery();
                    if (Convert.ToBoolean(recordAffected))
                    {
                        MessageBox.Show("Database updated");
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                DVO1.completed1 = false;
                DVO1.completed2 = false;
                DVO1.completed3 = false;
                DVO1.completed4 = false;
            }
    }
        private static readonly Random random = new Random();
        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
        //next button
        private void Nextbutton_Click(object sender, EventArgs e)
        {           
            number++;
            labelQ.ResetText();
            labelA.ResetText();
            labelB.ResetText();
            labelC.ResetText();
            labelD.ResetText();
            DBcorrectanswer.ResetText();
            DBexplain.ResetText();
            buttonA2.Enabled = true;
            buttonA3.Enabled = true;
            buttonA4.Enabled = true;
            buttonA1.Enabled = true;
            labelquestion.ResetText();
            Nextbutton.Enabled = false;         
        }  
        //submit button
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var connString = "Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA";
            Nextbutton.Enabled = true;
            buttonSubmit.Enabled = false;
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT correct,explanation FROM questions WHERE  qid={number}", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        
                        DBcorrectanswer.Text = reader["correct"].ToString();
                        if (DBcorrectanswer.Text != answer)
                        {
                            DBexplain.Text = reader["explanation"].ToString();
                            mistake++;                            
                            labelmistakes.Text = $"you have {mistake} mistakes so far";
                           
                        }
                        else
                        {
                            correct++;
                            DBexplain.Text = "CORRECT!!!";                                                            
                        }                        
                   }
            }
            
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            answer = "a";
            buttonA2.Enabled = false;
            buttonA3.Enabled = false;
            buttonA4.Enabled = false;
            buttonSubmit.Enabled = true;
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            answer = "b";
            buttonA1.Enabled = false;
            buttonA3.Enabled = false;
            buttonA4.Enabled = false;
            buttonSubmit.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (IsOdd(counter))
            {
                panelTheory.Visible = true;
            }
            else
            {
                panelTheory.Visible = false;
            }
            var connString = "Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand($"SELECT theory FROM theory WHERE  cat={number}", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        textBox1.Text = reader["theory"].ToString();

                    }


            }
        }

        public static bool IsOdd(int counter)
        {
            return counter % 2 != 0;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelTheory_Paint(object sender, PaintEventArgs e)
        {
            panelTheory.Controls.Add(label1);
            panelTheory.Controls.Add(textBox1);
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            answer = "c";
            buttonA2.Enabled = false;
            buttonA1.Enabled = false;
            buttonA4.Enabled = false;
            buttonSubmit.Enabled = true;
        }

        private void buttonA4_Click(object sender, EventArgs e)
        {
            answer = "d";
            buttonA2.Enabled = false;
            buttonSubmit.Enabled = true;
            buttonA3.Enabled = false;
            buttonA1.Enabled = false;
        }
    }

}
