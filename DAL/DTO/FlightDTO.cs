using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO {
    public class FlightDTO {
        public int FlightID { get; set; }
        public string FlightNumber { get; set; }
        public int RouteID { get; set; }
        public int OriginAirportID { get; set; }
        public string OriginAirportName { get; set; }
        public string OriginAirportCity { get; set; }
        public string OriginAirportCountryID { get; set; }
        public string OriginAirportCountry { get; set; }
        public int DestinationAirportID { get; set; }
        public string DestinationAirportName { get; set; }
        public string DestinationAirportCity { get; set; }
        public string DestinationAirportCountryID { get; set; }
        public string DestinationAirportCountry { get; set; }
        public int AirlineID { get; set; }
        public string AirlineName { get; set; }
        public DateTime DepartureTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int Seats { get; set; }
        public string toString {
            get {
                return FlightNumber + ": " + OriginAirportName + " -> " + DestinationAirportName + " (" + DepartureTime.ToString("dd/MM/yyyy") + ")";
            }
        }
    }
}
