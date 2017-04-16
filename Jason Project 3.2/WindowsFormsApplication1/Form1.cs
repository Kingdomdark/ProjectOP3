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

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1;Database=Project3"))
            {
                conn.Open();
            }
            InitializeComponent();
        }
        public void SelectData()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1;Database=Project3"))
            {
                conn.Open();
                String query = "select city, temp_lo, date from weather";
                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                this.richTextBox1.AppendText("RESULT SelectData():\n");
                try
                {
                    NpgsqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        richTextBox1.AppendText(string(dr[0]) + "\t");
                        richTextBox1.AppendText(Convert.ToString(dr[1]) + "\t");
                        richTextBox1.AppendText((DateTime(dr[2])->ToString("dd MMM yyyy") + "\n"));
                    }
                    richTextBox1.AppendText("\n");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Parameters let you dynamically insert values into SQL queries at run-time.  
        public void DynamicInsert()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1;Database=Project3"))
            {
                conn.Open();
                String query = "select temp_lo, temp_hi from weather where temp_lo = :value1";
                // declare parameter in query string  
                Npgsql.NpgsqlCommand command = new NpgsqlCommand(query, conn);
                // add parameter to the parameter collection of the command specifying its type  
                command.Parameters.Add(new NpgsqlParameter("value1", NpgsqlTypes.NpgsqlDbType.Integer));
                // add a value to it  
                command.Parameters[0].Value = 37;       // must exist in the database  
                                                        // execute the command as usual  
                try
                {
                    NpgsqlDataReader dr = command.ExecuteReader();
                    richTextBox1.AppendText("RESULT DynamicInsert():\n");
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            richTextBox1.AppendText(Convert.ToString(dr[i]));
                            richTextBox1.AppendText("\t");
                        }
                        richTextBox1.AppendText("\n");
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }
                
        private void ShowGraph_Click(object sender, EventArgs e)
        {
            if (BarChart.Checked == true)
            {
                if (MotorvoertuigenDiefstal.Checked == true)
                {
                    if (IJsselmonde.Checked == true)
                    {

                    }
                    else if (KralingenCrooswijk.Checked == true)
                    {

                    }
                    else if (Pernis.Checked == true)
                    {

                    }
                    else if (HillegersbergSchiebroek.Checked == true)
                    {

                    }
                    else if (Feijenoord.Checked == true)
                    {

                    }
                    else if (RotterdamNoord.Checked == true)
                    {

                    }
                    else if (RotterdamCentrum.Checked == true)
                    {

                    }
                    else if (Rozenburg.Checked == true)
                    {

                    }
                    else if (Delfshaven.Checked == true)
                    {

                    }
                    else if (PrinsAlexander.Checked == true)
                    {

                    }
                    else if (HoekVanHolland.Checked == true)
                    {

                    }
                    else if (Overschie.Checked == true)
                    {

                    }
                    else if (Hoogvliet.Checked == true)
                    {

                    }
                    else if (Charlois.Checked == true)
                    {

                    }
                }
                else if (MotorBromSnorFietsen.Checked == true)
                {
                    if (IJsselmonde.Checked == true)
                    {

                    }
                    else if (KralingenCrooswijk.Checked == true)
                    {

                    }
                    else if (Pernis.Checked == true)
                    {

                    }
                    else if (HillegersbergSchiebroek.Checked == true)
                    {

                    }
                    else if (Feijenoord.Checked == true)
                    {

                    }
                    else if (RotterdamNoord.Checked == true)
                    {

                    }
                    else if (RotterdamCentrum.Checked == true)
                    {

                    }
                    else if (Rozenburg.Checked == true)
                    {

                    }
                    else if (Delfshaven.Checked == true)
                    {

                    }
                    else if (PrinsAlexander.Checked == true)
                    {

                    }
                    else if (HoekVanHolland.Checked == true)
                    {

                    }
                    else if (Overschie.Checked == true)
                    {

                    }
                    else if (Hoogvliet.Checked == true)
                    {

                    }
                    else if (Charlois.Checked == true)
                    {

                    }
                }
                

                var BarChart = new BarChart();
                BarChart.Show();
            }
            else if (PieChart.Checked == true)
            {
                if (MotorvoertuigenDiefstal.Checked == true)
                {
                    if (IJsselmonde.Checked == true)
                    {

                    }
                    else if (KralingenCrooswijk.Checked == true)
                    {

                    }
                    else if (Pernis.Checked == true)
                    {

                    }
                    else if (HillegersbergSchiebroek.Checked == true)
                    {

                    }
                    else if (Feijenoord.Checked == true)
                    {

                    }
                    else if (RotterdamNoord.Checked == true)
                    {

                    }
                    else if (RotterdamCentrum.Checked == true)
                    {

                    }
                    else if (Rozenburg.Checked == true)
                    {

                    }
                    else if (Delfshaven.Checked == true)
                    {

                    }
                    else if (PrinsAlexander.Checked == true)
                    {

                    }
                    else if (HoekVanHolland.Checked == true)
                    {

                    }
                    else if (Overschie.Checked == true)
                    {

                    }
                    else if (Hoogvliet.Checked == true)
                    {

                    }
                    else if (Charlois.Checked == true)
                    {

                    }
                }
                else if (MotorBromSnorFietsen.Checked == true)
                {
                    if (IJsselmonde.Checked == true)
                    {

                    }
                    else if (KralingenCrooswijk.Checked == true)
                    {

                    }
                    else if (Pernis.Checked == true)
                    {

                    }
                    else if (HillegersbergSchiebroek.Checked == true)
                    {

                    }
                    else if (Feijenoord.Checked == true)
                    {

                    }
                    else if (RotterdamNoord.Checked == true)
                    {

                    }
                    else if (RotterdamCentrum.Checked == true)
                    {

                    }
                    else if (Rozenburg.Checked == true)
                    {

                    }
                    else if (Delfshaven.Checked == true)
                    {

                    }
                    else if (PrinsAlexander.Checked == true)
                    {

                    }
                    else if (HoekVanHolland.Checked == true)
                    {

                    }
                    else if (Overschie.Checked == true)
                    {

                    }
                    else if (Hoogvliet.Checked == true)
                    {

                    }
                    else if (Charlois.Checked == true)
                    {

                    }
                }
                var PieChart = new PieChart();
                PieChart.Show();
            }

        }

        private void BarChart_CheckedChanged(object sender, EventArgs e)
        {
            if (BarChart.Checked == true)
            {
                PieChart.Checked = false;
            }
        }

        private void PieChart_CheckedChanged(object sender, EventArgs e)
        {
            if (PieChart.Checked == true)
            {
                BarChart.Checked = false;
            }
        }
        private void MotorvoertuigenDiefstal_CheckedChanged_1(object sender, EventArgs e)
        {
            if (MotorvoertuigenDiefstal.Checked == true)
            {
                MotorBromSnorFietsen.Checked = false;
            }
        }

        private void MotorBromSnorFietsen_CheckedChanged_1(object sender, EventArgs e)
        {
            if (MotorBromSnorFietsen.Checked == true)
            {
                MotorvoertuigenDiefstal.Checked = false;
            }
        }
    }
}

//random test