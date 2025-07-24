using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Journey // Gezi detayı
    {
        public int Id { get; set; }
        public string MainTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public DateTime TravelDate { get; set; }
        public string AddedBy { get; set; }

        // İlişkiler
        public ICollection<Homepage> Homepages { get; set; }
        public ICollection<Trip> Trips { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}