﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Book()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult Check()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}