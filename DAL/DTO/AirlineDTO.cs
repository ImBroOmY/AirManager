using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO {
    public class AirlineDTO {
        public int AirlineID { get; set; }
        public string Name { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }
        public string CountryID { get; set; }
        public string CountryName { get; set; }
    }
}
