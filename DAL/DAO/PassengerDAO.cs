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
    }
}
