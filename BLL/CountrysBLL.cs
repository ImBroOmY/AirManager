using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL {
    public class CountrysBLL {
        public static List<Country> GetCountries() {
            return DAL.DAO.CountryDAO.GetCountries();
        }
    }
}
