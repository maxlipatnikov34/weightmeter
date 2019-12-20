using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1712WeightMeter
{
    public class WeightData
    {
        public double weightValue = 0.0;
        public DateTime weightDate = DateTime.Now;
        public string Comment = "";
        public WeightData(double weightValue, DateTime weightDate, string Comment)
        {
            this.weightValue = weightValue;
            this.weightDate = weightDate;
            this.Comment = Comment;
        }
    }
}
