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

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeniblog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult BlogSil(int id) 
        {
            var blog = c.Blogs.Find(id);
            if (blog!=null)
            {
                blog.Durum = false;
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}