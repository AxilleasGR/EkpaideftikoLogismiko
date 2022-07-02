using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EkpaideftikoLogismiko.Properties;

namespace LogismikoMain
{
    public partial class Help : UserControl
    {
        public Help()
        {
            InitializeComponent();
        }
        private bool isColapsed;

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void panelContents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //for drop down menu
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( isColapsed)
            {
                buttonCont.Image = Resources.Webp_net_resizeimage___Αντιγραφή;
                panelContents.Height += 10;
                if (panelContents.Size == panelContents.MaximumSize)
                {
                    timer1.Stop();
                    isColapsed = false;
                }
            }
            else
            {
                buttonCont.Image = Resources.Webp_net_resizeimage;
                panelContents.Height -= 10;
                if (panelContents.Size == panelContents.MinimumSize)
                {
                    timer1.Stop();
                    isColapsed = true;
                }
            }
        }
        //opens different panel
        private void buttonPurpose_Click(object sender, EventArgs e)
        {
            panelPurpose.Visible = true;
            panelStats.Visible = false;
            panelAcheivements.Visible = false;
            panelForTeachers.Visible = false;
            panelUsing.Visible = false;


        }

        private void buttonStats_MouseClick(object sender, MouseEventArgs e)
        {
            panelStats.Visible = true;
            panelPurpose.Visible = true;
            panelAcheivements.Visible = false;
            panelUsing.Visible = false;
            panelForTeachers.Visible = false;


        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            panelAcheivements.Visible = true;
            panelStats.Visible = false;
            panelPurpose.Visible = true;
            panelForTeachers.Visible = false;
            panelUsing.Visible = false;


        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            panelForTeachers.Visible = true;
            panelPurpose.Visible = true;
            panelStats.Visible = false;
            panelAcheivements.Visible = false;
            panelUsing.Visible = false;

        }

        private void buttonUsing_MouseClick(object sender, MouseEventArgs e)
        {
            panelUsing.Visible = true;
            panelPurpose.Visible = true;
            panelStats.Visible = false;
            panelAcheivements.Visible = false;
            panelStats.Visible = false;

        }
    }
}
