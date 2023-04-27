using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO {
    public class ReservationDTO {
        public int ReservationID { get; set; }
        public int FlightID { get; set; }
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
        public DateTime DepartureTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int Seats { get; set; }
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int SeatNumber { get; set; }
        public double Price { get; set; }
        public int BookingStatus { get; set; }
        public string Status { get; set; }
    }
}
