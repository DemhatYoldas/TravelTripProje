﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList(); 
            return View(degerler);
        }    

        public PartialViewResult partial1()
        {
            var degeler =c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();   
            return PartialView(degeler);
        }
    }
}