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
    public partial class AddWeightInfo : Form
    {
        Man man;
        public AddWeightInfo(Man man)
        {
            InitializeComponent();
            this.man = man;
        }

        private void AddWeightInfoAccept_Click(object sender, EventArgs e)
        {
            string value = AddWeightInfoWeightValue.Text;
            string comment = Comment.Text;
            ManipulationClass.AddWeightInfo(man, value, comment);
            this.Close();
        }

        private void AddWeightInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataClass.isAddingManInfo = false;
        }

        private void AddWeightInfoDecline_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
