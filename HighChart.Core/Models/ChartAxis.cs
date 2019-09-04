using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighChart.Core.Models
{
    public abstract class ChartAxis
    {
        public Title title { get; set; }

        public virtual AxisLabels labels { get; set; }
        public string alternateGridColor { get; set; }

        public string lineColor { get; set; }

        public string gridLineColor { get; set; }

        public string gridLineDashStyle { get; set; }

        public virtual int gridLineWidth { get; set; }

        public string minorGridLineColor { get; set; }

        public string minorGridLineDashStyle { get; set; }

        public string minorGridLineWidth { get; set; }

        public string minorTickPosition { get; set; } = "outside";

        public string minorTickColor { get; set; }

        public int minorTickLength { get; set; }

        public int minorTickWidth { get; set; }

        public double? tickInterval { get; set; }

        public string tickmarkPlacement { get; set; }

        public string tickColor { get; set; }

        public int tickLength { get; set; }

        public int tickWidth { get; set; }

        public string TickPosition { get; set; } = "outside";

        public string Type { get; set; }

    }
}
