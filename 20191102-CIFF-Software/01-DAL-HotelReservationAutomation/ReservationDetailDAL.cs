using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DAL_HotelReservationAutomation
{
    public class ReservationDetailDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        CustomerDAL _customerDAL;
        RoomsDAL _roomDAL;

        public ReservationDetailDAL()
        {
            conn = new SqlConnection(Properties.Settings.Default.HRO);
            _customerDAL = new CustomerDAL();
            _roomDAL = new RoomsDAL();
        }
        public int Add(ReservationDetail rd)
        {
            cmd = new SqlCommand("INSERT INTO ReservationDetails VALUES(@ReservationID,@CustomerID,@RoomID)", conn);
            AddParametersToCommand(rd);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;               
        }
        void AddParametersToCommand(ReservationDetail rd)
        {
            cmd.Parameters.AddWithValue("@ReservationID", rd.ReservationID);
            cmd.Parameters.AddWithValue("@CustomerID", rd.Customer.CustomerID);
            cmd.Parameters.AddWithValue("@RoomID", rd.Room.RoomID);
           
        }

        

        public int Delete(int ReservationID)
        {
            cmd = new SqlCommand("DELETE FROM ReservationDetails WHERE ReservationID=@id", conn);
            cmd.Parameters.AddWithValue("@id", ReservationID);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }


       


        public List<ReservationDetail> GetReservationID(int ReservationID)
        {
            List<ReservationDetail> userList = new List<ReservationDetail>();
            cmd = new SqlCommand("Select * From ReservationDetails Where ReservationID=@ReservationID", conn);
            cmd.Parameters.Add("@ReservationID", ReservationID);
            ReservationDetail currentUser = null;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                currentUser = new ReservationDetail()
                {
                    ReservationID = reader.GetInt32(0),
                    Customer = _customerDAL.GetCustomerById((int)reader["CustomerID"]),
                    Room = _roomDAL.GetRoomId((int)reader["RoomID"])

                };
                userList.Add(currentUser);
            }
            reader.Close();
            return userList;

        }

    }
}
