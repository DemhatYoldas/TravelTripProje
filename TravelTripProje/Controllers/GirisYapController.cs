using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c=new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var admin=c.Admins.FirstOrDefault(x=>x.Kullanici==ad.Kullanici && x.Sifre==ad.Sifre);
            if (admin!=null)
            {
                FormsAuthentication.SetAuthCookie(admin.Kullanici, false);
                Session["Kullanici"]=admin.Kullanici.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }   
    }
}