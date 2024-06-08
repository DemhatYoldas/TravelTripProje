using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar=c.Blogs.ToList();
            by.Blogdegeri = c.Blogs.ToList();
            by.Blogsiralama = c.Blogs.OrderByDescending(x=>x.Tarih).Take(3).ToList();
            return View(by);
        }
       
        public ActionResult BlogDetay(int id )
        {
            by.Blogdegeri = c.Blogs.Where(x => x.ID == id).ToList();
            by.Yorumdegeri = c.yorumlars.Where(x => x.Blogid ==id).ToList();
            //var blogbul = c.Blogs.FirstOrDefault(x=>x.ID==id); 
            return View(by);
        }
        
        [HttpGet]
        public ActionResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public ActionResult YorumYap(Yorumlar y)
        {
            c.yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
} 