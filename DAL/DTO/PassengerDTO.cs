using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO {
    public class PassengerDTO {
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string toString {
            get {
                return PassengerID.ToString() + ": " + FirstName + " " + LastName + " " + DateOfBirth.ToString("dd/MM/yyyy");
            }
        }
    }
}
