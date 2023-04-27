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
        public static List<DAL.DTO.FlightDTO> GetFlights() {
            return DAL.DAO.FlightDAO.GetFlights();
        }
    }
}
