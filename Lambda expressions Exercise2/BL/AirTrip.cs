using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AirTrip
    {
        public string Airlines { get; set; }
        public int[] Availability { get; set; }
        public DateTime DepartureDateTime { get; set; }

        public string From { get; set; }
        public float Rating { get; set; }
        public string To { get; set; }

        public string[] TravelClass { get; set; }
        public string TripCode { get; set; }

    }
}
