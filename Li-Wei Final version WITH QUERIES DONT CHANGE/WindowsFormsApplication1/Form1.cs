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
            //starts main menu
            InitializeComponent();
        }
        //if one of the years is checked, you're able to choose between the locations, by making panel 1 visible.
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
        //if one of the locations is checked, you're able to choose between the type of data you want, by making panel 2 visible
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
        {   //if one of these is checked, the others are unchecked
            if (MotorvoertuigenDiefstal.Checked == true)
            {
                MotorBromSnorFietsen.Checked = false;
                Combined.Checked = false;
            }
        }
        private void Combined_CheckedChanged(object sender, EventArgs e)
        {   //if one of these is checked, the others are unchecked
            if (Combined.Checked == true)
            {
                MotorBromSnorFietsen.Checked = false;
                MotorvoertuigenDiefstal.Checked = false;
            }
        }
        private void MotorBromSnorFietsen_CheckedChanged(object sender, EventArgs e)
        {   //if one of these is checked, the others are unchecked
            if (MotorBromSnorFietsen.Checked == true)
            {
                Combined.Checked = false;
                MotorvoertuigenDiefstal.Checked = false;
            }
        }
        //if one of the types of data and the type of graph is checked, you're able to show the graph
        private void BarChart_CheckedChanged_1(object sender, EventArgs e)
        {   //if one of these is checked, the others are unchecked
            if (BarChart.Checked == true)
            {
                PieChart.Checked = false;
                panel3.Visible = true;
            }
        }

        private void PieChart_CheckedChanged_1(object sender, EventArgs e)
        {   //if one of these is checked, the others are unchecked
            if (PieChart.Checked == true)
            {
                BarChart.Checked = false;
                panel3.Visible = true;
            }
        }

        private void LoadGraph_Click(object sender, EventArgs e)
        {//we tried making the queries more dynamic, but didn't find a way so this is basically dead code
            /*List<string> allCheckedLocations = new List<string>();

            var allControlsLocations = this.panel1.Controls;
            for (int i = 0; i < allControlsLocations.Count; i++)
            {
                CheckBox controlLocation = (CheckBox)allControlsLocations[i];
                if (controlLocation.Checked)
                {
                    allCheckedLocations.Add(controlLocation.Name);
                }
            }*/

            //makes a connection
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=liweiyeh;Database=Project3"))
            {
                conn.Open(); //opens the connection
                if (BarChart.Checked == true)
                {
                    if (Combined.Checked == true)
                    {
                        if (TwoK6.Checked && TwoK7.Checked && TwoK8.Checked && TwoK9.Checked && TwoK11.Checked && Charlois.Checked && Delfshaven.Checked && Feijenoord.Checked && HillegersbergSchiebroek.Checked && HoekVanHolland.Checked && Hoogvliet.Checked && IJsselmonde.Checked && KralingenCrooswijk.Checked && Overschie.Checked && Pernis.Checked && PrinsAlexander.Checked && RotterdamCentrum.Checked && RotterdamNoord.Checked && Rozenburg.Checked == true)
                            using (var cmd = new NpgsqlCommand())
                            {
                                cmd.Connection = conn;
                                //example of query
                                cmd.CommandText = string.Format("select sum(barchart) total from(select barchart from diefstal_motorvoertuigen union all select barchart from diefstal_tweewielers)t");

                                using (var reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {//add the data from the query to the table (in this case a barchart)
                                        this.chartBar.Series["Combined"].Points.AddXY("AllCombined", reader.GetInt64(0));
                                    }
                                }
                            }
                    }
                    if (MotorvoertuigenDiefstal.Checked == true)
                    {
                        if (TwoK6.Checked == true)
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
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK7.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK8.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK9.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK11.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (MotorBromSnorFietsen.Checked == true)
                    {
                        if (TwoK6.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK7.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK8.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK9.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK11.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartBar.Series[reader.GetString(1)].Points.AddXY(reader.GetString(0), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (PieChart.Checked == true)
                {
                    if (MotorvoertuigenDiefstal.Checked == true)
                    {
                        if (TwoK6.Checked == true)
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
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK7.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK8.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK9.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK11.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='IJsselmonde' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Kralingen-Crooswijk' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Delfshaven' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Pernis' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hillegersberg-Schiebroek' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Prins Alexander' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Noord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Feijenoord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rotterdam Centrum' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Rozenburg' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoek van Holland' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Overschie' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Hoogvliet' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_motorvoertuigen WHERE name='Charlois' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (MotorBromSnorFietsen.Checked == true)
                    {
                        if (TwoK6.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2006'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK7.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2007'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK8.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2008'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK9.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2009'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                        }
                        if (TwoK11.Checked == true)
                        {
                            if (IJsselmonde.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='IJsselmonde' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (KralingenCrooswijk.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Kralingen-Crooswijk' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Delfshaven.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Delfshaven' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Pernis.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Pernis' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HillegersbergSchiebroek.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hillegersberg-Schiebroek' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (PrinsAlexander.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Prins Alexander' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamNoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Noord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Feijenoord.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Feijenoord' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (RotterdamCentrum.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rotterdam Centrum' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Rozenburg.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Rozenburg' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (HoekVanHolland.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoek van Holland' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Overschie.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Overschie' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Hoogvliet.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Hoogvliet' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
                                        }
                                    }
                                }
                            }
                            if (Charlois.Checked == true)
                            {
                                using (var cmd = new NpgsqlCommand())
                                {
                                    cmd.Connection = conn;

                                    cmd.CommandText = string.Format("SELECT * FROM diefstal_tweewielers WHERE name='Charlois' AND year='2011'");

                                    using (var reader = cmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            this.chartPie.Series[reader.GetString(0)].Points.AddXY(reader.GetString(1), reader.GetInt32(3));
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
//The code of the query we used. It's here for if something went wrong with the queries
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
