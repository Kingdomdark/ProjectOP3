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
            if (TwoK11.Checked == false && TwoK10.Checked == false && TwoK9.Checked == false && TwoK8.Checked == false && TwoK7.Checked == false && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK10.Checked = false;
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
            if (TwoK11.Checked == false && TwoK10.Checked == false && TwoK9.Checked == false && TwoK8.Checked == false && TwoK7.Checked == false && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK10.Checked = false;
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
            if (TwoK11.Checked == false && TwoK10.Checked == false && TwoK9.Checked == false && TwoK8.Checked == false && TwoK7.Checked == false && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK10.Checked = false;
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
            if (TwoK11.Checked == false && TwoK10.Checked == false && TwoK9.Checked == false && TwoK8.Checked == false && TwoK7.Checked == false && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK10.Checked = false;
                TwoK9.Checked = false;
                TwoK8.Checked = false;
                TwoK7.Checked = false;
                TwoK6.Checked = false;
            }
        }

        private void TwoK10_CheckedChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
            }
            if (TwoK11.Checked == false && TwoK10.Checked == false && TwoK9.Checked == false && TwoK8.Checked == false && TwoK7.Checked == false && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK10.Checked = false;
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
            if (TwoK11.Checked == false && TwoK10.Checked == false && TwoK9.Checked == false && TwoK8.Checked == false && TwoK7.Checked == false && TwoK6.Checked == false)
            {
                panel1.Visible = false;
                TwoK11.Checked = false;
                TwoK10.Checked = false;
                TwoK9.Checked = false;
                TwoK8.Checked = false;
                TwoK7.Checked = false;
                TwoK6.Checked = false;
            }
        }

        private void IJsselmonde_CheckedChanged(object sender, EventArgs e)
        {
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
            && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
            && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
            && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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
            if (IJsselmonde.Checked == false && KralingenCrooswijk.Checked == false && Delfshaven.Checked == false && Pernis.Checked == false
                && HillegersbergSchiebroek.Checked == false && PrinsAlexander.Checked == false && RotterdamNoord.Checked == false
                && RotterdamCentrum.Checked == false && Feijenoord.Checked == false && Rozenburg.Checked == false
                && HoekVanHolland.Checked == false && Overschie.Checked == false && Hoogvliet.Checked == false && Charlois.Checked == false)
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

        private void ShowGraph_Click_1(object sender, EventArgs e)
        {
            if (BarChart.Checked == true)
            {
                var BarChart = new BarChart();
                BarChart.Show();
            }
            if (PieChart.Checked == true)
            {
                var PieChart = new PieChart();
                PieChart.Show();
            }

        }
    }
}

//random test