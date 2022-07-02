using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace LogismikoMain
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            comboBoxAns.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //counter for help button
        int counter = 0;
        //puts question in database
        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=0000;Database=AAAAAAAAAAAA");
            conn.Open();
            try
            {
                //create insert              
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO " + "final(question, answer, category) VALUES (:que, :ans," + " :cat)", conn);
                //add parameters                
                cmd.Parameters.Add(new NpgsqlParameter("que", NpgsqlTypes.NpgsqlDbType.Varchar));
                cmd.Parameters.Add(new NpgsqlParameter("ans", NpgsqlTypes.NpgsqlDbType.Varchar));
                cmd.Parameters.Add(new NpgsqlParameter("cat", NpgsqlTypes.NpgsqlDbType.Varchar));
            
                //prepare
                cmd.Prepare();
                //add values
                cmd.Parameters[0].Value = textBoxQuestion.Text.Trim();
                cmd.Parameters[1].Value = comboBoxAns.Text.Trim();
                cmd.Parameters[2].Value = comboBoxCat.Text.Trim();
                
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
        }
        //log out button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            counter++;
            if (IsOdd(counter))
            {
                labelHelp.Visible = true;
            }
            else
            {
                labelHelp.Visible = false;
            }
            
        }

        public static bool IsOdd(int counter)
        {
            return counter % 2 != 0;
        }
    }
}
