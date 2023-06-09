﻿using DAL.DTO;
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

        public static void Delete(int airlineID) {
            DAL.DAO.AirlineDAO.Delete(airlineID);
        }

        public static List<AirlineDTO> GetAirlines() {
            return DAL.DAO.AirlineDAO.GetAirlines();
        }

        public static void Update(Airline airline) {
            DAL.DAO.AdminDAO.Update(airline);
        }
    }
}
