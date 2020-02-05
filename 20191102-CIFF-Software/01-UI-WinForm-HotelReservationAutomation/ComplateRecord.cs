using _01_BLL_HotelReservationAutomation;
using _01_DAL_HotelReservationAutomation;
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
    public partial class ComplateRecord : Form
    {
        public ComplateRecord()
        {
            InitializeComponent();
            _reservationBLL = new ReservationBLL();
            _roomsBLL = new RoomsBLL();
            _customerBLL = new CustomerBLL();
            _reservationDetailBLL = new ReservationDetailBLL();
            yedek = new List<ReservationDetail>();
        }

        int kisiSayisi = 0;
        int odaSayisi = 0;

        public void OdaSayisiKisiSayisiTut(int KisiSayisi, int OdaSayisi)
        {
            kisiSayisi = KisiSayisi;
            odaSayisi = OdaSayisi;
        } // Oda ve Kisi Sayılarını Record Formundan Alma İşlemi


        RoomsBLL _roomsBLL;
        ReservationBLL _reservationBLL;
        Record frmMain;
        List<Rooms> Emptyrooms;
        CustomerBLL _customerBLL;
        ReservationDetailBLL _reservationDetailBLL;
        List<ReservationDetail> yedek;
        bool OdaDolduMu = false;
        bool KisiDolduMu = false;
        bool GuncelemeMi = false;
        bool butonaBasildiMi = false;

        private void ComplateRecord_Load(object sender, EventArgs e)
        {


            frmMain = (Record)this.Owner;
            label14.Text = kisiSayisi.ToString();
            label15.Text = odaSayisi.ToString();
            KisiBilgileriDoldur();

            gbZiyaretciDetay.Enabled = false;

            if (Record.rsv.Details != null)
            {
                FormTypeUpdate();
            }
            OdaSayiKontrol();
            KisiSayiKontrol();
            ButtonlarGetir();
            AddEnabledKontrol();
        }

        void FormTypeUpdate()
        {
            if (Record.rsv.Details.Count > 0)
            {
                GuncelemeMi = true;
                btnRezervasyonAdd.Text = "Guncelle";
                _reservationDetailBLL.Delete(Record.rsv.ReservationID);
                detay = Record.rsv.Details;
                yedek = Record.rsv.Details;
                Listele();
                if (kisiSayisi < detay.Count)
                {
                    btnZiyaretciKaydet.Enabled = false;
                    btnRezervasyonAdd.Enabled = false;
                }
            }
        }
        void KisiBilgileriDoldur()
        {
            txtTc.Text = Record.GirisYapan.IdentificationNumber;
            txtAd.Text = Record.GirisYapan.FirstName;
            txtSoyad.Text = Record.GirisYapan.LastName;
            dtpDogum.Value = Record.GirisYapan.BirthDate;
            rbKadin.Checked = true;
            if (Record.GirisYapan.IsMale)
            {
                rbErkek.Checked = true;
            }
        }
        void ButtonlarGetir()
        {

            flowLayoutPanel1.Controls.Clear();
            Emptyrooms = _reservationBLL.GetEmptyRooms(Record.rsv.EntryDate, Record.rsv.LeavingDate);
            List<Rooms> rooms = _roomsBLL.GetAllRooms();
            Button btn;

            foreach (Rooms item in rooms)
            {
                btn = new Button();
                btn.Text = item.RoomNumber;
                btn.Tag = item;
                btn.Width = flowLayoutPanel1.Width / 5;
                btn.Height = btn.Width;
                btn.Click += new EventHandler(btnOdaNo_Click);
                if (!EmptyIndexOf(item))
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = Color.Green;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        } //Boş Odaları Getirme

        private void btnOdaNo_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = ((Button)sender).Text;
        }  //Oda Seçme

        bool EmptyIndexOf(Rooms rooms)
        {
            foreach (Rooms item in Emptyrooms)
            {
                if (item.RoomID == rooms.RoomID)
                {
                    return true;
                }
            }
            return false;
        }  //Oda BoşMu Kontrolü


        void Temizle()
        {
            foreach (Control item in gbZiyaretciDetay.Controls)
            {

                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is DateTimePicker)
                {
                    item.Text = DateTime.Now.ToString();
                }

            }

        }  //Kimlik Bilgilerini Temizle
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            gbZiyaretciDetay.Enabled = false;
        }

        List<string> SeciliOdalar = new List<string>();
        private void btnZiyaretciKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOdaNo.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && txtTc.Text.Length == 11)
            {
                foreach (char item in txtTc.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        MessageBox.Show("Hatalı değer TC Kimlik no sunu eksiksiz giriniz");
                        return;
                    }

                }
                DetayOlustur();
                Listele();
                Temizle();
                txtTc.Enabled = true;
                OdaSayiKontrol();
                KisiSayiKontrol();
                AddEnabledKontrol();
                txtTc.Text = "";
            }
            else
            {
                MessageBox.Show("Kişisel bilgileri ve oda numarasını eksiksiz giriniz!");
            }
        }  //Ziyaretci Ekleme

        List<ReservationDetail> detay = new List<ReservationDetail>(); //Ziyaretcileri Sakladığımız Liste

        private void btnRezervasyonAdd_Click(object sender, EventArgs e)
        {
            butonaBasildiMi = true;
            if (GuncelemeMi)
            {
                Record.rsv.Details = detay;
                bool check = UpdateToDataBase();
                if (check)
                {
                    MessageBox.Show("Guncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Guncelleme Başarısız");
                }

            }
            else
            {
                Record.rsv.Details = detay;
                AddToDataBase();
                MessageBox.Show("Kayıt Başarılı");
            }

            Record.GirisYapan = null;
            Secenek.c = null;
            this.Close();

        } //Rezervasyonu Tamamla


        void Listele()
        {
            lstDetails.Items.Clear();
            ListViewItem lvi;
            foreach (ReservationDetail item in detay)
            {
                lvi = new ListViewItem(item.Customer.FirstName + " " + item.Customer.LastName);
                lvi.SubItems.Add(item.Room.RoomNumber);
                lstDetails.Items.Add(lvi);

            }
        }  //Ziyaretcileri Listele


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDetails.SelectedIndices.Count > 0)
            {
            int index = lstDetails.SelectedItems[0].Index;

                int i = 0;
                foreach (string item in SeciliOdalar)
                {
                    if (item == detay[index].Room.RoomNumber)
                    {
                        SeciliOdalar.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                detay.RemoveAt(index);
                Listele();
                btnZiyaretciKaydet.Enabled = true;
                ButtonlarGetir();
                OdaSayiKontrol();
                KisiSayiKontrol();
                AddEnabledKontrol();
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız!");
            }

        }  //Ziyaretci sil

        public void AddToDataBase()
        {
            foreach (ReservationDetail item in Record.rsv.Details)
            {
                _customerBLL.Add1(item.Customer);
                item.Customer.CustomerID = _customerBLL.GetCustomerByTC(item.Customer.IdentificationNumber).CustomerID;
            }
            _reservationBLL.add(Record.rsv);
            List<Reservation> reservations = _reservationBLL.GetAllReservations();
            int rsvId = reservations[reservations.Count - 1].ReservationID;
            foreach (ReservationDetail item in Record.rsv.Details)
            {
                item.ReservationID = rsvId;
                _reservationDetailBLL.Add(item);
            }
        }  //Rezervasyonu database kaydet

        public bool UpdateToDataBase()
        {
            foreach (ReservationDetail item in Record.rsv.Details)
            {
                _customerBLL.Add(item.Customer);
                item.Customer.CustomerID = _customerBLL.GetCustomerByTC(item.Customer.IdentificationNumber).CustomerID;


            }
            bool check = _reservationBLL.Update(Record.rsv);
            List<Reservation> reservations = _reservationBLL.GetAllReservations();
            int rsvId = reservations[reservations.Count - 1].ReservationID;
            foreach (ReservationDetail item in Record.rsv.Details)
            {
                item.ReservationID = rsvId;
                _reservationDetailBLL.Add(item);
            }
            return check;
        } //Rezervasyon Guncelleme işlemlerini yapıyor

        private void ComplateRecord_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (GuncelemeMi && !butonaBasildiMi)
            {
                foreach (ReservationDetail item in yedek)
                {
                    item.ReservationID = Record.rsv.ReservationID;
                    _reservationDetailBLL.Add(item);
                }
            }  //Guncelle butonuna basılmadan program kapatılırsa yedekdeki detayları db ye tekrar ekliyor
            Login form = new Login();
            //form = (Login)form.LoginForm();
            form.Visible = true;

        }

        void KisiSayiKontrol()
        {
            if (kisiSayisi < detay.Count)
            {
                lblKisiSayiUyarisi.Text = "Kişi Sayısı Fazla Lütfen Siliniz";
                KisiDolduMu = false;
            }
            else if (kisiSayisi > detay.Count)
            {
                lblKisiSayiUyarisi.Text = "Kisi Sayısı Eksik Lütfen Ekleme İşlemi Yapınız";
                KisiDolduMu = false;
            }
            else
            {
                lblKisiSayiUyarisi.Text = "";
                KisiDolduMu = true;
            }
        }  //Detay Listesini eklediğimiz Kişi sayısı ile Record Formundan gelen kişi sayısını karşılaştırıyor ve mesaj veriyor

        void OdaSayiKontrol()
        {
            List<int> odalar = new List<int>();
            foreach (ReservationDetail item in detay)
            {
                odalar.Add(item.Room.RoomID);
            }
            int kayitliOdaSayisi = odalar.Distinct().Count();
            if (kayitliOdaSayisi > odaSayisi)
            {
                lblOdaSayiUyari.Text = "Oda Sayısı Fazla Lütfen Kayıt Siliniz";
                OdaDolduMu = false;
            }
            else if (kayitliOdaSayisi < odaSayisi)
            {
                lblOdaSayiUyari.Text = "Oda Sayısı Eksik Lütfen Oda Ekleyiniz";
                OdaDolduMu = false;
            }
            else
            {
                lblOdaSayiUyari.Text = "";
                OdaDolduMu = true;
            }

        }  //Detay Listesini eklediğimiz Oda sayısı ile Record Formundan gelen oda sayısını karşılaştırıyor ve mesaj veriyor

        void DetayOlustur()
        {

            int sayac = 0;
            foreach (ReservationDetail item2 in detay)
            {
                if (item2.Room.RoomNumber == txtOdaNo.Text)
                {
                    sayac++;
                }
            }

            bool check = false;
            foreach (ReservationDetail item in detay)
            {
                if (item.Customer.IdentificationNumber == txtTc.Text)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                MessageBox.Show("Bir rezervasyonda aynı kişi birden fazla kez kayıt olamaz");
            }
            else
            {


                if (sayac == 3)
                {
                    MessageBox.Show("Bir odada üçten fazla kişi konaklayamaz !");

                }
                else
                {
                    bool cins = false;
                    if (rbErkek.Checked)
                    {
                        cins = true;
                    }
                    Customer c = new Customer()
                    {
                        IdentificationNumber = txtTc.Text,
                        FirstName = txtAd.Text,
                        LastName = txtSoyad.Text,
                        BirthDate = dtpDogum.Value,
                        IsMale = cins,
                    };
                    int roomID = 0;

                    //formdaki bilgilerle customer nesnesi oluşturma
                    //Reservasyon Detay Ekleme
                    List<Rooms> rooms = _roomsBLL.GetAllRooms();
                    foreach (Rooms item in rooms)
                    {
                        if (txtOdaNo.Text == item.RoomNumber)
                        {
                            roomID = item.RoomID;
                        }
                    }  //Oda Numarasından ID Bulma
                    detay.Add(new ReservationDetail()
                    { Customer = c, Room = new Rooms { RoomNumber = txtOdaNo.Text, RoomID = roomID } });
                }
            }



        }  //Ekrandaki Bilgiler ile Detay oluşturup listeye ekleme işlemi

        void AddEnabledKontrol()
        {
            if (KisiDolduMu && OdaDolduMu)
            {
                btnRezervasyonAdd.Enabled = true;
                lblSecimeGoreTutar.Text = "Seçilen oda dağılımına gore tutar = " + Record.rsv.SonFiyat(detay).ToString("c2");
            }
            else
            {
                btnRezervasyonAdd.Enabled = false;
            }
        }  //Oda ve Kişi sayısını kontrolü ardından Rezervasyon Kaydet veya Guncelleme Butonunun aktifliğini açıp kapatıyor

        private void txtTc_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTc.TextLength == 11)
            {

                Temizle();
                bool varMi = false;
                Customer chosenCustomer = new Customer();
                List<Customer> customers = _customerBLL.GetCustomers();
                foreach (Customer item in customers)
                {
                    if (item.IdentificationNumber == txtTc.Text)
                    {
                        chosenCustomer = item;
                        gbZiyaretciDetay.Enabled = false;
                        varMi = true;
                        txtAd.Text = chosenCustomer.FirstName;
                        txtSoyad.Text = chosenCustomer.LastName;
                        dtpDogum.Value = Convert.ToDateTime(chosenCustomer.BirthDate.ToString("d"));
                        if (item.IsMale)
                        {
                            rbErkek.Checked = true;
                        }
                        else
                            rbKadin.Checked = true;
                        break;
                    }

                }
                if (!varMi)
                {
                    gbZiyaretciDetay.Enabled = true;
                }
            }
        }
    }
}
