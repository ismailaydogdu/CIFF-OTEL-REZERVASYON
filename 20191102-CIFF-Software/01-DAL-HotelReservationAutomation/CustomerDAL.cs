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
    public class CustomerDAL
    {
        SqlConnection conn;
        SqlCommand cmd;

        public CustomerDAL()
        {
            conn = new SqlConnection(Properties.Settings.Default.HRO);
        }
        int ExecuteQuery()
        {
            int affactedRows = 0;
            try
            {
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
        public int AddCustomer(Customer c)
        {
            cmd = new SqlCommand("Insert Into Customers Values(@tc,@fname,@lname,@ismale,@birthdate)",conn);
            cmd.Parameters.AddWithValue("@fname", c.FirstName);
            cmd.Parameters.AddWithValue("@lname", c.LastName);

            cmd.Parameters.AddWithValue("@tc", c.IdentificationNumber);
            cmd.Parameters.AddWithValue("@ismale", c.IsMale);
            cmd.Parameters.AddWithValue("@birthdate", c.BirthDate);
            return ExecuteQuery();
        }

     

       

        public Customer GetCustomerByTC(string tc)
        {
            //iş kuralı 
            Customer c;
            cmd = new SqlCommand("Select * From Customers Where IdentificationNumber = @tc",conn);
            cmd.Parameters.AddWithValue("@tc", tc);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                c = new Customer()
                {
                    CustomerID = (int)reader["CustomerID"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    IdentificationNumber = (string)reader["IdentificationNumber"],
                    BirthDate = (DateTime)reader["BirthDate"],
                    IsMale = Convert.ToBoolean(reader["IsMale"]),
                };
                reader.Close();
            }
            catch (Exception)
            {
                c = null;
            }
            finally
            {
                conn.Close();
            }
            return c;
        }

        public Customer GetCustomerById(int cid)
        {
            Customer c;           
            cmd = new SqlCommand("Select * From Customers Where CustomerID = @cid",conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                c = new Customer
                {
                    CustomerID = (int)reader["CustomerID"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    IdentificationNumber = (string)reader["IdentificationNumber"],
                    BirthDate = (DateTime)reader["BirthDate"],
                    IsMale = (bool)reader["IsMale"]
                };
                reader.Close();
            }
            catch (Exception)
            {
                c = null;
            }
            finally
            {
                conn.Close();
            }
            return c;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            cmd = new SqlCommand("Select * From Customers", conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        CustomerID = (int)reader["CustomerID"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        IdentificationNumber = (string)reader["IdentificationNumber"],
                        BirthDate = (DateTime)reader["BirthDate"],
                        IsMale = (bool)reader["IsMale"]
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
                customers = null;
            }
            finally
            {
                conn.Close();
            }
            return customers;
        }

    }
}
