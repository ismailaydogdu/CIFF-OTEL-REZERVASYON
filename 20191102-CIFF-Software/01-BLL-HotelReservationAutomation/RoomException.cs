using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BLL_HotelReservationAutomation
{
    public class NotNullException : Exception
    {
        public override string Message => "Oda No Boş Geçilemez";
    }
    public class SameNameException : Exception
    {
        public override string Message => "Bu Oda Tek Kişiliktir";
    }
}
