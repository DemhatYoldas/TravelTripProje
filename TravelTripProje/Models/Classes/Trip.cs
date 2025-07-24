using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Trip //Geziler 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public ICollection<Story> Stories { get; set; }
        public ICollection<Journey> Journeys { get; set; }
    }
}