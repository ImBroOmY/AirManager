using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class ReservationsBLL {
        public static void Add(Reservation reservation) {
            DAL.DAO.ReservationDAO.Add(reservation);
        }
        public static List<DAL.DTO.ReservationDTO> GetReservations() {
            return DAL.DAO.ReservationDAO.GetReservations();
        }

        public static void Update(Reservation reservation) {
            DAL.DAO.ReservationDAO.Update(reservation);
        }
    }
}
