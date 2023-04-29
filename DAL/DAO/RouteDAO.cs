using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class RouteDAO : AirManagerContext {
        public static void Add(Route route) {
            try {
                db.Routes.InsertOnSubmit(route);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex; 
            }
        }

        public static List<RouteDTO> GetRoutes() {
            try {
                var list = (from r in db.Routes
                            join a1 in db.Airports on r.OriginAirportID equals a1.AirportID
                            join a2 in db.Airports on r.DestinationAirportID equals a2.AirportID
                            join c1 in db.Countries on a1.CountryID equals c1.CountryID
                            join c2 in db.Countries on a2.CountryID equals c2.CountryID
                            select new {
                                RouteID = r.RouteID,
                                OriginAirportID = r.OriginAirportID,
                                OriginAirportName = a1.Name,
                                OriginAirportCity = a1.City,
                                OriginAirportCountryID = a1.CountryID,
                                OriginAirportCountry = c1.Name,
                                DestinationAirportID = r.DestinationAirportID,
                                DestinationAirportName = a2.Name,
                                DestinationAirportCity = a2.City,
                                DestinationAirportCountryID = a2.CountryID,
                                DestinationAirportCountry = c2.Name,
                            }).OrderBy(x => x.RouteID).ToList();

                List<RouteDTO> routesList = new List<RouteDTO>();

                foreach (var item in list) {
                    RouteDTO dto = new RouteDTO();
                    dto.RouteID = item.RouteID;
                    dto.OriginAirportID = item.OriginAirportID;
                    dto.OriginAirportName = item.OriginAirportName;
                    dto.OriginAirportCity = item.OriginAirportCity;
                    dto.OriginAirportCountryID = item.OriginAirportCountryID;
                    dto.OriginAirportCountry = item.OriginAirportCountry;
                    dto.DestinationAirportID = item.DestinationAirportID;
                    dto.DestinationAirportName = item.DestinationAirportName;
                    dto.DestinationAirportCity = item.DestinationAirportCity;
                    dto.DestinationAirportCountryID = item.DestinationAirportCountryID;
                    dto.DestinationAirportCountry = item.DestinationAirportCountry;

                    routesList.Add(dto);
                }

                return routesList;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static void Update(Route route) {
            try {
                Route oldRoute = db.Routes.FirstOrDefault(x => x.RouteID == route.RouteID);
                oldRoute.OriginAirportID = route.OriginAirportID;
                oldRoute.DestinationAirportID = route.DestinationAirportID;
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
