using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DAL_HotelReservationAutomation
{
    public class ReservationTypeDAL
    {
        SqlConnection conn;
        SqlCommand cmd;

        public ReservationTypeDAL()
        {
            conn = new SqlConnection(Properties.Settings.Default.HRO);
        }
       
        public ReservationType GetTypeID(int typeID)
        {
            ReservationType type;
            cmd = new SqlCommand("Select * From ReservationType Where TypeID = @typeid",conn);
            cmd.Parameters.AddWithValue("@typeid", typeID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                type = new ReservationType()
                {
                    TypeID = (int)reader["TypeID"],
                    Name = reader["Name"].ToString(),
                    Description =reader["Description"].ToString(),
                    Price = (decimal)reader["Price"]
                };
                reader.Close();
            }
            catch (Exception ex)
            {
                type = null;
            }
            finally
            {
                conn.Close();
            }
            return type;

        }

        public List<ReservationType> GetReservationTypes()
        {
            cmd = new SqlCommand("Select * From ReservationType ",conn);
            List<ReservationType> typeList = new List<ReservationType>();
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    typeList.Add(new ReservationType
                    {
                        TypeID = (int)reader["TypeID"],
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                        Price = (decimal)reader["Price"]
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                typeList = null;
            }
            finally
            {
                conn.Close();
            }
            return typeList;

        }
    }
}
