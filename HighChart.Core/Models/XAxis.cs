
using System.Collections.Generic;


namespace HighChart.Core.Models
{
    public class XAxis: ChartAxis
    {
        public IEnumerable<string> categories { get; set; }
        public override int gridLineWidth { get; set; }
        public override AxisLabels labels { get; set; } = new AxisLabels() { x = 0 };
    }
}
