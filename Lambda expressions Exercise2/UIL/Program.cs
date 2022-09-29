using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace UIL
{
    public class Program
    {
        static void Main(string[] args)
        {
            AirTrip airtrip1 = new AirTrip
            {
                Airlines = "Indigo",
                Availability = new int[] { 2, 3, 5 },
                DepartureDateTime = DateTime.Parse("12/04/2021"),
                From = "Delhi",
                Rating = 3.5f,
                To = "Goa",
                TravelClass = new string[] { "economy", "gold", "silver" },
                TripCode = "DelhiToGoa"
            };


            AirTrip airtrip2 = new AirTrip
            {
                Airlines = "GoAir",
                Availability = new int[] { 3, 4, 5 },
                DepartureDateTime = DateTime.Parse("12/04/2022"),
                From = "Delhi",
                Rating = 4,
                To = "Kanpur",
                TravelClass = new string[] { "economy", "gold", "silver" },
                TripCode = "DelhiToKanpur"
            };

            CustomerService.TripList.Add(airtrip1);
            CustomerService.TripList.Add(airtrip2);
        }
    }
}
