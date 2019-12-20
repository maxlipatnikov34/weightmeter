using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1712WeightMeter
{
    public partial class ManInfo : Form
    {
        Man man;
        public ManInfo(Man man)
        {
            InitializeComponent();
            this.man = man;
        }

        private void ManInfo_Load(object sender, EventArgs e)
        {
            DataClass.listViewofWeight = listView1;
            ManNameInfo.Text = man.Name;
            DataClass.listViewofWeight.Items.Clear();
            for (int i = 0; i < man.listOfWeight.Count; i++)
            {
                DataClass.listViewofWeight.Items.Add(new ListViewItem(man.listOfWeight[i].weightValue.ToString()));
                DataClass.listViewofWeight.Items[i].SubItems.Add(man.listOfWeight[i].weightDate.ToString());
                DataClass.listViewofWeight.Items[i].SubItems.Add(man.listOfWeight[i].Comment.ToString());
            }
        }

        private void AddWeight_Click(object sender, EventArgs e)
        {
            if (DataClass.isAddingManInfo == false)
            {
                AddWeightInfo addWeightInfo = new AddWeightInfo(man);
                addWeightInfo.Show();
                DataClass.isAddingManInfo = true;
            }
        }

        private void ManInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataClass.isShowingManInfo = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataClass.isShowingManInfoChart == false)
            {
                ManInfoWeightChart manInfoWeightChart = new ManInfoWeightChart(man);
                manInfoWeightChart.Show();
                DataClass.isShowingManInfoChart = true;
            }
        }
    }
}
