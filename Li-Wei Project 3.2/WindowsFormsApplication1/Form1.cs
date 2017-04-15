using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowGraph_Click(object sender, EventArgs e)
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
    }
}

//random test