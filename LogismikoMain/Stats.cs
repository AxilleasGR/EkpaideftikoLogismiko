using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Collections;
using NpgsqlTypes;

namespace LogismikoMain
{
    public partial class Stats : UserControl
    {
        public Stats()
        {
            InitializeComponent();
        }
        string user = LoginForm.user;
        string time="0";        
        string corr;
        string worstcat;
        ArrayList catpart = new ArrayList();
        string CatCompl;       
        string miss;
        //loads statistics from database
        private void buttonLoadStat_Click(object sender, EventArgs e)
        {
            buttonLoadStat.Enabled = false;
            //sum of time 
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA");
            conn.Open();
            NpgsqlCommand timecomm = new NpgsqlCommand($"SELECT SUM(time) FROM public.stats WHERE username = '{user}' " ,conn);
            
            using (var read = timecomm.ExecuteReader())
            {
                while (read.Read())
                {
                    time = read["sum"].ToString();
                    if (time=="")
                    {
                        MessageBox.Show("no stats");
                        return;
                    }
                    labelTime.Text = $"{time} seconds spent!!!";
                }   
            }
            // sum of correct answers
            NpgsqlCommand correctcomm = new NpgsqlCommand($"SELECT SUM(correct) FROM public.stats WHERE username = '{user}' ", conn);
            using (var read = correctcomm.ExecuteReader())
            {
                while (read.Read())
                {
                    corr = read["sum"].ToString();                    
                    labelAnswers.Text = $"{corr} correct answers!!!";
                    textBoxCORR.Text = corr;
                }
            }
            //sum of mistakes
            NpgsqlCommand mistakecomm = new NpgsqlCommand($"SELECT SUM(mistake) FROM public.stats WHERE username = '{user}' ", conn);
            using (var read = mistakecomm.ExecuteReader())
            {
                while (read.Read())
                {
                    miss = read["sum"].ToString();                             
                    labelmistakes.Text = $"{miss} mistakes...";
                    textBoxMIS.Text = miss;
                }
            }
            //calculate ratio
            int co = Int32.Parse(textBoxCORR.Text);
            int mis = Int32.Parse(textBoxMIS.Text);
            int sum = co + mis;
            double ratio = Convert.ToDouble(co) / Convert.ToDouble(sum);
            ratio = ratio * 100;
            

            labelRATIO.Text = $"You have {String.Format("{0:0.00}", ratio)}% correct answer ratio";


            //a category with 7 correct and 0 mistakes is a completed category
            NpgsqlCommand Catcomm = new NpgsqlCommand($"SELECT qcategory FROM public.stats WHERE username = '{user}' AND correct =7 ", conn);
            using (var read = Catcomm.ExecuteReader())
            {
                while (read.Read())
                {
                    CatCompl = read["qcategory"].ToString();
                    labelCatcompleted.Text = $"You have completed these categories: {CatCompl}";
                }
            }
            //categories participaded are all the categories finished but just that
            NpgsqlCommand CatParcomm = new NpgsqlCommand($"SELECT qcategory FROM public.stats WHERE username = '{user}' ", conn);
            using (var read = CatParcomm.ExecuteReader())
            {
                while (read.Read())
                {
                    catpart.Add(read["qcategory"]);
                }
                foreach (var cat in catpart)
                {
                    textBox1.AppendText(string.Join("",cat.ToString()));
                    System.Diagnostics.Debug.WriteLine(cat.ToString());
                }
            }
            //select qcategory from stats where mistake in (select max(mistake) from stats where username)
            //worst category
            NpgsqlCommand worsCatcomm = new NpgsqlCommand($"select qcategory, mistake from stats where username = '{user}' AND mistake = 6 or mistake = 7 ", conn);
            using (var read = worsCatcomm.ExecuteReader())
            {
                while (read.Read())
                {
                    worstcat = read["qcategory"].ToString();
                    labelWeakestCat.Text = $"{worstcat}. This is your weakest performance, we advise you to start this category first!";
                }
            }
            conn.Close();

        }
    }


}

