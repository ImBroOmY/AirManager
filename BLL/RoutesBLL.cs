using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class RoutesBLL {
        public static void Add(Route route) {
            DAL.DAO.RouteDAO.Add(route);
        }
        public static List<DAL.DTO.RouteDTO> GetRoutes() {
            return DAL.DAO.RouteDAO.GetRoutes();
        }
    }
}
