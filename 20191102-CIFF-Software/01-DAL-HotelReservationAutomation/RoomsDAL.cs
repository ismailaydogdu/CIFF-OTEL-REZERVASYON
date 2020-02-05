using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DAL_HotelReservationAutomation
{
    public class RoomsDAL
    {
        SqlConnection conn;
        SqlCommand cmd;

        public RoomsDAL()
        {
            conn = new SqlConnection(Properties.Settings.Default.HRO);
        }
        
        public Rooms GetRoomId(int roomID)
        {
            Rooms room;
            cmd = new SqlCommand("Select * From Rooms where RoomID =@roomID", conn);
            cmd.Parameters.AddWithValue("@roomID", roomID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                room = new Rooms()
                {
                    RoomID = (int)reader["RoomID"],
                    RoomNumber = reader["RoomNumber"].ToString()
                };
                reader.Close();
            }
            catch (Exception ex)
            {
                room = null;
            }
            finally
            {
                conn.Close();
            }
            return room;
        }
        public List<Rooms> GetRooms()
        {
            cmd = new SqlCommand("Select * From Rooms", conn);
            List<Rooms> roomsList = new List<Rooms>();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomsList.Add(new Rooms
                    {
                        RoomID = (int)reader["RoomID"],
                        RoomNumber = reader["RoomNumber"].ToString()
                    });

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                roomsList = null;
            }
            finally
            {
                conn.Close();
            }
            return roomsList;
        }
        
    }
}
