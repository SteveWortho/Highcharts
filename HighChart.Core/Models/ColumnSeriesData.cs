using HighChart.Core.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighChart.Core.Models
{
    public class ColumnSeriesData
    {
        public string type { get; set; } = ChartType.Default;
        public IEnumerable data { get; set; }
        public ChartDataGrouping dataGrouping { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        
    }
}
