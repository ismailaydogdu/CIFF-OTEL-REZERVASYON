using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities_HotelReservationAutomation
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerID { get; set; }
        public string IdentificationNumber { get; set; }
        public bool IsMale { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
