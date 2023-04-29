using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class BookingStatusDAL : AirManagerContext {
        public static List<DAL.BookingStatus> GetBookingStatuses() {
            try {
                return db.BookingStatus.ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
