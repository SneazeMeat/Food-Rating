using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class ChartValue
    {

        public String CriteriaName;
        public float TotalValue;
        public float avgValue;

        public ChartValue(String CriteriaName, float TotalValue, float avgValue) {
            this.CriteriaName = CriteriaName;
            this.TotalValue = TotalValue;
            this.avgValue = avgValue;
        }

    }
}
