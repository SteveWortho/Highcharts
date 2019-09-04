using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using HighChart.Core.Service;
using HighChart.Core.Models;
using HighChart.Core.Enums;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace HighCharts.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// get chat image in file formate .png
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //get high chart dummy data
            var highChartsData = GetUserEngagementHighChartsData();
            //formatted data in json to test
            //var formattedData = highChartsData.toJson();
            //call chart request service to get the image byte array
            HighChartsRequestService chartService = new HighChartsRequestService();
            var serviceResult = chartService.RequestGraph("", highChartsData);
            return File(serviceResult, "image.png");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// get chart image in byte array
        /// </summary>
        /// <returns></returns>
        public ActionResult getChartImage()
        {
            //get dummy chart data
            var highChartsData = GetUserEngagementHighChartsData();
            //call highchart request service for export funtionality
            HighChartsRequestService chartService = new HighChartsRequestService();
            var serviceResult = chartService.RequestGraph("", highChartsData);
            return new FileContentResult(serviceResult, "application/octet-stream");
        }

        /// <summary>
        /// get chart dummy data
        /// </summary>
        /// <returns></returns>
        private static Highcharts GetUserEngagementHighChartsData()
        {

            var highChartsStyle = new ChartsStyle() { color = "#000000", fontWeight = "normal" };
            var titleStyle = new System.Collections.Hashtable();
            titleStyle.Add("fontSize", 25);
            return new Highcharts()
            {
                chart = new Chart() { borderColor = "#000000",
                    borderRadius = "", borderWidth = "", defaultSeriesType = ChartType.Column },
                title = new Title() { text = "test data", style = titleStyle },
                xAxis = new XAxis()
                {
                    gridLineWidth = 0,
                    categories = new List<string> { "1", "2", "3", "4" },
                    labels = new AxisLabels()
                    {
                        style = highChartsStyle
                    }
                },
                yAxis = new YAxis()
                {
                    gridLineWidth = 1,
                    labels = new AxisLabels()
                    {
                        align = "right",
                        style = highChartsStyle
                    },
                    title = new Title() { text = "test", style = titleStyle },
                    gridLineColor = "#8C8C8C",
                    tickInterval = 10,
                    tickmarkPlacement = "on"

                },
                series = new List<ColumnSeriesData>{ new ColumnSeriesData()
                    {
                        name="Logins",
                        data = new List<int> {24,30,22,30},
                        color="#2D5F91",
                        type =""
                    },
                },
                credits = new Credits() { enabled = false }
            };
        }

    }
}