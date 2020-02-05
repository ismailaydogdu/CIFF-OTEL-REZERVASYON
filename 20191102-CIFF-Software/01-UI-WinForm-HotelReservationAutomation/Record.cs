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
    public partial class Record : Form
    {
        public static Customer GirisYapan;
        public static Reservation rsv;
        List<ReservationType> types;
        ComplateRecord frmCompleteForm;
        ReservationTypeBLL _rsvTypeBLL;
        ReservationBLL _rsvBLL;
        CustomerBLL _CustomerBLL;
        ReservationType seciliRev;
        bool EklemeMi;

        public Record()
        {

            InitializeComponent();
            _rsvTypeBLL = new ReservationTypeBLL();
            _rsvBLL = new ReservationBLL();
            _CustomerBLL = new CustomerBLL();
        }

        private void Record_Load(object sender, EventArgs e)
        {

            EklemeMi = false;
            if (rsv == null)
            {
                rsv = new Reservation();


                EklemeMi = true;
            }
            frmCompleteForm = new ComplateRecord();
            frmCompleteForm.Owner = this;
            seciliRev = rsv.Type;
            dtpBirth.MaxDate = DateTime.Now.AddYears(-18);



            if (!EklemeMi)
            {
                FormTypeUpdate(); //Form tipini günceellemeye çevir
            }
            if (GirisYapan.FirstName != "")//Kullanıcı sisteme kayıtlı mı kontrolü
            {
                groupBox1.Visible = false;
                GirisYapanVeriDoldur();
            }
            else
            {
                txtTc.Text = GirisYapan.IdentificationNumber;
                groupBox2.Enabled = false;
            }
            if (EklemeMi)
            {
                typeDoldur();
                cmbOdaSayisi.Items.Add(1);
                cmbOdaSayisi.SelectedIndex = 0;
            }

            dtpEntry.MinDate = DateTime.Now;
            rbMan.Checked = true;

            lblTutar.Text = HesapDoldur();


        }
        void typeDoldur()
        {
            #region TypeDoldur
            types = _rsvTypeBLL.GetAllReservationType();
            cmbTypes.DataSource = types;
            cmbTypes.DisplayMember = "Description";


            #endregion
        }

        void GirisYapanVeriDoldur()
        {
            groupBox1.Enabled = false;
            txtAd.Text = GirisYapan.FirstName;
            txtSoyad.Text = GirisYapan.LastName;
            txtTc.Text = GirisYapan.IdentificationNumber;
            dtpBirth.Value = GirisYapan.BirthDate;
            if (GirisYapan.IsMale)
            {
                rbMan.Checked = true;
            }
            else
            {
                rbWoman.Checked = true;
            }
        }

        void FormTypeUpdate()
        {
            List<int> odalar = new List<int>();
            GirisYapan = rsv.Customer1;
            dtpEntry.Value = Convert.ToDateTime((rsv.EntryDate).ToString("d")).AddHours(DateTime.Now.Hour + 1);
            dtpLeaving.Value = Convert.ToDateTime((rsv.LeavingDate).ToString("d")).AddHours(DateTime.Now.Hour + 1);
            typeDoldur();
            nudKisiSayisi.Value = rsv.Details.Count();

            foreach (ReservationDetail item in rsv.Details)
            {
                odalar.Add(item.Room.RoomID);
            }
            cmbOdaSayisi.Items.Add(odalar.Distinct().Count());
            cmbOdaSayisi.SelectedIndex = 0;

            int index = seciliRev.TypeID - 1;
            cmbTypes.SelectedIndex = index;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && txtTc.Text.Length == 11)
            //{
            try
            {
                rbMan.Checked = true;
                GirisYapan.FirstName = txtAd.Text;
                GirisYapan.LastName = txtSoyad.Text;
                GirisYapan.IdentificationNumber = txtTc.Text;
                GirisYapan.BirthDate = dtpBirth.Value;
                GirisYapan.IsMale = false;
                if (rbMan.Checked)
                {
                    GirisYapan.IsMale = true;
                }
                _CustomerBLL.Add(GirisYapan);
                groupBox2.Enabled = true;
                GirisYapan.CustomerID = (_CustomerBLL.GetCustomerByTC(GirisYapan.IdentificationNumber)).CustomerID;
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz");
            //}
        }

        int kisiSayisi;
        int OdaAdet = 0;
        private void nudKisiSayisi_ValueChanged(object sender, EventArgs e)
        {
            cmbOdaSayisi.Items.Clear();
            kisiSayisi = Convert.ToInt16(nudKisiSayisi.Value);

            if (kisiSayisi % 3 == 0)
            {
                OdaAdet = kisiSayisi / 3;
            }
            else
            {
                OdaAdet = (kisiSayisi / 3) + 1;
            }

            for (int i = OdaAdet; i <= kisiSayisi && i <= 12; i++)
            {
                cmbOdaSayisi.Items.Add(i);
            }
            cmbOdaSayisi.SelectedIndex = 0;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbOdaSayisi.SelectedItem != null)
            {
                int odasayisi = _rsvBLL.GetEmptyRooms(Record.rsv.EntryDate, Record.rsv.LeavingDate).Count();
                if (odasayisi >= (int)cmbOdaSayisi.SelectedItem)
                {
                    rsv.Customer1 = GirisYapan;
                    rsv.LeavingDate = dtpLeaving.Value;
                    rsv.EntryDate = dtpEntry.Value;
                    rsv.Type = (ReservationType)cmbTypes.SelectedItem;
                    //rsv.TotalPrice = Convert.ToDecimal(lblTutar.Text);


                    frmCompleteForm.OdaSayisiKisiSayisiTut((int)nudKisiSayisi.Value, (int)cmbOdaSayisi.SelectedItem);
                    frmCompleteForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Seçilen tarihlerdeki boş oda sayısı {odasayisi} ve maksimum {odasayisi * 3} kişi kapasitededir");
                }
            }
        }
        private void cmbOdaSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTutar.Text = HesapDoldur();
        }

        private void dtpEntry_ValueChanged(object sender, EventArgs e)
        {
            dtpLeaving.MinDate = dtpEntry.Value.AddDays(1);
            lblTutar.Text = HesapDoldur();
        }

        private void dtpLeaving_ValueChanged(object sender, EventArgs e)
        {
            lblTutar.Text = HesapDoldur();
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTutar.Text = HesapDoldur();
        }

        string HesapDoldur()
        {

            rsv.Type = (ReservationType)cmbTypes.SelectedItem;
            rsv.EntryDate = dtpEntry.Value;

            rsv.LeavingDate = dtpLeaving.Value;

            kisiSayisi = (int)nudKisiSayisi.Value;

            if (cmbOdaSayisi.SelectedItem != null)
            {

                OdaAdet = (int)cmbOdaSayisi.SelectedItem;
            }
            rsv.TotalPrice = rsv.Hesapla(OdaAdet, kisiSayisi);
            return rsv.Hesapla(OdaAdet, kisiSayisi).ToString("c2");

        }

        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }
    }
}
