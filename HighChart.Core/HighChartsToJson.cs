using HighChart.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HighChart.Core
{
    public  static class HighChartsToJson
    {
        public static string GetSerializedData(this Models.Highcharts highcharts)
        {
            NameValueCollection outgoingQueryString = HttpUtility.ParseQueryString(String.Empty);

            //outgoingQueryString.Add("async", "false");
            outgoingQueryString.Add("content", "options");
            outgoingQueryString.Add("options", JsonConvert.SerializeObject(highcharts).Replace("\"", "'"));
            outgoingQueryString.Add("type", ChartExportFormat.png);
            outgoingQueryString.Add("width", "");
            outgoingQueryString.Add("scale", "");
            outgoingQueryString.Add("constr", "");
            //outgoingQueryString.Add("callback", highcharts.callback);
            return outgoingQueryString.ToString();
        }
    }
}
