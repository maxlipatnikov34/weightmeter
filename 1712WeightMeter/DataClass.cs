using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1712WeightMeter
{
    static class DataClass
    {
        static public bool isAddingMan = false;
        static public bool isShowingManInfo = false;
        static public bool isAddingManInfo = false;
        static public bool isShowingManInfoChart = false;
        static public bool isAddingManInfoWeight = false;
        static public List<Man> listOfMan = new List<Man>();
        static public ListView listViewOfMan;
        static public ListView listViewofWeight;

    }
}

