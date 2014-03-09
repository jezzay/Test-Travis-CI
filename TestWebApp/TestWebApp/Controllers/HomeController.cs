﻿using System.Web.Mvc;
using Newtonsoft.Json;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page test";
            var data = new {firstname = "test", lastname = "lastname"};
            string json = JsonConvert.SerializeObject(data);

            return View();
        }
    }
}