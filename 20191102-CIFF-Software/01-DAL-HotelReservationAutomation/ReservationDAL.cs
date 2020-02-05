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
    public class ReservationDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        CustomerDAL _customerDAL;
        ReservationDetailDAL _rsvDetailDAL;
        ReservationTypeDAL _rsvTypeDAL;

        public ReservationDAL()
        {
            conn = new SqlConnection(Properties.Settings.Default.HRO);
            _customerDAL = new CustomerDAL();
            _rsvDetailDAL = new ReservationDetailDAL();
            _rsvTypeDAL = new ReservationTypeDAL();
        }

        int ExecuteQuery()
        {
            int affactedRows = 0;
            try
            {
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    affactedRows = cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                affactedRows = -1;
            }
            finally
            {
                conn.Close();
            }
            return affactedRows;
        }

        void AddParamaters(Reservation rsv)
        {
            //cmd.Parameters.AddWithValue("@rid", rsv.ReservationID);
            cmd.Parameters.AddWithValue("@edtp", rsv.EntryDate);
            cmd.Parameters.AddWithValue("@ldtp", rsv.LeavingDate);
            cmd.Parameters.AddWithValue("@cid", rsv.Customer1.CustomerID);
            cmd.Parameters.AddWithValue("@tid", rsv.Type.TypeID);
            cmd.Parameters.AddWithValue("@ttp", rsv.TotalPrice);
        }

        public int AddReservation(Reservation rsv)
        {
            cmd = new SqlCommand("Insert Into Reservations Values(@edtp,@ldtp,@cid,@tid,@ttp)", conn);
            AddParamaters(rsv);
            return ExecuteQuery();
        }

       

        public int DeleteReservation(int rsvID)
        {
            cmd = new SqlCommand("Delete From Reservations Where ReservationID = @rsvID", conn);
            cmd.Parameters.AddWithValue("@rsvID", rsvID);
            return ExecuteQuery();
        }
     

        //form tarafında kullanıcı kayıtları doldurduğunda rsvnin içinde Customer tipine property gelecek ve onun CustomerID sine göreupdate yapacak.
        //guncelleme işlemi olsun mu olursa formu nasıl olacak 
        public int UpdateReservation(Reservation rsv)
        {
            cmd = new SqlCommand("Update Reservations Set EntryDate = @edtp,ReleaseDate = @ldtp,CustomerID = @cid,TypeID = @tid, TotalPrice=@ttp Where ReservationID = @rid", conn);
            cmd.Parameters.AddWithValue("@rid", rsv.ReservationID);
            AddParamaters(rsv);
            return ExecuteQuery();
        }

        //kullanıcıdan gelen tarihe göre oda noları döndürme //bu ismailin dalda daha iyi olur.

        public List<Reservation> GetAllReservations()
        {
            int tempID = -1;
            List<Reservation> allReservations = new List<Reservation>();
            
            cmd = new SqlCommand("Select * From Reservations", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tempID = (int)reader["CustomerID"];
                Customer c = _customerDAL.GetCustomerById(tempID);
                //Convert.ToDateTime((Convert.ToDateTime
                allReservations.Add(new Reservation
                {
                    ReservationID = (int)reader["ReservationID"],
                    EntryDate = (DateTime)reader["EntryDate"],
                    LeavingDate = (DateTime)reader["ReleaseDate"],
                    TotalPrice = (decimal)reader["TotalPrice"],
                    Customer1 = c,
                    Details = _rsvDetailDAL.GetReservationID((int)reader["ReservationID"]),
                    Type = _rsvTypeDAL.GetTypeID((int)reader["TypeID"]),
                });
            }
            return allReservations;

        }

        Reservation rsv;
       

     
        public List<Rooms> GetEmptyRooms(DateTime giris, DateTime cikis)
        {
            List<Rooms> rooms = new List<Rooms>();
           
            
            cmd = new SqlCommand(@"Select * From Rooms
                                 Where RoomID NOT IN((Select RoomID From Reservations r JOIN ReservationDetails rd ON r.ReservationID = rd.ReservationID
                           Where EntryDate >= @giris or ReleaseDate >= @cikis))", conn);

            cmd.Parameters.AddWithValue("@giris", giris.AddDays(-1));
            cmd.Parameters.AddWithValue("@cikis", cikis.AddDays(-1));
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                rooms.Add(new Rooms()
                {
                    RoomID = (int)reader[0],
                    RoomNumber = reader[1].ToString()
                });
            }
            reader.Close();
            conn.Close();
            return rooms;
        }

    }
}
