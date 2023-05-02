using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class PassengersBLL {
        public static void Add(Passenger passenger) {
            DAL.DAO.PassengerDAO.Add(passenger);
        }

        public static void Delete(int passengerID) {
            DAL.DAO.PassengerDAO.Delete(passengerID);
        }

        public static List<DAL.DTO.PassengerDTO> GetPassengers() {
            return DAL.DAO.PassengerDAO.GetPassengers();
        }

        public static void Update(Passenger passenger) {
            DAL.DAO.PassengerDAO.Update(passenger);
        }
        public static int CheckAccount(Passenger passenger) {
            // 0: account not created
            // 1: username already exists
            // 2: account already created

            List<Admin> admins = DAL.DAO.AdminDAO.GetAdminList();
            foreach (Admin a in admins) {
                if (a.Username == passenger.Username) {
                    return 1;
                }
            }

            List<Passenger> passengers = DAL.DAO.PassengerDAO.Get();
            foreach (Passenger p in passengers) {
                if (p.Username == passenger.Username) {
                    return 1;
                }
                if (p.FirstName == passenger.FirstName && p.LastName == passenger.LastName && p.DateOfBirth == passenger.DateOfBirth) {
                    if (p.Username != null) {
                        return 2;
                    }
                }
            }
            return 0;
        }
        public static void CreateAccount(Passenger passenger) {
            List<Passenger> passengers = DAL.DAO.PassengerDAO.Get();
            foreach (Passenger p in passengers) {
                if (p.FirstName == passenger.FirstName && p.LastName == passenger.LastName && p.DateOfBirth == passenger.DateOfBirth) {
                    if (p.Username == null) {
                        passenger.PassengerID = p.PassengerID;
                        DAL.DAO.PassengerDAO.Update(passenger);
                        return;
                    }
                }
            }
            DAL.DAO.PassengerDAO.Add(passenger);
        }
    }
}
