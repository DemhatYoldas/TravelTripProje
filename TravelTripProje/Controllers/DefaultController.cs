using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() 
        {
            return View();
        }

        public ActionResult Destinations()
        {
            return View();
        }

        public ActionResult FreeTravelGuides ()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    
    }
}