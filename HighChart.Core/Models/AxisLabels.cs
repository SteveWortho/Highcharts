using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighChart.Core.Models
{
    public class AxisLabels
    {
        public string align { get; set; } = "center";

        public string format { get; set; } = "{value}";
        /// <summary>
        /// 
        /// Callback JavaScript function to format the label. The value is given by this.value. Additional properties for this are axis, chart, isFirst and isLast. Defaults to:
        ////function()
        ///{
            //return this.value;
        ///}
        /// </summary>
        public string formatter { get; set; }

        public string autoRotation { get; set; } = "[-45]";

        public string rotation { get; set; }

        public ChartsStyle style { get; set; } = new ChartsStyle();

        public int? y { get; set; }

        public int? x { get; set; }


    }
}
