using System;
using System.Windows.Forms;
using Npgsql;

namespace LogismikoMain
{
    public partial class Acheivements : UserControl
    {
        public Acheivements()
        {
            InitializeComponent();
        }
        string user = LoginForm.user;
        string cat;
        string question;
        string answer;
        string category;


        private void label2_Click(object sender, EventArgs e)
        {

        }
        //selecting the question for main form
        private void buttonDVO_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            category = "DataVarOper";
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=axilleas1;Database=ekplog");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT question FROM public.final WHERE category='DataVarOper'" , conn);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    question = reader["question"].ToString();
                    labelQuestion.Text = question;
                }
            }
            conn.Close();  
        }
        //checking if user has all 7 correct in order to unlock the final question
        private void button1_Click(object sender, EventArgs e)
        {
            buttonCheck.Enabled = false;
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=axilleas1;Database=ekplog");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand($"SELECT qcategory FROM public.stats WHERE username = '{user}' AND correct =7 ", conn);
            using (var read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    cat = read["qcategory"].ToString();
                    if (cat == "Data types,Variables,Operators")
                    {
                        buttonDVO.Enabled = true;
                    }
                    else if (cat == "Classes")
                    {
                        buttonCla.Enabled = true;
                    }
                    else if (cat == "Looping Statements")
                    {
                        buttonLoop.Enabled = true;
                    }
                    else if (cat == "Arrays and Strings")
                    {
                        buttonAnS.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("You have not finished any categories yet!");
                    }

                }
                conn.Close();
            }
        }
        //selecting the question for ArrayStg category
        private void buttonAnS_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            category = "ArrayStg";
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=axilleas1;Database=ekplog");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT question FROM public.final WHERE category='ArrayStg'", conn);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    question = reader["question"].ToString();
                    labelQuestion.Text = question;
                }
            }
            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Controls.Add(buttonFALSE);
            panel1.Controls.Add(buttonTRUE);
            panel1.Controls.Add(labelQuestion);
            panel1.Controls.Add(buttonback);
        }
        //selecting the question for Classes category
        private void buttonCla_MouseClick(object sender, MouseEventArgs e)
        {
            category = "Classes";
            panel1.Visible = true;
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=axilleas1;Database=ekplog");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT question FROM public.final WHERE category='Classes'", conn);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    question = reader["question"].ToString();
                    labelQuestion.Text = question;
                }
            }
            conn.Close();
        }
        //selecting the question for Loops category
        private void buttonLoop_Click(object sender, EventArgs e)
        {
            category = "Loops";
            panel1.Visible = true;
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=axilleas1;Database=ekplog");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT question FROM public.final WHERE category='Loops'", conn);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    question = reader["question"].ToString();
                    labelQuestion.Text = question;
                }
            }
            conn.Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        //checks if answer is correct and unlocks prize for true
        private void buttonTRUE_Click(object sender, EventArgs e)
        {
            answer = "TRUE";
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=axilleas1;Database=ekplog");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT answer FROM public.final WHERE category='{category}'", conn);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var correctanswer = reader["answer"].ToString();
                    if (correctanswer == answer)
                    {
                        MessageBox.Show("Congratulations you have unlocked a new prize!!!!!");
                        if (category == "Loops")
                        {
                            pictureBoxLOO.Visible = true;
                            pictureBox3.Visible = false;
                        }
                        else if (category == "DataVarOper")
                        {
                            pictureBoxDVO.Visible = true;
                            pictureBox1.Visible = false;
                        }
                        else if (category == "Classes")
                        {
                            pictureBoxCLA.Visible = true;
                            pictureBox2.Visible = false;
                        }
                        else if (category == "ArrayStg")
                        {
                            pictureBoxANS.Visible = true;
                            pictureBox4.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                        labelQuestion.ResetText();
                        panel1.Visible = false;
                    }
                }
            }
            conn.Close();
        }               
        //checks if the answer is correct and unlocks prize for false
        private void buttonFALSE_Click(object sender, EventArgs e)
        {
            answer = "FALSE";
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=axilleas1;Database=ekplog");
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand($"SELECT answer FROM public.final WHERE category='{category}'", conn);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var correctanswer = reader["answer"].ToString();
                    if (correctanswer == answer)
                    {
                        MessageBox.Show("Congratulations you have unlocked a new prize!!!!!");
                        if (category == "Loops")
                        {
                            pictureBoxLOO.Visible = true;
                            pictureBox3.Visible = false;
                        }
                        else if (category == "DataVarOper")
                        {
                            pictureBoxDVO.Visible = true;
                            pictureBox1.Visible = false;
                        }
                        else if (category == "Classes")
                        {
                            pictureBoxCLA.Visible = true;
                            pictureBox2.Visible = false;
                        }
                        else if (category == "ArrayStg")
                        {
                            pictureBoxANS.Visible = true;
                            pictureBox4.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                        labelQuestion.ResetText();
                        panel1.Visible = false;
                    }
                }
            }
            conn.Close();
        }
    }
}
