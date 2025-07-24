using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProje.Controllers.Default
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialOurBlog()
        {
            return PartialView();
        }

        public PartialViewResult PartialBlogDetails()
        {
            return PartialView();
        }

        public PartialViewResult PartialBlogComment()
        {
            return PartialView();
        }
    }
}