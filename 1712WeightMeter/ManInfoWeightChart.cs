using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _1712WeightMeter
{
    public partial class ManInfoWeightChart : Form
    {
        Man man;
        public ManInfoWeightChart(Man man)
        {
            InitializeComponent();
            this.man = man;
        }

        private void ManInfoWeightChart_Load(object sender, EventArgs e)
        {
            Series PointsOfWeights = new Series();
            PointsOfWeights.Name = "Weights";
            PointsOfWeights.ChartType = SeriesChartType.Line;
            for (int i = 0; i < man.listOfWeight.Count; i++)
                PointsOfWeights.Points.Add(new DataPoint(i, man.listOfWeight[i].weightValue));
            for (int k = 0; k < PointsOfWeights.Points.Count; k++)
                PointsOfWeights.Points[k].AxisLabel = man.listOfWeight[k].weightDate.ToString();
            chart1.Series.Add(PointsOfWeights);
        }

        private void ManInfoWeightChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataClass.isShowingManInfoChart = false;
            chart1.Series.Clear();
        }
    }
}
