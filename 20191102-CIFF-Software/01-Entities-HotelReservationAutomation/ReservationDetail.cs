using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities_HotelReservationAutomation
{
    public class ReservationDetail
    {
        public int ReservationID { get; set; }
        public Customer Customer { get; set; }
        public Rooms Room { get; set; }
    }
}
