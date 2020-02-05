using _01_DAL_HotelReservationAutomation;
using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BLL_HotelReservationAutomation
{
    public class ReservationTypeBLL
    {
        ReservationTypeDAL _typeDAL;
        public ReservationTypeBLL()
        {
            _typeDAL = new ReservationTypeDAL();
        }
       
        public List<ReservationType> GetAllReservationType()
        {
            return _typeDAL.GetReservationTypes();
        }

    }
}
