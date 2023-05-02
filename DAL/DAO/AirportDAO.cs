using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class AirportDAO : AirManagerContext {
        public static void Add(Airport airport) {
            try {
                db.Airports.InsertOnSubmit(airport);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Delete(int airportID) {
            try {
                Airport airport = db.Airports.FirstOrDefault(x => x.AirportID == airportID);
                db.Airports.DeleteOnSubmit(airport);
                db.SubmitChanges();

                List<Route> routes = db.Routes.Where(x => x.OriginAirportID == airportID || x.DestinationAirportID== airportID).ToList();
                db.Routes.DeleteAllOnSubmit(routes);
                db.SubmitChanges();

                foreach (Route route in routes) {
                    List<Flight> flights = db.Flights.Where(x => x.RouteID == route.RouteID).ToList();
                    db.Flights.DeleteAllOnSubmit(flights);
                    db.SubmitChanges();

                    foreach(Flight flight in flights) {
                        List<Reservation> reservations = db.Reservations.Where(x => x.FlightID == flight.FlightID).ToList();
                        db.Reservations.DeleteAllOnSubmit(reservations);
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static List<AirportDTO> GetAirports() {
            try {
                var list = (from a in db.Airports
                            join c in db.Countries on a.CountryID equals c.CountryID
                            select new {
                                AirportID = a.AirportID,
                                Name = a.Name,
                                IATA = a.IATA,
                                ICAO = a.ICAO,
                                City = a.City,
                                CountryID = a.CountryID,
                                CountryName = c.Name,
                                Latitude = a.Latitude,
                                Longitude = a.Longitude,
                            }).OrderBy(x => x.Name).ToList();

                List<AirportDTO> airportsList = new List<AirportDTO>();

                foreach (var item in list) {
                    AirportDTO dto = new AirportDTO();
                    dto.AirportID = item.AirportID;
                    dto.Name = item.Name;
                    dto.IATA = item.IATA;
                    dto.ICAO = item.ICAO;
                    dto.City = item.City;
                    dto.CountryID = item.CountryID;
                    dto.CountryName = item.CountryName;
                    dto.Latitude = item.Latitude;
                    dto.Longitude = item.Longitude;

                    airportsList.Add(dto);
                }

                return airportsList;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Update(Airport airport) {
            try {
                Airport oldAirport = db.Airports.FirstOrDefault(x => x.AirportID == airport.AirportID);
                oldAirport.Name = airport.Name;
                oldAirport.IATA = airport.IATA;
                oldAirport.ICAO = airport.ICAO;
                oldAirport.City = airport.City;
                oldAirport.CountryID = airport.CountryID;
                oldAirport.Latitude = airport.Latitude;
                oldAirport.Longitude = airport.Longitude;
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
