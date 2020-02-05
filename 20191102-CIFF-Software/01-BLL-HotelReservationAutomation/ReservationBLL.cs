using _01_DAL_HotelReservationAutomation;
using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BLL_HotelReservationAutomation
{
    public class ReservationBLL
    {
        ReservationDAL _reservationDAL;
        public ReservationBLL()
        {
            _reservationDAL = new ReservationDAL();
        }
        

        public bool add(Reservation rsv)
        {
            int result =_reservationDAL.AddReservation(rsv);
            return result > 0;
        } 

        public bool delete(int rsvID)
        {
            int result = _reservationDAL.DeleteReservation(rsvID);
            return result > 0;
        }

        public List<Rooms> GetEmptyRooms(DateTime entry,DateTime leaving)
        {
            return _reservationDAL.GetEmptyRooms(entry,leaving);
        }
        public List<Reservation> GetAllReservations()
        {
            return _reservationDAL.GetAllReservations();
        }

        public bool Update(Reservation rsv)
        {
           int result =_reservationDAL.UpdateReservation(rsv);
            return result > 0;
        }



    }
}
