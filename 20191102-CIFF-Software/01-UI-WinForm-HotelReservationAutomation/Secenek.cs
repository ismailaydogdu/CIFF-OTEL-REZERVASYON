using _01_BLL_HotelReservationAutomation;
using _01_Entities_HotelReservationAutomation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_UI_WinForm_HotelReservationAutomation
{
    public partial class Secenek : Form
    {
        public Secenek()
        {
            InitializeComponent();
            _reservationBLL = new ReservationBLL();
            _reservationDetailBLL = new ReservationDetailBLL();
        }

        public static Customer c = new Customer();
        ReservationBLL _reservationBLL;
        List<Reservation> existsReservations;
        List<Reservation> reservations;
        ReservationDetailBLL _reservationDetailBLL;
        private void Secenek_Load(object sender, EventArgs e)
        {
            RefreshForm();
            dugmeMi = false;
        }
        void RefreshForm()
        {
            reservations = _reservationBLL.GetAllReservations();
            existsReservations = new List<Reservation>();
            foreach (Reservation item in reservations)
            {
                if (item.Customer1.CustomerID == c.CustomerID && item.EntryDate > DateTime.Now.AddDays(-1))
                {
                    existsReservations.Add(item);
                }
            }

            lstRezTarih.DataSource = existsReservations;
            //lstRezTarih.DisplayMember = "EntryDate" + "-" + "LeavingDate";

        }

        bool dugmeMi = false;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            dugmeMi = true;
            record.Show();
            this.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstRezTarih.SelectedIndex > -1)
            {

                int rsvID = ((Reservation)lstRezTarih.SelectedItem).ReservationID;
                _reservationDetailBLL.Delete(rsvID);
                _reservationBLL.delete(rsvID);
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Seçim Yapınız!");
            }

        }

        private void Secenek_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!dugmeMi)
            {
                Login form = new Login();
                //form = (Login)form.LoginForm();
                form.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstRezTarih.SelectedIndex > -1)
            {
                dugmeMi = true;
                Record.rsv = ((Reservation)lstRezTarih.SelectedItem);
                Record record = new Record();
                record.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Seçim Yapınız!");
            }
        }


    }
}
