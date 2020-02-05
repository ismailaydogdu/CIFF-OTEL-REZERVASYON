namespace _01_UI_WinForm_HotelReservationAutomation
{
    partial class Secenek
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstRezTarih = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstGecmisRezervasyon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.Location = new System.Drawing.Point(11, 39);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 121);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Location = new System.Drawing.Point(12, 199);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(145, 84);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstRezTarih
            // 
            this.lstRezTarih.FormattingEnabled = true;
            this.lstRezTarih.Location = new System.Drawing.Point(174, 199);
            this.lstRezTarih.Margin = new System.Windows.Forms.Padding(2);
            this.lstRezTarih.Name = "lstRezTarih";
            this.lstRezTarih.Size = new System.Drawing.Size(402, 173);
            this.lstRezTarih.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.Location = new System.Drawing.Point(11, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 84);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Guncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstGecmisRezervasyon
            // 
            this.lstGecmisRezervasyon.FormattingEnabled = true;
            this.lstGecmisRezervasyon.Location = new System.Drawing.Point(174, 39);
            this.lstGecmisRezervasyon.Margin = new System.Windows.Forms.Padding(2);
            this.lstGecmisRezervasyon.Name = "lstGecmisRezervasyon";
            this.lstGecmisRezervasyon.Size = new System.Drawing.Size(402, 121);
            this.lstGecmisRezervasyon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Geçmiş Randevular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İleri Tarihteki Randevularınız";
            // 
            // Secenek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(596, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstGecmisRezervasyon);
            this.Controls.Add(this.lstRezTarih);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Secenek";
            this.Text = "Secenek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Secenek_FormClosed);
            this.Load += new System.EventHandler(this.Secenek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstRezTarih;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstGecmisRezervasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}