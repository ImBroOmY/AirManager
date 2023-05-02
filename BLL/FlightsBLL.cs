using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class FlightsBLL {
        public static void Add(Flight flight) {
            DAL.DAO.FlightDAO.Add(flight);
        }

        public static void Delete(int flightID) {
            DAL.DAO.FlightDAO.Delete(flightID);
        }

        public static List<DAL.DTO.FlightDTO> GetFlights() {
            return DAL.DAO.FlightDAO.GetFlights();
        }

        public static void Update(Flight flight) {
            DAL.DAO.FlightDAO.Update(flight);
        }
    }
}
