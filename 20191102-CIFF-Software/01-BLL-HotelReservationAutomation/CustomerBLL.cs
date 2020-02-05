using _01_DAL_HotelReservationAutomation;
using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BLL_HotelReservationAutomation
{
    public class CustomerBLL
    {
        CustomerDAL _customerDAL;
        public CustomerBLL()
        {
            _customerDAL = new CustomerDAL();
        }
        //normalde hoca exception fırlatıyor ama bize var olup olmadığı lazım olduğu için form tarafında kullanabilmek için bool olsun dedim.Bnde reservationbll de hata fırlattım.buranın sonu orası çünkü.

        public bool IsExistCustomer(string tc)
        {
            List<Customer> allCustomers = _customerDAL.GetCustomers();
            foreach (Customer item in allCustomers)
            {
                if (item.IdentificationNumber == tc)
                {
                    return true;
                }
            }

            return false;
        }

        

        void ValidationTC(string tc)
        {
            if (string.IsNullOrEmpty(tc))
            {
                throw new NotNullException();
            }
            if (tc.Length != 11)
            {
                throw new Exception("Lütfen 11 haneli Tc Kimlik numaranızı giriniz");
            }
            foreach (char item in tc)
            {
                if (!char.IsNumber(item))
                {
                    throw new Exception("Hatalı Karakter Lütfen Kimlik numaranızI giriniz ");
                }
            }
        }
        void CustomerValuesControl(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FirstName))
            {
                throw new Exception("Lütfen isminizi giriniz");
            }
            if (string.IsNullOrEmpty(customer.LastName))
            {
                throw new Exception("Lütfen soyisminizi giriniz");
            }
            if (string.IsNullOrEmpty(customer.IdentificationNumber))
            {
                throw new Exception("Lütfen Tc kimlik numaranızı giriniz");
            }
        }
        public bool Add1(Customer c)
        {
            CustomerValuesControl(c);
            int result = -1;
            if (!IsExistCustomer(c.IdentificationNumber))
            {
                result = _customerDAL.AddCustomer(c);
            }
            return result > 0;
        }
        public bool Add(Customer c)
        {
             int result = -1;
            bool varMi = IsExistCustomer(c.IdentificationNumber);
            if (varMi)
            {
                //throw new Exception("Bu Kimlik numarası ile giriş yapamazsınız");
            }
            else
            {

                CustomerValuesControl(c);
                if (!IsExistCustomer(c.IdentificationNumber))
                {
                 result = _customerDAL.AddCustomer(c);
                }
            }
            return result > 0;
        }


        public Customer GetCustomerByTC(string tc)
        {
            ValidationTC(tc);
            Customer c = _customerDAL.GetCustomerByTC(tc);
            return c;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = _customerDAL.GetCustomers();
            return customers;
        }
    }
}
