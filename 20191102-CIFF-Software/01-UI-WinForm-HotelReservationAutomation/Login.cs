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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            _customerBLL = new CustomerBLL();
        }
        CustomerBLL _customerBLL;

        private void Login_Load(object sender, EventArgs e)
        {
            //Formun başlangıç konumu yukarı alınıyor
            this.Top -= 100;
            Record.rsv = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Timerların biri durdurulurken diğeri çalıştırılıyor
            //timerGoster.Stop();
            //if (!string.IsNullOrEmpty(msktxtTcNo.Text) && msktxtTcNo.Text.Length == 11)
            //{

            Customer c = null;
            try
            {
                c = _customerBLL.GetCustomerByTC(msktxtTcNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (c != null)
            {
                int year = DateTime.Now.Year - c.BirthDate.Year;
                int month = c.BirthDate.Month;
                int day = c.BirthDate.Day;
                if (year>18 || (year==18 && month<DateTime.Now.Month) || (year == 18 && month == DateTime.Now.Month && day-1<= DateTime.Now.Day))
                {

                    Record.GirisYapan = _customerBLL.GetCustomerByTC(msktxtTcNo.Text);
                    Secenek secenek = new Secenek();
                    Secenek.c = _customerBLL.GetCustomerByTC(msktxtTcNo.Text);
                    this.Visible = false;
                    secenek.Show();
                }
                else
                {
                    MessageBox.Show("18 yaşından küçük kişiler rezervasyon düzenleyemez");
                }

            }
            else
            {
                Customer customer = new Customer() { FirstName = "", IdentificationNumber = msktxtTcNo.Text };
                Record.GirisYapan = customer;
                Record frmRecord = new Record();
                this.Visible = false;
                frmRecord.Show();

            }
        }

        private void timerGoster_Tick(object sender, EventArgs e)
        {
            //Formun şeffalığı artırılıyor
            this.Opacity += 0.01;
            //Progress barın konumu ilerletiliyor
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
                //Formun yukarıdan uzaklığı(top değeri) artırılıyor
                this.Top++;
            }
        }

        private void timerGizle_Tick(object sender, EventArgs e)
        {

            //Formun şeffalığı azaltılıyor
            this.Opacity -= 0.01;
            //Formun yukarıdan uzaklığı(top değeri) azaltılıyor
            this.Top--;
            //Progress barın konumu geri alınıyor
            if (progressBar1.Value > 0)
                progressBar1.Value--;
            else
            {
                //Progressbar sıfırlandığında diğer forma geçiliyor
                Record recfrm = new Record();
                recfrm.Show();
                this.Hide();
                timerGizle.Stop();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
