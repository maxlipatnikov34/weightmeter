using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1712WeightMeter
{
    public class Man
    {
        public string Name = "None";
        public List<WeightData> listOfWeight = new List<WeightData>();
        public ListView listViewOfWeight;
        public Man(string name)
        {
            this.Name = name;
        }
    }
}
