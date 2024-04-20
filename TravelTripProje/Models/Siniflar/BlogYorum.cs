using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Blogdegeri { get; set; } 
        public IEnumerable<Yorumlar> Yorumdegeri { get; set; }
    }
}