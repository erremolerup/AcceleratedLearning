using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void get_forecast_as_string()
        {
            var service = new SmhiService();
            string forecast = service.Get("https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json").Result;

        }

        [TestMethod]
        public void get_forecast_as_object_graph()
        {
            var service = new SmhiService();
            Rootobject forecast = service.GetMetereologicalForecast(57.84528M, 12.96771M).Result;


        }

        [TestMethod]
        public void get_forecast_as_object_longlat()
        {
            var service = new SmhiService();

            Rootobject forecast = service.GetMetereologicalForecast(57.84528M, 12.96771M).Result;


        }

        [TestMethod]
        public void get_temperature_for_first_timeserie()
        {
            var service = new SmhiService();
            Rootobject result = service.GetMetereologicalForecast(13.846M, 58.390M).Result; // Skövde

            Timesery firstTimeSeries = result.timeSeries[0];

            DateTime time = result.timeSeries[0].validTime; // klockslag
            decimal value = result.timeSeries[0].parameters[11].values[0];  //värde(temperatur) (om temperaturen fortfarande är på position 11)
            string paramname = result.timeSeries[0].parameters[11].name; // namn ("t")

        }

        [TestMethod]
        public void get_temperature_for_first_timeserie_better()
        {
            var service = new SmhiService();
            var result = service.GetMetereologicalForecast(13.846M, 58.390M).Result;

            DateTime time = result.timeSeries[0].validTime;
            Parameter param = result.timeSeries[0].parameters.Single(p => p.name == "t");
            decimal temperature = param.values[0];
        }

        [TestMethod]
        public void get_all_temperature_for_a_position_a_given_day()
        {
            var service = new SmhiService();
            var result = service.GetMetereologicalForecast(13.846M, 58.390M).Result;

            List<TimeTemp> timetemps = service.FilterTemperature(result, DateTime.Now);
        }

    }

}
