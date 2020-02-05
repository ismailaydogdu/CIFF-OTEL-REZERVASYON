using _01_DAL_HotelReservationAutomation;
using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BLL_HotelReservationAutomation
{
    public class RoomsBLL
    {
        RoomsDAL _roomsDAL;
        public RoomsBLL()
        {
            _roomsDAL = new RoomsDAL();
        }
       
        public List<Rooms> GetAllRooms()
        {
            return _roomsDAL.GetRooms();
        }
    }
}
