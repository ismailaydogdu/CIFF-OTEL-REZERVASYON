namespace _01_UI_WinForm_HotelReservationAutomation
{
    partial class Record
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
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.nudKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOdaSayisi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLeaving = new System.Windows.Forms.DateTimePicker();
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.btnGosterGizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tutar :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "C İ F F SOFTWARE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.rbWoman);
            this.groupBox1.Controls.Add(this.rbMan);
            this.groupBox1.Controls.Add(this.dtpBirth);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(22, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(422, 318);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Kişi  Bilgileri";
            // 
            // txtTc
            // 
            this.txtTc.Enabled = false;
            this.txtTc.Location = new System.Drawing.Point(155, 35);
            this.txtTc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(236, 20);
            this.txtTc.TabIndex = 65;
            this.txtTc.ValidatingType = typeof(int);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(155, 247);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(236, 47);
            this.btnEkle.TabIndex = 64;
            this.btnEkle.Text = "Kayıt Ol";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(230, 214);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(52, 17);
            this.rbWoman.TabIndex = 63;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Kadın";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(155, 214);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(53, 17);
            this.rbMan.TabIndex = 62;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Erkek";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(155, 155);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(236, 20);
            this.dtpBirth.TabIndex = 61;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(155, 115);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(236, 20);
            this.txtSoyad.TabIndex = 59;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(155, 75);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(236, 20);
            this.txtAd.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Cinsiyetiniz :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Tc Kimlik No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Dogum Tarihiniz :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Soyadınız :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Adınız :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTutar);
            this.groupBox2.Controls.Add(this.cmbTypes);
            this.groupBox2.Controls.Add(this.nudKisiSayisi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbOdaSayisi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpLeaving);
            this.groupBox2.Controls.Add(this.dtpEntry);
            this.groupBox2.Location = new System.Drawing.Point(448, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(447, 463);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezervasyon Oluştur";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(66, 303);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(13, 13);
            this.lblTutar.TabIndex = 85;
            this.lblTutar.Text = "0";
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(134, 205);
            this.cmbTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(156, 21);
            this.cmbTypes.TabIndex = 89;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // nudKisiSayisi
            // 
            this.nudKisiSayisi.Location = new System.Drawing.Point(134, 118);
            this.nudKisiSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.nudKisiSayisi.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudKisiSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKisiSayisi.Name = "nudKisiSayisi";
            this.nudKisiSayisi.Size = new System.Drawing.Size(221, 20);
            this.nudKisiSayisi.TabIndex = 88;
            this.nudKisiSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKisiSayisi.ValueChanged += new System.EventHandler(this.nudKisiSayisi_ValueChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(121, 286);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(294, 47);
            this.btnNext.TabIndex = 83;
            this.btnNext.Text = "Devam Et ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Rezervasyon Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Oda Sayısı :";
            // 
            // cmbOdaSayisi
            // 
            this.cmbOdaSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaSayisi.FormattingEnabled = true;
            this.cmbOdaSayisi.Location = new System.Drawing.Point(134, 161);
            this.cmbOdaSayisi.Name = "cmbOdaSayisi";
            this.cmbOdaSayisi.Size = new System.Drawing.Size(156, 21);
            this.cmbOdaSayisi.TabIndex = 77;
            this.cmbOdaSayisi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaSayisi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Kişi Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Giriş Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Çıkış Tarihi :";
            // 
            // dtpLeaving
            // 
            this.dtpLeaving.Location = new System.Drawing.Point(134, 75);
            this.dtpLeaving.Name = "dtpLeaving";
            this.dtpLeaving.Size = new System.Drawing.Size(281, 20);
            this.dtpLeaving.TabIndex = 73;
            this.dtpLeaving.ValueChanged += new System.EventHandler(this.dtpLeaving_ValueChanged);
            // 
            // dtpEntry
            // 
            this.dtpEntry.Location = new System.Drawing.Point(134, 32);
            this.dtpEntry.MinDate = new System.DateTime(2019, 11, 6, 12, 21, 18, 0);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(281, 20);
            this.dtpEntry.TabIndex = 72;
            this.dtpEntry.Value = new System.DateTime(2019, 11, 25, 0, 0, 0, 0);
            this.dtpEntry.ValueChanged += new System.EventHandler(this.dtpEntry_ValueChanged);
            // 
            // btnGosterGizle
            // 
            this.btnGosterGizle.Location = new System.Drawing.Point(96, 47);
            this.btnGosterGizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGosterGizle.Name = "btnGosterGizle";
            this.btnGosterGizle.Size = new System.Drawing.Size(260, 62);
            this.btnGosterGizle.TabIndex = 73;
            this.btnGosterGizle.Text = "Kişi Bİlgilerini Göster/Gizle";
            this.btnGosterGizle.UseVisualStyleBackColor = true;
            this.btnGosterGizle.Click += new System.EventHandler(this.btnGosterGizle_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 491);
            this.Controls.Add(this.btnGosterGizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Record";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudKisiSayisi;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOdaSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpLeaving;
        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.Button btnGosterGizle;
    }
}