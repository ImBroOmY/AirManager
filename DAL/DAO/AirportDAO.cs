using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class AirportDAO : AirManagerContext {
        public static void Add(Airport airport) {
            try {
                db.Airports.InsertOnSubmit(airport);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static List<DAL.DTO.AirportDTO> GetAirports() {
            try {
                var list = (from a in db.Airports
                            join c in db.Countries on a.CountryID equals c.CountryID
                            select new {
                                AirportID = a.AirportID,
                                Name = a.Name,
                                IATA = a.IATA,
                                ICAO = a.ICAO,
                                City = a.City,
                                CountryID = a.CountryID,
                                CountryName = c.Name,
                                Latitude = a.Latitude,
                                Longitude = a.Longitude,
                            }).OrderBy(x => x.Name).ToList();

                List<AirportDTO> airportsList = new List<AirportDTO>();
                foreach (var item in list) {
                    AirportDTO dto = new AirportDTO();
                    dto.AirportID = item.AirportID;
                    dto.Name = item.Name;
                    dto.IATA = item.IATA;
                    dto.ICAO = item.ICAO;
                    dto.City = item.City;
                    dto.CountryID = item.CountryID;
                    dto.CountryName = item.CountryName;
                    dto.Latitude = item.Latitude;
                    dto.Longitude = item.Longitude;

                    airportsList.Add(dto);
                }

                return airportsList;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
