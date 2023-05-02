using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAO {
    public class PassengerDAO : AirManagerContext {
        public static void Add(Passenger passenger) {
            try {
                db.Passengers.InsertOnSubmit(passenger);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Delete(int passengerID) {
            try {
                Passenger passenger = db.Passengers.FirstOrDefault(x => x.PassengerID == passengerID);
                db.Passengers.DeleteOnSubmit(passenger);
                db.SubmitChanges();

                List<Reservation> reservations = db.Reservations.Where(x => x.PassengerID == passengerID).ToList();
                db.Reservations.DeleteAllOnSubmit(reservations);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static List<PassengerDTO> GetPassengers() {
            try {
                var list = (from p in db.Passengers
                            select new {
                                PassengerID = p.PassengerID,
                                FirstName = p.FirstName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                Email = p.Email,
                                PhoneNumber = p.PhoneNumber,
                                Username = p.Username,
                                Password = p.Password
                            }).OrderBy(x => x.PassengerID).ToList();

                List<PassengerDTO> passengersList = new List<PassengerDTO>();

                foreach (var item in list) {
                    PassengerDTO dto = new PassengerDTO();
                    dto.PassengerID = item.PassengerID;
                    dto.FirstName = item.FirstName;
                    dto.LastName = item.LastName;
                    dto.DateOfBirth = item.DateOfBirth;
                    dto.Email = item.Email;
                    dto.PhoneNumber = item.PhoneNumber;
                    dto.Username = item.Username;
                    dto.Password = item.Password;
                    passengersList.Add(dto);
                }

                return passengersList;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public static List<Passenger> Get() {
            try {
                return db.Passengers.ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Update(Passenger passenger) {
            try {
                Passenger oldPassenger = db.Passengers.FirstOrDefault(x => x.PassengerID == passenger.PassengerID);
                oldPassenger.FirstName = passenger.FirstName;
                oldPassenger.LastName = passenger.LastName;
                oldPassenger.DateOfBirth = passenger.DateOfBirth;
                oldPassenger.Email = passenger.Email;
                oldPassenger.PhoneNumber = passenger.PhoneNumber;
                oldPassenger.Username = passenger.Username;
                oldPassenger.Password = passenger.Password;
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
