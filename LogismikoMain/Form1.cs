using EkpaideftikoLogismiko.Properties;
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
using LogismikoMain;

namespace LogismikoMain
{
    public partial class Form1 : Form
    {
        private bool isColapsed;
        public static int Visitcat1 = 0;
        public static int Visitcat2 = 0;
        public static int Visitcat3 = 0;
        public static int Visitcat4 = 0;       
        public string categ;     
       

        string usr = LoginForm.user;

        public Form1()
        {
            InitializeComponent();
            labelusername.Text = $"Welcome {LoginForm.user} !";
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        { //drop down menu
            if (isColapsed)
            {
                MenuButton.Image = Resources.Webp_net_resizeimage___Αντιγραφή;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timerMenu.Stop();
                    isColapsed = false;
                }
            }
            else
            {
                MenuButton.Image = Resources.Webp_net_resizeimage;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timerMenu.Stop();
                    isColapsed = true;
                }

            }
        }
       

        private void MenuButton_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acheivements1.Visible = false;
            stats1.Visible = false;
            dvO11.Visible = false;
        }

        private void panelstart_Paint(object sender, PaintEventArgs e)
        {
            panelstart.Controls.Add(labelcat);
            panelstart.Controls.Add(buttonARS);
            panelstart.Controls.Add(buttonCla);
            panelstart.Controls.Add(buttonDVO);
            panelstart.Controls.Add(buttonLoo);

        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            panelstart.Visible = true;
            help1.Visible = false;
            help1.Enabled = false;
            stats1.Visible = false;
            stats1.Enabled = false;
            acheivements1.Enabled = false;
            acheivements1.Visible = false;
        }
        //opens DVO.cs for the questions according to button pressed
        private void buttonDVO_MouseClick(object sender, MouseEventArgs e)
        {
            dvO11.Visible = true;
            stats1.Visible = false;
            labelcategory.Visible = true;
            labelcurrentCAT.Text = "Data types,Variables,Operators";
            categ = "Data types,Variables,Operators";
            labelcurrentCAT.Visible = true;
            dvO11.correct = 0;
            dvO11.mistake = 0;
            DVO1.completed1 = false;
            DVO1.completed2 = false;
            DVO1.completed3 = false;
            DVO1.completed4 = false;
            dvO11.labelQ.ResetText();
            dvO11.number = 1;
            dvO11.cat = 1;
        }

        private void dvO11_Load(object sender, EventArgs e)
        {

        }
        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
        //back button closes forms and usercontrols
        private void buttonBack_Click(object sender, EventArgs e)
        {
            dvO11.h = 0;
            dvO11.m = 0;
            dvO11.s = 0;
            acheivements1.buttonCheck.Enabled = true;
            dvO11.Visible = false;
            stats1.Visible = false;
            labelcategory.Visible = false;
            labelcurrentCAT.Visible = false;
            dvO11.back = true;
            dvO11.buttonSubmit.Enabled = true;
            dvO11.buttonSubmit.Visible = true;
            dvO11.Nextbutton.Enabled = true;
            dvO11.Nextbutton.Visible = true;
            stats1.buttonLoadStat.Enabled = true;
            acheivements1.Enabled = false;
            acheivements1.Visible = false;
            help1.Enabled = false;
            help1.Visible = false;
            acheivements1.panel1.Visible = false;
            dvO11.labelA.ResetText();
            dvO11.labelB.ResetText();
            dvO11.labelC.ResetText();
            dvO11.labelD.ResetText();
            dvO11.labelmistakes.ResetText();
            dvO11.labelTimer.ResetText();


            //uploading statistics every time a category is completed
   
        }

        private void buttonLoo_Click(object sender, EventArgs e)
        {
            dvO11.Visible = true;
            stats1.Visible = false;
            acheivements1.Visible = false;
            labelcategory.Visible = true;
            labelcurrentCAT.Text = "Looping Statements";
            categ = "Looping Statements";
            labelcurrentCAT.Visible = true;
            DVO1 category = new DVO1();
            DVO1.completed1 = false;
            DVO1.completed2 = false;
            DVO1.completed3 = false;
            DVO1.completed4 = false;
            dvO11.labelQ.ResetText();

            dvO11.number = 8;
            dvO11.correct = 0;
            dvO11.mistake = 0;
            dvO11.cat = 2;
           
        }

        private void buttonCla_Click(object sender, EventArgs e)
        {
            dvO11.Visible = true;
            labelcategory.Visible = true;
            stats1.Visible = false;
            labelcurrentCAT.Text = "Classes";
            categ = "Classes";
            labelcurrentCAT.Visible = true;
            DVO1 category = new DVO1();
            dvO11.number = 15;
            dvO11.correct = 0;
            DVO1.completed1 = false;
            DVO1.completed2 = false;
            DVO1.completed3 = false;
            DVO1.completed4 = false;
            dvO11.labelQ.ResetText();

            dvO11.mistake = 0;
            dvO11.cat = 3;
           
        }

        private void buttonARS_Click(object sender, EventArgs e)
        {
            dvO11.Visible = true;
            stats1.Visible = false;
            labelcategory.Visible = true;
            labelcurrentCAT.Text = "Arrays and Strings";
            categ = "Arrays and Strings";
            labelcurrentCAT.Visible = true;
            DVO1 category = new DVO1();
            dvO11.number = 22;
            dvO11.correct = 0;
            dvO11.mistake = 0;
            DVO1.completed1 = false;
            DVO1.completed2 = false;
            DVO1.completed3 = false;
            DVO1.completed4 = false;
            dvO11.labelQ.ResetText();

            dvO11.cat = 4;
            
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            stats1.Visible = true;
            stats1.Enabled = true;
            panelstart.Visible = true;
            acheivements1.Visible = false;
            acheivements1.Enabled = false;
            help1.Visible = false;
            help1.Enabled = false;

        }

        private void buttonAcheivements_Click(object sender, EventArgs e)
        {
            panelstart.Visible = true;
            acheivements1.Visible = true;
            acheivements1.Enabled = true;
            stats1.Visible = false;
            stats1.Enabled = false;
            help1.Visible = false;
            help1.Enabled = false;
        }

        private void buttonHelp_MouseClick(object sender, MouseEventArgs e)
        {
            panelstart.Visible = true;
            help1.Visible = true;
            help1.Enabled = true;
            acheivements1.Visible = false;
            acheivements1.Enabled = false;
            stats1.Visible = false;
            stats1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }
    }
}
