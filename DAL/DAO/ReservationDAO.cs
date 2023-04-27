using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAO {
    public class ReservationDAO : AirManagerContext {
        public static void Add(Reservation reservation) {
            try {
                db.Reservations.InsertOnSubmit(reservation);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static List<ReservationDTO> GetReservations() {
            try {
                var list = (from r in db.Reservations
                            join p in db.Passengers on r.PassengerID equals p.PassengerID
                            join f in db.Flights on r.FlightID equals f.FlightID
                            join rt in db.Routes on f.RouteID equals rt.RouteID
                            join a1 in db.Airports on rt.OriginAirportID equals a1.AirportID
                            join a2 in db.Airports on rt.DestinationAirportID equals a2.AirportID
                            join c1 in db.Countries on a1.CountryID equals c1.CountryID
                            join c2 in db.Countries on a2.CountryID equals c2.CountryID
                            join s in db.BookingStatus on r.BookingStatus equals s.BookingStatusID
                            select new {
                                ReservationID = r.ReservationID,
                                FlightID = r.FlightID,
                                RouteID = f.RouteID,
                                OriginAirportID = rt.OriginAirportID,
                                OriginAirportName = a1.Name,
                                OriginAirportCity = a1.City,
                                OriginAirportCountryID = a1.CountryID,
                                OriginAirportCountry = c1.Name,
                                DestinationAirportID = rt.DestinationAirportID,
                                DestinationAirportName = a2.Name,
                                DestinationAirportCity = a2.City,
                                DestinationAirportCountryID = a2.CountryID,
                                DestinationAirportCountry = c2.Name,
                                DepartureTime = f.DepartureTime,
                                Duration = f.Duration,
                                Seats = f.Seats,
                                PassengerID = r.PassengerID,
                                PassengerFirstName = p.FirstName,
                                PassengerLastName = p.LastName,
                                PassengerDateOfBirth = p.DateOfBirth,
                                PassengerEmail = p.Email,
                                PassengerPhone = p.PhoneNumber,
                                Username = p.Username,
                                SeatNumber = r.SeatNumber,
                                Price = r.Price,
                                BookingStatus = r.BookingStatus,
                                Status = s.Status,
                            }).OrderBy(x => x.ReservationID).ToList();

                List<ReservationDTO> reservationsList = new List<ReservationDTO>();
                
                foreach (var item in list) {
                    ReservationDTO dto = new ReservationDTO();

                    dto.ReservationID = item.ReservationID;
                    dto.FlightID = item.FlightID;
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
                    dto.DepartureTime = item.DepartureTime;
                    dto.Duration = item.Duration;
                    dto.Seats = item.Seats;
                    dto.PassengerID = item.PassengerID;
                    dto.FirstName = item.PassengerFirstName;
                    dto.LastName = item.PassengerLastName;
                    dto.DateOfBirth = item.PassengerDateOfBirth;
                    dto.Email = item.PassengerEmail;
                    dto.PhoneNumber = item.PassengerPhone;
                    dto.Username = item.Username;
                    dto.SeatNumber = item.SeatNumber;
                    dto.Price = item.Price;
                    dto.BookingStatus = item.BookingStatus;
                    dto.Status = item.Status;

                    reservationsList.Add(dto);
                }

                return reservationsList;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
