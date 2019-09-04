using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighChart.Core.Models
{

    public class Title
    {
        public Title()
        {
            Hashtable styleHT = new Hashtable();
            styleHT.Add("fontSize", 12);
            style = styleHT;
        }
        public string text { get; set; }
        public Hashtable style { get; set; }
        public bool useHtml { get; set; } = false;
    }
}
