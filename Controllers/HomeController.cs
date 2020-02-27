using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    public class HomeController : Controller
    {
        public RootObject GetWeatherForecast()
        {
            string json = (new WebClient()).DownloadString("https://www.metaweather.com/api/location/44544/");
            return JsonConvert.DeserializeObject<RootObject>(json);
        }
        public ActionResult Index()
        {
            var model = GetWeatherForecast();
            return View(model);
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
    }
}