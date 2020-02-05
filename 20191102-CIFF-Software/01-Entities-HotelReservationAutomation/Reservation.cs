using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities_HotelReservationAutomation
{
    public class Reservation
    {   //ismail görüyon mu :DDDtamam devam et çok mantıklı lan helal orda çağıracaz metotu atacaz değerleri hop total price 
        public int ReservationID { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public Customer Customer1 { get; set; }
        public ReservationType Type { get; set; }
        public decimal TotalPrice { get; set; }
        public List<ReservationDetail> Details { get; set; }
        //evet
        public decimal Hesapla(int odaSayisi = 0, int kisiSayisi = 0)
        {
            decimal toplamTutar = 0;

            decimal gunlukTutar = 0;
            while (odaSayisi>0)
            {
                if (kisiSayisi-3>=odaSayisi-1)
                {
                    kisiSayisi -= 3;
                    gunlukTutar += Type.Price*1.20m;
                }
                else if(kisiSayisi>odaSayisi)
                {
                    kisiSayisi -= 2;
                    gunlukTutar += Type.Price;
                }
                else if(kisiSayisi==odaSayisi)
                {
                    kisiSayisi--;
                    gunlukTutar += Type.Price * 0.70m;
                }
                odaSayisi--;

            }

                for (DateTime i = EntryDate; i < LeavingDate; i = i.AddDays(1))
                {
                    if (i.DayOfWeek == DayOfWeek.Friday || i.DayOfWeek == DayOfWeek.Saturday)
                    {
                        toplamTutar += gunlukTutar * 1.30m;
                    }
                    else
                    {
                        toplamTutar += gunlukTutar;
                    }

                
            }
            return toplamTutar;
        }

        public decimal SonFiyat(List<ReservationDetail> details)
        {
            decimal gunlukTutar = 0;
            List<int> rooms = new List<int>();
            foreach (ReservationDetail item in details)
            {
                if (rooms.IndexOf(item.Room.RoomID)==-1)
                {
                    rooms.Add(item.Room.RoomID);
                }
            }
            int sayac=0;

            foreach (int item in rooms)
            {
                foreach (ReservationDetail item2 in details)
                {
                    if (item==item2.Room.RoomID)
                    {
                        sayac++; 
                    }
                }
                if (sayac==1)
                {
                    gunlukTutar+= Type.Price * 0.70m;
                }
                else if (sayac==2)
                {
                    gunlukTutar += Type.Price;
                }
                else if(sayac==3)
                {
                    gunlukTutar += Type.Price*1.20m;
                }
                sayac = 0;
            }

            decimal toplamTutar=0;
            for (DateTime i = EntryDate; i < LeavingDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Friday || i.DayOfWeek == DayOfWeek.Saturday)
                {
                    toplamTutar += gunlukTutar * 1.30m;
                }
                else
                {
                    toplamTutar += gunlukTutar;
                }


            }
            return toplamTutar;
            
        }

        public override string ToString()
        {
            return EntryDate.ToShortDateString() + " - " + LeavingDate.ToShortDateString();
        }


    }
}
