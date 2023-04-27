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
        public static List<DAL.DTO.PassengerDTO> GetPassengers() {
            return DAL.DAO.PassengerDAO.GetPassengers();
        }
    }
}
