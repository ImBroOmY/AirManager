using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL {
    public class BookingStatusesBLL {
        public static List<BookingStatus> GetBookingStatuses() {
            return DAL.DAO.BookingStatusDAL.GetBookingStatuses();
        }
    }
}
