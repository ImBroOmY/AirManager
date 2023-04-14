using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL {
    public class AirlinesBLL {
        public static void Add(Airline airline) {
            DAL.DAO.AirlineDAO.Add(airline);
        }

        public static List<AirlineDTO> GetAirlines() {
            return DAL.DAO.AirlineDAO.GetAirlines();
        }
    }
}
