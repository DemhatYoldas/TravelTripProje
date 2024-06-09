using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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

        public ActionResult BlogGetir(int id) 
        {
            var veri = c.Blogs.Find(id);
            return View("BlogGetir",veri); 
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var update=c.Blogs.Find(b.ID);
            update.BlogImage = b.BlogImage;
            update.Baslik = b.Baslik;
            update.Tarih = b.Tarih;
            update.Aciklama = b.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Yorumlar()
        {
            var yorum = c.yorumlars.ToList();
            return View(yorum);
        }

        public ActionResult Yorumsil(int id)
        {
            var yorum = c.yorumlars.Find(id);
            if (yorum != null)
            {
                yorum.Durum = false;
                c.SaveChanges();
                return RedirectToAction("Yorumlar");
            }
            else
            {
                return View();
            }
        }

    }
}