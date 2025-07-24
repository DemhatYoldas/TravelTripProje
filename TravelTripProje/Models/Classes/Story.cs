using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Story
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Title3 { get; set; }
        public string Description { get; set; }

        public ICollection<Homepage> Homepages { get; set; }
        public ICollection<About> Abouts { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}