using _01_DAL_HotelReservationAutomation;
using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BLL_HotelReservationAutomation
{
    public  class ReservationDetailBLL
    {

        ReservationDetailDAL _reservationDetailDAL;
        public ReservationDetailBLL()
        {
            _reservationDetailDAL = new ReservationDetailDAL();
        }

        public bool Delete(int rd)
        {
            int result = _reservationDetailDAL.Delete(rd);
            return result > 0;
        }

          public int Add(ReservationDetail rv)
        {
            int result = _reservationDetailDAL.Add(rv);
            return result;
        }
    }
}
