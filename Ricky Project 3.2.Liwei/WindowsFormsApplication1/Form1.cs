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

            //using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1;Database=Project3"))
            //{
            //    conn.Open();
            //}
            InitializeComponent();
        }

        private void TwoK6_CheckedChanged(object sender, EventArgs e)
        {
            if(!panel1.Visible)
            {
                panel1.Visible = true;
            }
            if (TwoK11.Checked && TwoK9.Checked && TwoK8.Checked && TwoK7.Checked && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK9.Checked = false;
                TwoK8.Checked = false;
                TwoK7.Checked = false;
                TwoK6.Checked = false;
            }
        }

        private void TwoK7_CheckedChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
            }
            if (TwoK11.Checked && TwoK9.Checked && TwoK8.Checked && TwoK7.Checked && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK9.Checked = false;
                TwoK8.Checked = false;
                TwoK7.Checked = false;
                TwoK6.Checked = false;
            }
        }

        private void TwoK8_CheckedChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
            }
            if (TwoK11.Checked && TwoK9.Checked && TwoK8.Checked && TwoK7.Checked && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK9.Checked = false;
                TwoK8.Checked = false;
                TwoK7.Checked = false;
                TwoK6.Checked = false;
            }
        }

        private void TwoK9_CheckedChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
            }
            if (TwoK11.Checked && TwoK9.Checked && TwoK8.Checked && TwoK7.Checked && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK9.Checked = false;
                TwoK8.Checked = false;
                TwoK7.Checked = false;
                TwoK6.Checked = false;
            }
        }

        private void TwoK11_CheckedChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
            }
            if (TwoK11.Checked && TwoK9.Checked && TwoK8.Checked && TwoK7.Checked && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK9.Checked = false;
                TwoK8.Checked = false;
                TwoK7.Checked = false;
                TwoK6.Checked = false;
            }
        }

        private void IJsselmonde_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void KralingenCrooswijk_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void Delfshaven_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void Pernis_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void HillegersbergSchiebroek_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void PrinsAlexander_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void RotterdamNoord_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void Feijenoord_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void RotterdamCentrum_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void Rozenburg_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void HoekVanHolland_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void Overschie_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void Hoogvliet_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void Charlois_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked && KralingenCrooswijk.Checked && Delfshaven.Checked && Pernis.Checked
                && HillegersbergSchiebroek.Checked && PrinsAlexander.Checked && RotterdamNoord.Checked
                && RotterdamCentrum.Checked && Feijenoord.Checked && Rozenburg.Checked
                && HoekVanHolland.Checked && Overschie.Checked && Hoogvliet.Checked && Charlois.Checked == false)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void MotorvoertuigenDiefstal_CheckedChanged(object sender, EventArgs e)
        {
            if (MotorvoertuigenDiefstal.Checked == true)
            {
                MotorBromSnorFietsen.Checked = false;
            }
        }

        private void MotorBromSnorFietsen_CheckedChanged(object sender, EventArgs e)
        {
            if (MotorBromSnorFietsen.Checked == true)
            {
                MotorvoertuigenDiefstal.Checked = false;
            }
        }

        private void BarChart_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BarChart.Checked == true)
            {
                PieChart.Checked = false;
                panel3.Visible = true;
            }
        }

        private void PieChart_CheckedChanged_1(object sender, EventArgs e)
        {
            if (PieChart.Checked == true)
            {
                BarChart.Checked = false;
                panel3.Visible = true;
            }
        }

        private void LoadGraph_Click(object sender, EventArgs e)
        {
            List<string> allCheckedLocations = new List<string>();

            var allControlsLocations = this.panel1.Controls;
            for (int i = 0; i < allControlsLocations.Count; i++)
            {
                CheckBox controlLocation = (CheckBox)allControlsLocations[i];
                if (controlLocation.Checked)
                {
                    allCheckedLocations.Add(controlLocation.Name);
                }
            }


            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=liweiyeh;Database=Project3"))
            {
                conn.Open();
                if (BarChart.Checked == true)
                {
                    if (TwoK6.Checked == true)
                    {
                        if (MotorvoertuigenDiefstal.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.Clear();
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }   
        }
    }
}




//random test
/* using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = "SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2006'";
                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetString(2));
                                        }
                                    }
                                }*/