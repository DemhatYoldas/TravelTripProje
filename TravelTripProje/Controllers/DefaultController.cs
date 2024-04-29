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
            var degerler = c.Blogs.Take(4).ToList(); 
            return View(degerler);
        }    

        public PartialViewResult partial1()
        {
            var degeler =c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();   
            return PartialView(degeler);
        }
        public PartialViewResult partial2()
        {
            var deger = c.Blogs.Where(x=>x.ID==1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult partial3()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);
        }
    }
}