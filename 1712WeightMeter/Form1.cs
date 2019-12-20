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
    public partial class WeightMeter : Form
    {
        public WeightMeter()
        {
            InitializeComponent();
        }

        private void AddNewMan_Click(object sender, EventArgs e)
        {
            if (DataClass.isAddingMan == false)
            {
                AddMan addMan = new AddMan();
                addMan.Show();
                DataClass.isAddingMan = true;
            }
        }

        private void ListOfMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void WeightMeter_Load(object sender, EventArgs e)
        {
            DataClass.listViewOfMan = ListOfMan;
            ManipulationClass.LoadDataFromFile();
            ManipulationClass.LoadWeightsFromFile();
        }

        private void ListOfMan_ItemActivate(object sender, EventArgs e)
        {
            if (DataClass.isShowingManInfo == false)
            {
                ManInfo manInfo = new ManInfo(DataClass.listOfMan[ListOfMan.Items.IndexOf(ListOfMan.SelectedItems[0])]);
                manInfo.Show();
                DataClass.isShowingManInfo = true;
            }
        }

        private void WeightMeter_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManipulationClass.SaveManToFileFull();
            ManipulationClass.SaveWeightsToFileFull();
        }

        private void RemoveMan_Click(object sender, EventArgs e)
        {
            try
            {
                ManipulationClass.RemoveManFromList(ListOfMan.Items.IndexOf(ListOfMan.SelectedItems[0]));
            }
            catch
            {

            }
        }
    }
}
