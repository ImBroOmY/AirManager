﻿using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAO {
    public class FlightDAO : AirManagerContext {
        public static void Add(Flight flight) {
            try {
                db.Flights.InsertOnSubmit(flight);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Delete(int flightID) {
            try {
                Flight flight = db.Flights.FirstOrDefault(x => x.FlightID == flightID);
                db.Flights.DeleteOnSubmit(flight);
                db.SubmitChanges();

                List<Reservation> reservations = db.Reservations.Where(x => x.FlightID == flightID).ToList();
                db.Reservations.DeleteAllOnSubmit(reservations);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static List<FlightDTO> GetFlights() {
            try {
                var list = (from f in db.Flights
                            join r in db.Routes on f.RouteID equals r.RouteID
                            join a1 in db.Airports on r.OriginAirportID equals a1.AirportID
                            join a2 in db.Airports on r.DestinationAirportID equals a2.AirportID
                            join a in db.Airlines on f.AirlineID equals a.AirlineID
                            join c1 in db.Countries on a1.CountryID equals c1.CountryID
                            join c2 in db.Countries on a2.CountryID equals c2.CountryID
                            select new {
                                FlightID = f.FlightID,
                                FlightNumber = f.FlightNumber,
                                RouteID = f.RouteID,
                                OriginAirportID = r.OriginAirportID,
                                OriginAirportName = a1.Name,
                                OriginAirportCity = a1.City,
                                OriginAirportCountryID = a1.CountryID,
                                OriginAirportCountry = c1.Name,
                                DestinationAirportID = r.DestinationAirportID,
                                DestinationAirportName = a2.Name,
                                DestinationAirportCity = a2.City,
                                DestinationAirportCountryID = a2.CountryID,
                                DestinationAirportCountry = c2.Name,
                                AirlineID = f.AirlineID,
                                AirlineName = a.Name,
                                DepartureTime = f.DepartureTime,
                                Duration = f.Duration,
                                Seats = f.Seats,
                            }).OrderBy(x => x.FlightID).ToList();

                List<FlightDTO> flightsList = new List<FlightDTO>();

                foreach (var item in list) {
                    FlightDTO dto = new FlightDTO();

                    dto.FlightID = item.FlightID;
                    dto.FlightNumber = item.FlightNumber;
                    dto.RouteID = item.RouteID;
                    dto.OriginAirportID = item.OriginAirportID;
                    dto.OriginAirportName = item.OriginAirportName;
                    dto.OriginAirportCity = item.OriginAirportCity;
                    dto.OriginAirportCountryID = item.OriginAirportCountryID;
                    dto.OriginAirportCountry = item.OriginAirportCountry;
                    dto.DestinationAirportID = item.DestinationAirportID;
                    dto.DestinationAirportName = item.DestinationAirportName;
                    dto.DestinationAirportCity = item.DestinationAirportCity;
                    dto.DestinationAirportCountryID = item.DestinationAirportCountryID;
                    dto.DestinationAirportCountry = item.DestinationAirportCountry;
                    dto.AirlineID = item.AirlineID;
                    dto.AirlineName = item.AirlineName;
                    dto.DepartureTime = item.DepartureTime;
                    dto.Duration = item.Duration;
                    dto.Seats = item.Seats;

                    flightsList.Add(dto);
                }

                return flightsList;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Update(Flight flight) {
            try {
                Flight oldFlight = db.Flights.FirstOrDefault(x => x.FlightID == flight.FlightID);
                oldFlight.FlightNumber = flight.FlightNumber;
                oldFlight.RouteID = flight.RouteID;
                oldFlight.AirlineID = flight.AirlineID;
                oldFlight.DepartureTime = flight.DepartureTime;
                oldFlight.Duration = flight.Duration;
                oldFlight.Seats = flight.Seats;
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
