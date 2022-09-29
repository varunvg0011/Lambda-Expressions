using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class CustomerService
    {
        public static Dictionary<string, int> DelayedTrips { get; set; }
        public static List<AirTrip> TripList { get; set; }


        public static Dictionary<string, float> FetchAirlinesRating()
        {
            Dictionary<string, float> dict = null;

            if (TripList != null)
            {               
                foreach(string airlineName in TripList.Select( x => x.Airlines).Distinct())
                {
                    dict.Add(airlineName, TripList.FindAll(x => x.Airlines == airlineName).Select(x => x.Rating).Average());       
                }
                return dict;
            }
            return null;
        }

        public static Dictionary<AirTrip, int> FetchDelayedTrips(int minutesDelayed)
        {
            Dictionary<AirTrip, int> delayedTrips = new Dictionary<AirTrip, int>();
            foreach (KeyValuePair<string, int> kvp in DelayedTrips.Where(x => x.Value > minutesDelayed))
            {
                delayedTrips.Add(TripList.Find(x => x.TripCode == kvp.Key), kvp.Value);
            }

            if (delayedTrips != null)
            {
                return delayedTrips;
            }

            return null;
        }

        public static string[] CheckAvailability(string from, string to, DateTime departureDateTime)
        {
            var trips = TripList.FindAll(x => x.From == from && x.To == to && x.DepartureDateTime > departureDateTime && x.Availability.Any(y => y > 0));
            if (trips.Count > 0)
            {
                return trips.Select(x => x.TripCode).ToArray();
            }
            return null;
        }

        public static int CheckAvailability(string tripCode, string travelClass)
        {
            int availability = 0;
            AirTrip airTrip = TripList.Find(x => x.TripCode == tripCode);

            if (airTrip != null)
            {
                availability = airTrip.Availability[Array.FindIndex(airTrip.TravelClass, x => x == travelClass)];
            }
            if(availability == 0)
            {
                return -1;
            }
            return availability;
        }

        static CustomerService()
        {
            DelayedTrips = new Dictionary<string, int>();
            TripList = new List<AirTrip>();
        }
    }
}



    

    //class CustomerService
    //    {
    //    //public Dictionary<string, int> DelayedTrips { get; set; }   
    //    //public List< AirTrip> TripList{ get; set; }   
    //    public CustomerService()  
    //    {     
              
    //    }   
        //public string[] CheckAvailbility(string from, string to, DateTime departureDateTime)  
        //{     
            
        //}   
        //public int CheckAvailbility(string tripCode, string travelClass)  
        //{     
        //    int availbility = 0;
        //    AirTrip airTrip = TripList.Find(x => x.TripCode == tripCode); 
        //    if (airTrip != null)     
        //    {       availbility = airTrip.Availability[Array.FindIndex(airTrip.TravelClass, x => x == travelClass)];     
        //    }     
        //    if (availbility == 0) 
        //    { 
        //        return -1; 
        //    }     
        //    return availbility;   
        //}   
        //public Dictionary<string, float> FetchAirlinesRating()   
        //{     
        //    Dictionary < string, float> airlineRatings = new Dictionary< string, float> ();
        //    if (TripList != null)     
        //    {       
        //        foreach (string airline in TripList.Select(x => x.Airlines).Distinct())
        //        {         
        //            airlineRatings.Add(airline, TripList.FindAll(x => x.Airlines == airline).Select(x => x.Rating).Average());       
        //        }       
        //        return airlineRatings;     
        //    }     
        //    return null;   
        //}   
        //public Dictionary <AirTrip, int> FetchDelayedTrips(int minutesDelayed)   
        //{     
        //    Dictionary < AirTrip, int> delayedTrips = new Dictionary< AirTrip, int> ();
        //    foreach (KeyValuePair < string, int> kvp in DelayedTrips.Where(x => x.Value > minutesDelayed))     
        //    {       
        //        delayedTrips.Add(TripList.Find(x => x.TripCode == kvp.Key), kvp.Value);     
        //    }     
        //    if (delayedTrips != null) 
        //    { 
        //        return delayedTrips; 
        //    }     
        //    return null;   
        //}

