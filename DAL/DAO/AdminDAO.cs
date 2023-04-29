using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class AdminDAO : AirManagerContext {
        public static List<Admin> GetAdminList() {
            try {
                return db.Admins.ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Update(Airline airline) {
            try {
                Airline oldAirline = db.Airlines.FirstOrDefault(x => x.AirlineID == airline.AirlineID);
                oldAirline.AirlineID = airline.AirlineID;
                oldAirline.Name = airline.Name;
                oldAirline.IATA = airline.IATA;
                oldAirline.ICAO = airline.ICAO;
                oldAirline.CountryID = airline.CountryID;
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
