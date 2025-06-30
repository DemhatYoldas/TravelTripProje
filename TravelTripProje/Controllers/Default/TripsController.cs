using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProje.Controllers.Default
{
    public class TripsController : Controller
    {
        // GET: Trips
        public ActionResult Index()
        {
            return View();
        }
         
        public PartialViewResult PartialTripsList()
        {
            return PartialView();
        }
        public PartialViewResult PartialJourney()
        {
            return PartialView();
        }

        public PartialViewResult PartialStory()
        {
            return PartialView();
        }   
    }
}