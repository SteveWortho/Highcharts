using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighChart.Core.Models
{
    public class YAxis: ChartAxis
    {
        public IEnumerable<string> categories { get; set; }
        public override int gridLineWidth { get; set; } = 1;
        public override AxisLabels labels { get; set; } = new AxisLabels() { x = 0, y = -2 };

    }
}
