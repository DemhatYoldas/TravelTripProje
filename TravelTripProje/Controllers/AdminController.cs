﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
         Context c=new Context();
        public ActionResult Index()
        {
            var deger=c.Blogs.ToList();
            return View(deger);
        }

        public ActionResult YeniBlog()
        {
            return View();
        }
    }
}