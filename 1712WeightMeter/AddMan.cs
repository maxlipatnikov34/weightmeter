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
    public partial class AddMan : Form
    {
        public AddMan()
        {
            InitializeComponent();
        }

        private void AddManAccept_Click(object sender, EventArgs e)
        {
            string Name = AddManName.Text;
            ManipulationClass.AddManToListOfMan(new Man(Name));
            this.Close();
        }

        private void AddMan_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataClass.isAddingMan = false;
        }

        private void AddManDecline_Click(object sender, EventArgs e)
        {
            DataClass.isAddingMan = false;
            this.Close();
        }
    }
}
