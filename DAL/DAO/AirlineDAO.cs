using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class AirlineDAO : AirManagerContext {
        public static void Add(Airline airline) {
            try {
                db.Airlines.InsertOnSubmit(airline);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static List<AirlineDTO> GetAirlines() {
            try {
                var list = (from a in db.Airlines
                            join c in db.Countries on a.CountryID equals c.CountryID
                            select new {
                                AirlineID = a.AirlineID,
                                Name = a.Name,
                                IATA = a.IATA,
                                ICAO = a.ICAO,
                                CountryID = a.CountryID,
                                CountryName = c.Name,
                            }).OrderBy(x => x.Name).ToList();

                List<AirlineDTO> airlinesList = new List<AirlineDTO>();

                foreach (var item in list) {
                    AirlineDTO dto = new AirlineDTO();

                    dto.AirlineID = item.AirlineID;
                    dto.Name = item.Name;
                    dto.IATA = item.IATA;
                    dto.ICAO = item.ICAO;
                    dto.CountryID = item.CountryID;
                    dto.CountryName = item.CountryName;

                    airlinesList.Add(dto);
                }

                return airlinesList;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
