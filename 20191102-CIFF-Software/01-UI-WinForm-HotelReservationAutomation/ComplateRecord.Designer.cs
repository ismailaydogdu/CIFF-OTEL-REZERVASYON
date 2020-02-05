namespace _01_UI_WinForm_HotelReservationAutomation
{
    partial class ComplateRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbZiyaretciDetay = new System.Windows.Forms.GroupBox();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.dtpDogum = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnZiyaretciKaydet = new System.Windows.Forms.Button();
            this.btnRezervasyonAdd = new System.Windows.Forms.Button();
            this.lblKisiSayiUyarisi = new System.Windows.Forms.Label();
            this.lblOdaSayiUyari = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.lblOdaSayi = new System.Windows.Forms.Panel();
            this.lblSecimeGoreTutar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbZiyaretciDetay.SuspendLayout();
            this.lblOdaSayi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDetails
            // 
            this.lstDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lstDetails.GridLines = true;
            this.lstDetails.HideSelection = false;
            this.lstDetails.Location = new System.Drawing.Point(9, 435);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.Size = new System.Drawing.Size(525, 112);
            this.lstDetails.TabIndex = 11;
            this.lstDetails.UseCompatibleStateImageBehavior = false;
            this.lstDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad ";
            this.columnHeader1.Width = 258;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda Numarası";
            this.columnHeader3.Width = 168;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 406);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROOMS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(514, 321);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(382, 389);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Secilen Oda Sayisi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(479, 389);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "label15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Secilen Kisi Sayisi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(479, 362);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "label14";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(394, 552);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 52);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "OdaNo :";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(237, 271);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.ReadOnly = true;
            this.txtOdaNo.Size = new System.Drawing.Size(68, 20);
            this.txtOdaNo.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "C İ F F SOFTWARE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tc Kimlik No :";
            // 
            // gbZiyaretciDetay
            // 
            this.gbZiyaretciDetay.Controls.Add(this.rbKadin);
            this.gbZiyaretciDetay.Controls.Add(this.rbErkek);
            this.gbZiyaretciDetay.Controls.Add(this.dtpDogum);
            this.gbZiyaretciDetay.Controls.Add(this.txtSoyad);
            this.gbZiyaretciDetay.Controls.Add(this.txtAd);
            this.gbZiyaretciDetay.Controls.Add(this.label11);
            this.gbZiyaretciDetay.Controls.Add(this.label9);
            this.gbZiyaretciDetay.Controls.Add(this.label8);
            this.gbZiyaretciDetay.Controls.Add(this.label7);
            this.gbZiyaretciDetay.Location = new System.Drawing.Point(35, 101);
            this.gbZiyaretciDetay.Margin = new System.Windows.Forms.Padding(2);
            this.gbZiyaretciDetay.Name = "gbZiyaretciDetay";
            this.gbZiyaretciDetay.Padding = new System.Windows.Forms.Padding(2);
            this.gbZiyaretciDetay.Size = new System.Drawing.Size(455, 146);
            this.gbZiyaretciDetay.TabIndex = 67;
            this.gbZiyaretciDetay.TabStop = false;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(278, 119);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 49;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(203, 119);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 48;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // dtpDogum
            // 
            this.dtpDogum.Location = new System.Drawing.Point(203, 74);
            this.dtpDogum.Name = "dtpDogum";
            this.dtpDogum.Size = new System.Drawing.Size(236, 20);
            this.dtpDogum.TabIndex = 47;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(203, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(236, 20);
            this.txtSoyad.TabIndex = 46;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(203, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(236, 20);
            this.txtAd.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Cinsiyeti :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Dogum Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ziyaretci Soyadı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ziyaretci Adı :";
            // 
            // btnZiyaretciKaydet
            // 
            this.btnZiyaretciKaydet.Location = new System.Drawing.Point(35, 339);
            this.btnZiyaretciKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnZiyaretciKaydet.Name = "btnZiyaretciKaydet";
            this.btnZiyaretciKaydet.Size = new System.Drawing.Size(214, 63);
            this.btnZiyaretciKaydet.TabIndex = 69;
            this.btnZiyaretciKaydet.Text = "Ziyaretciyi Kaydet";
            this.btnZiyaretciKaydet.UseVisualStyleBackColor = true;
            this.btnZiyaretciKaydet.Click += new System.EventHandler(this.btnZiyaretciKaydet_Click);
            // 
            // btnRezervasyonAdd
            // 
            this.btnRezervasyonAdd.Location = new System.Drawing.Point(302, 335);
            this.btnRezervasyonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnRezervasyonAdd.Name = "btnRezervasyonAdd";
            this.btnRezervasyonAdd.Size = new System.Drawing.Size(189, 67);
            this.btnRezervasyonAdd.TabIndex = 70;
            this.btnRezervasyonAdd.Text = "Rezervasyonu Kaydet";
            this.btnRezervasyonAdd.UseVisualStyleBackColor = true;
            this.btnRezervasyonAdd.Click += new System.EventHandler(this.btnRezervasyonAdd_Click);
            // 
            // lblKisiSayiUyarisi
            // 
            this.lblKisiSayiUyarisi.AutoSize = true;
            this.lblKisiSayiUyarisi.Location = new System.Drawing.Point(310, 408);
            this.lblKisiSayiUyarisi.Name = "lblKisiSayiUyarisi";
            this.lblKisiSayiUyarisi.Size = new System.Drawing.Size(10, 13);
            this.lblKisiSayiUyarisi.TabIndex = 71;
            this.lblKisiSayiUyarisi.Text = "-";
            // 
            // lblOdaSayiUyari
            // 
            this.lblOdaSayiUyari.AutoSize = true;
            this.lblOdaSayiUyari.Location = new System.Drawing.Point(310, 424);
            this.lblOdaSayiUyari.Name = "lblOdaSayiUyari";
            this.lblOdaSayiUyari.Size = new System.Drawing.Size(10, 13);
            this.lblOdaSayiUyari.TabIndex = 71;
            this.lblOdaSayiUyari.Text = "-";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(139, 58);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(127, 20);
            this.txtTc.TabIndex = 72;
            this.txtTc.ValidatingType = typeof(int);
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged_1);
            // 
            // lblOdaSayi
            // 
            this.lblOdaSayi.Controls.Add(this.txtTc);
            this.lblOdaSayi.Controls.Add(this.lblSecimeGoreTutar);
            this.lblOdaSayi.Controls.Add(this.lblOdaSayiUyari);
            this.lblOdaSayi.Controls.Add(this.lblKisiSayiUyarisi);
            this.lblOdaSayi.Controls.Add(this.btnRezervasyonAdd);
            this.lblOdaSayi.Controls.Add(this.btnZiyaretciKaydet);
            this.lblOdaSayi.Controls.Add(this.gbZiyaretciDetay);
            this.lblOdaSayi.Controls.Add(this.label10);
            this.lblOdaSayi.Controls.Add(this.label13);
            this.lblOdaSayi.Controls.Add(this.txtOdaNo);
            this.lblOdaSayi.Controls.Add(this.label1);
            this.lblOdaSayi.Location = new System.Drawing.Point(552, 12);
            this.lblOdaSayi.Name = "lblOdaSayi";
            this.lblOdaSayi.Size = new System.Drawing.Size(514, 588);
            this.lblOdaSayi.TabIndex = 10;
            // 
            // lblSecimeGoreTutar
            // 
            this.lblSecimeGoreTutar.AutoSize = true;
            this.lblSecimeGoreTutar.Location = new System.Drawing.Point(291, 441);
            this.lblSecimeGoreTutar.Name = "lblSecimeGoreTutar";
            this.lblSecimeGoreTutar.Size = new System.Drawing.Size(10, 13);
            this.lblSecimeGoreTutar.TabIndex = 71;
            this.lblSecimeGoreTutar.Text = "-";
            // 
            // ComplateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 612);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstDetails);
            this.Controls.Add(this.lblOdaSayi);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComplateRecord";
            this.Text = "ComplateRecord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComplateRecord_FormClosed);
            this.Load += new System.EventHandler(this.ComplateRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbZiyaretciDetay.ResumeLayout(false);
            this.gbZiyaretciDetay.PerformLayout();
            this.lblOdaSayi.ResumeLayout(false);
            this.lblOdaSayi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbZiyaretciDetay;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.DateTimePicker dtpDogum;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnZiyaretciKaydet;
        private System.Windows.Forms.Button btnRezervasyonAdd;
        private System.Windows.Forms.Label lblKisiSayiUyarisi;
        private System.Windows.Forms.Label lblOdaSayiUyari;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.Panel lblOdaSayi;
        private System.Windows.Forms.Label lblSecimeGoreTutar;
    }
}