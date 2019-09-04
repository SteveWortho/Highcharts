using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighChart.Core.Enums;
using Newtonsoft.Json;

namespace HighChart.Core.Models
{
    public class Highcharts
    {
        

        //public Tooltip Tooltip { get; set; }

        //public PlotOptions PlotOptions { get; set; }

        public XAxis xAxis { get; set; }
        public YAxis yAxis { get; set; }
        public List<ColumnSeriesData> series { get; set; }
        public Credits credits { get; set; }
        public Chart chart { get; set; }
        public Title title { get; set; } = new Title { text = "" };

        public string toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
