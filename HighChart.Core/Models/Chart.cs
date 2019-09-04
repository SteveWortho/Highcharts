
using HighChart.Core.Enums;

namespace HighChart.Core.Models
{
    /// <summary>
    /// A subset of the Highcharts.net Chart object
    /// When we can go to .net 4.6.1 then we can replace these with
    /// the actual highcharts models if we wish from highcharts.net
    /// </summary>
    public class Chart
    {
        public string backgroundColor { get; set; } = "transparent";
        public string borderColor { get; set; }
        public string borderRadius { get; set; }
        public string borderWidth { get; set; }
        public string defaultSeriesType { get; set; } = ChartType.Line;
        public int marginRight { get; set; }
        public int marginLeft { get; set; }
    }
}
