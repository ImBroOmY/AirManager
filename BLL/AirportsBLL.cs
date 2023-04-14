﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL {
    public class AirportsBLL {
        public static void Add(Airport airport) {
            DAL.DAO.AirportDAO.Add(airport);
        }

        public static List<DAL.DTO.AirportDTO> GetAirports() {
            return DAL.DAO.AirportDAO.GetAirports();
        }
    }
}
