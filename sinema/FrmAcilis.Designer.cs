namespace sinema
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlKoltuklar = new System.Windows.Forms.Panel();
            this.grpBoxBiletSatis = new System.Windows.Forms.GroupBox();
            this.btnBiletSatis = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.comboUcret = new System.Windows.Forms.ComboBox();
            this.comboFilmSeans = new System.Windows.Forms.ComboBox();
            this.comboFilmTarihi = new System.Windows.Forms.ComboBox();
            this.comboSalonAdi = new System.Windows.Forms.ComboBox();
            this.comboFilmAdi = new System.Windows.Forms.ComboBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblKoltukSatis = new System.Windows.Forms.Label();
            this.lblFilmSeans = new System.Windows.Forms.Label();
            this.lblFilmTarih = new System.Windows.Forms.Label();
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.grpBoxBiletIptal = new System.Windows.Forms.GroupBox();
            this.txtKoltukIptal = new System.Windows.Forms.TextBox();
            this.btnBiletIptal = new System.Windows.Forms.Button();
            this.lblKoltukIptal = new System.Windows.Forms.Label();
            this.lblPerde = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblFilmAfisi = new System.Windows.Forms.Label();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSeansListele = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.pnlIslemler = new System.Windows.Forms.Panel();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.pictureAfis = new System.Windows.Forms.PictureBox();
            this.grpBoxBiletSatis.SuspendLayout();
            this.grpBoxBiletIptal.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlKoltuklar.ForeColor = System.Drawing.Color.Black;
            this.pnlKoltuklar.Location = new System.Drawing.Point(50, 124);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(313, 328);
            this.pnlKoltuklar.TabIndex = 1;
            // 
            // grpBoxBiletSatis
            // 
            this.grpBoxBiletSatis.Controls.Add(this.btnBiletSatis);
            this.grpBoxBiletSatis.Controls.Add(this.txtSoyad);
            this.grpBoxBiletSatis.Controls.Add(this.txtAd);
            this.grpBoxBiletSatis.Controls.Add(this.txtKoltukNo);
            this.grpBoxBiletSatis.Controls.Add(this.comboUcret);
            this.grpBoxBiletSatis.Controls.Add(this.comboFilmSeans);
            this.grpBoxBiletSatis.Controls.Add(this.comboFilmTarihi);
            this.grpBoxBiletSatis.Controls.Add(this.comboSalonAdi);
            this.grpBoxBiletSatis.Controls.Add(this.comboFilmAdi);
            this.grpBoxBiletSatis.Controls.Add(this.lblUcret);
            this.grpBoxBiletSatis.Controls.Add(this.lblSoyad);
            this.grpBoxBiletSatis.Controls.Add(this.lblAd);
            this.grpBoxBiletSatis.Controls.Add(this.lblKoltukSatis);
            this.grpBoxBiletSatis.Controls.Add(this.lblFilmSeans);
            this.grpBoxBiletSatis.Controls.Add(this.lblFilmTarih);
            this.grpBoxBiletSatis.Controls.Add(this.lblSalonAdi);
            this.grpBoxBiletSatis.Controls.Add(this.lblFilmAdi);
            this.grpBoxBiletSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxBiletSatis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxBiletSatis.Location = new System.Drawing.Point(619, 12);
            this.grpBoxBiletSatis.Name = "grpBoxBiletSatis";
            this.grpBoxBiletSatis.Size = new System.Drawing.Size(243, 337);
            this.grpBoxBiletSatis.TabIndex = 3;
            this.grpBoxBiletSatis.TabStop = false;
            this.grpBoxBiletSatis.Text = "Bilet Satış İşlemleri ";
            // 
            // btnBiletSatis
            // 
            this.btnBiletSatis.BackColor = System.Drawing.Color.LightBlue;
            this.btnBiletSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiletSatis.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBiletSatis.Location = new System.Drawing.Point(114, 302);
            this.btnBiletSatis.Name = "btnBiletSatis";
            this.btnBiletSatis.Size = new System.Drawing.Size(78, 29);
            this.btnBiletSatis.TabIndex = 16;
            this.btnBiletSatis.Text = "Bilet Sat";
            this.btnBiletSatis.UseVisualStyleBackColor = false;
            this.btnBiletSatis.Click += new System.EventHandler(this.btnBiletSatis_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(93, 230);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(98, 20);
            this.txtSoyad.TabIndex = 15;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(93, 198);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(98, 20);
            this.txtAd.TabIndex = 14;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Enabled = false;
            this.txtKoltukNo.Location = new System.Drawing.Point(93, 163);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(98, 20);
            this.txtKoltukNo.TabIndex = 13;
            // 
            // comboUcret
            // 
            this.comboUcret.FormattingEnabled = true;
            this.comboUcret.Location = new System.Drawing.Point(93, 266);
            this.comboUcret.Name = "comboUcret";
            this.comboUcret.Size = new System.Drawing.Size(98, 21);
            this.comboUcret.TabIndex = 12;
            this.comboUcret.SelectedIndexChanged += new System.EventHandler(this.comboUcret_SelectedIndexChanged);
            // 
            // comboFilmSeans
            // 
            this.comboFilmSeans.FormattingEnabled = true;
            this.comboFilmSeans.Location = new System.Drawing.Point(93, 127);
            this.comboFilmSeans.Name = "comboFilmSeans";
            this.comboFilmSeans.Size = new System.Drawing.Size(98, 21);
            this.comboFilmSeans.Sorted = true;
            this.comboFilmSeans.TabIndex = 11;
            this.comboFilmSeans.SelectedIndexChanged += new System.EventHandler(this.comboFilmSeans_SelectedIndexChanged);
            // 
            // comboFilmTarihi
            // 
            this.comboFilmTarihi.FormattingEnabled = true;
            this.comboFilmTarihi.Location = new System.Drawing.Point(93, 100);
            this.comboFilmTarihi.Name = "comboFilmTarihi";
            this.comboFilmTarihi.Size = new System.Drawing.Size(98, 21);
            this.comboFilmTarihi.Sorted = true;
            this.comboFilmTarihi.TabIndex = 10;
            this.comboFilmTarihi.SelectedIndexChanged += new System.EventHandler(this.comboFilmTarihi_SelectedIndexChanged);
            // 
            // comboSalonAdi
            // 
            this.comboSalonAdi.FormattingEnabled = true;
            this.comboSalonAdi.Location = new System.Drawing.Point(93, 69);
            this.comboSalonAdi.Name = "comboSalonAdi";
            this.comboSalonAdi.Size = new System.Drawing.Size(98, 21);
            this.comboSalonAdi.Sorted = true;
            this.comboSalonAdi.TabIndex = 9;
            this.comboSalonAdi.SelectedIndexChanged += new System.EventHandler(this.comboSalonAdi_SelectedIndexChanged);
            // 
            // comboFilmAdi
            // 
            this.comboFilmAdi.FormattingEnabled = true;
            this.comboFilmAdi.Location = new System.Drawing.Point(93, 35);
            this.comboFilmAdi.Name = "comboFilmAdi";
            this.comboFilmAdi.Size = new System.Drawing.Size(98, 21);
            this.comboFilmAdi.Sorted = true;
            this.comboFilmAdi.TabIndex = 8;
            this.comboFilmAdi.SelectedIndexChanged += new System.EventHandler(this.comboFilmAdi_SelectedIndexChanged);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(11, 269);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(38, 13);
            this.lblUcret.TabIndex = 7;
            this.lblUcret.Text = "Ücret";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(11, 237);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(42, 13);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(11, 201);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(22, 13);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad";
            // 
            // lblKoltukSatis
            // 
            this.lblKoltukSatis.AutoSize = true;
            this.lblKoltukSatis.Location = new System.Drawing.Point(11, 166);
            this.lblKoltukSatis.Name = "lblKoltukSatis";
            this.lblKoltukSatis.Size = new System.Drawing.Size(63, 13);
            this.lblKoltukSatis.TabIndex = 4;
            this.lblKoltukSatis.Text = "Koltuk No";
            // 
            // lblFilmSeans
            // 
            this.lblFilmSeans.AutoSize = true;
            this.lblFilmSeans.Location = new System.Drawing.Point(11, 134);
            this.lblFilmSeans.Name = "lblFilmSeans";
            this.lblFilmSeans.Size = new System.Drawing.Size(71, 13);
            this.lblFilmSeans.TabIndex = 3;
            this.lblFilmSeans.Text = "Film Seansı";
            // 
            // lblFilmTarih
            // 
            this.lblFilmTarih.AutoSize = true;
            this.lblFilmTarih.Location = new System.Drawing.Point(11, 103);
            this.lblFilmTarih.Name = "lblFilmTarih";
            this.lblFilmTarih.Size = new System.Drawing.Size(65, 13);
            this.lblFilmTarih.TabIndex = 2;
            this.lblFilmTarih.Text = "Film Tarihi";
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Location = new System.Drawing.Point(11, 72);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(61, 13);
            this.lblSalonAdi.TabIndex = 1;
            this.lblSalonAdi.Text = "Salon Adı";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(11, 38);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(51, 13);
            this.lblFilmAdi.TabIndex = 0;
            this.lblFilmAdi.Text = "Film Adı";
            // 
            // grpBoxBiletIptal
            // 
            this.grpBoxBiletIptal.Controls.Add(this.txtKoltukIptal);
            this.grpBoxBiletIptal.Controls.Add(this.btnBiletIptal);
            this.grpBoxBiletIptal.Controls.Add(this.lblKoltukIptal);
            this.grpBoxBiletIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxBiletIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxBiletIptal.Location = new System.Drawing.Point(619, 355);
            this.grpBoxBiletIptal.Name = "grpBoxBiletIptal";
            this.grpBoxBiletIptal.Size = new System.Drawing.Size(243, 146);
            this.grpBoxBiletIptal.TabIndex = 4;
            this.grpBoxBiletIptal.TabStop = false;
            this.grpBoxBiletIptal.Text = "Bilet İptal İşlemi";
            // 
            // txtKoltukIptal
            // 
            this.txtKoltukIptal.Location = new System.Drawing.Point(93, 60);
            this.txtKoltukIptal.Name = "txtKoltukIptal";
            this.txtKoltukIptal.Size = new System.Drawing.Size(97, 20);
            this.txtKoltukIptal.TabIndex = 3;
            this.txtKoltukIptal.TextChanged += new System.EventHandler(this.txtKoltukIptal_TextChanged);
            // 
            // btnBiletIptal
            // 
            this.btnBiletIptal.BackColor = System.Drawing.Color.LightBlue;
            this.btnBiletIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiletIptal.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBiletIptal.Location = new System.Drawing.Point(113, 97);
            this.btnBiletIptal.Name = "btnBiletIptal";
            this.btnBiletIptal.Size = new System.Drawing.Size(79, 21);
            this.btnBiletIptal.TabIndex = 2;
            this.btnBiletIptal.Text = "İptal Et";
            this.btnBiletIptal.UseVisualStyleBackColor = false;
            this.btnBiletIptal.Click += new System.EventHandler(this.btnBiletIptal_Click_2);
            // 
            // lblKoltukIptal
            // 
            this.lblKoltukIptal.AutoSize = true;
            this.lblKoltukIptal.Location = new System.Drawing.Point(9, 61);
            this.lblKoltukIptal.Name = "lblKoltukIptal";
            this.lblKoltukIptal.Size = new System.Drawing.Size(63, 13);
            this.lblKoltukIptal.TabIndex = 0;
            this.lblKoltukIptal.Text = "Koltuk No";
            // 
            // lblPerde
            // 
            this.lblPerde.AutoEllipsis = true;
            this.lblPerde.AutoSize = true;
            this.lblPerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPerde.Location = new System.Drawing.Point(-5, 124);
            this.lblPerde.Name = "lblPerde";
            this.lblPerde.Size = new System.Drawing.Size(39, 360);
            this.lblPerde.TabIndex = 5;
            this.lblPerde.Text = " P  \r\n\r\n\r\n \r\n E   \r\n\r\n\r\n\r\n R  \r\n\r\n\r\n\r\n D  \r\n\r\n\r\n\r\n E  \r\n\r\n\r\n\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(66, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 48);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(303, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "BOŞ KOLTUKLAR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(47, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "DOLU KOLTUKLAR";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(272, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(25, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(16, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(25, 20);
            this.textBox4.TabIndex = 0;
            // 
            // lblFilmAfisi
            // 
            this.lblFilmAfisi.AutoSize = true;
            this.lblFilmAfisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAfisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFilmAfisi.Location = new System.Drawing.Point(420, 124);
            this.lblFilmAfisi.Name = "lblFilmAfisi";
            this.lblFilmAfisi.Size = new System.Drawing.Size(112, 24);
            this.lblFilmAfisi.TabIndex = 9;
            this.lblFilmAfisi.Text = "FİLM AFİŞİ";
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalonEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.Location = new System.Drawing.Point(22, 14);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(88, 61);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "SALON EKLE";
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.BackColor = System.Drawing.Color.LightBlue;
            this.btnFilmEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.Location = new System.Drawing.Point(120, 14);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(83, 61);
            this.btnFilmEkle.TabIndex = 1;
            this.btnFilmEkle.Text = "FİLM EKLE";
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnSeansListele
            // 
            this.btnSeansListele.BackColor = System.Drawing.Color.LightBlue;
            this.btnSeansListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeansListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansListele.Location = new System.Drawing.Point(310, 14);
            this.btnSeansListele.Name = "btnSeansListele";
            this.btnSeansListele.Size = new System.Drawing.Size(85, 61);
            this.btnSeansListele.TabIndex = 3;
            this.btnSeansListele.Text = "SEANSLARI LİSTELE";
            this.btnSeansListele.UseVisualStyleBackColor = false;
            this.btnSeansListele.Click += new System.EventHandler(this.btnSeansListele_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackColor = System.Drawing.Color.LightBlue;
            this.btnSeansEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansEkle.Location = new System.Drawing.Point(219, 14);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(85, 61);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.Text = "SEANS EKLE";
            this.btnSeansEkle.UseVisualStyleBackColor = false;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // pnlIslemler
            // 
            this.pnlIslemler.Controls.Add(this.btnSatislar);
            this.pnlIslemler.Controls.Add(this.btnSeansEkle);
            this.pnlIslemler.Controls.Add(this.btnSeansListele);
            this.pnlIslemler.Controls.Add(this.btnFilmEkle);
            this.pnlIslemler.Controls.Add(this.btnSalonEkle);
            this.pnlIslemler.Location = new System.Drawing.Point(28, 12);
            this.pnlIslemler.Name = "pnlIslemler";
            this.pnlIslemler.Size = new System.Drawing.Size(526, 94);
            this.pnlIslemler.TabIndex = 0;
            // 
            // btnSatislar
            // 
            this.btnSatislar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSatislar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatislar.Location = new System.Drawing.Point(409, 14);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(85, 61);
            this.btnSatislar.TabIndex = 5;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.UseVisualStyleBackColor = false;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // pictureAfis
            // 
            this.pictureAfis.BackColor = System.Drawing.Color.Teal;
            this.pictureAfis.Location = new System.Drawing.Point(373, 151);
            this.pictureAfis.Name = "pictureAfis";
            this.pictureAfis.Size = new System.Drawing.Size(181, 278);
            this.pictureAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAfis.TabIndex = 7;
            this.pictureAfis.TabStop = false;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(895, 553);
            this.Controls.Add(this.lblFilmAfisi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureAfis);
            this.Controls.Add(this.lblPerde);
            this.Controls.Add(this.grpBoxBiletIptal);
            this.Controls.Add(this.grpBoxBiletSatis);
            this.Controls.Add(this.pnlKoltuklar);
            this.Controls.Add(this.pnlIslemler);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Bileti Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.grpBoxBiletSatis.ResumeLayout(false);
            this.grpBoxBiletSatis.PerformLayout();
            this.grpBoxBiletIptal.ResumeLayout(false);
            this.grpBoxBiletIptal.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlKoltuklar;
        private System.Windows.Forms.GroupBox grpBoxBiletSatis;
        private System.Windows.Forms.GroupBox grpBoxBiletIptal;
        private System.Windows.Forms.ComboBox comboFilmSeans;
        private System.Windows.Forms.ComboBox comboFilmTarihi;
        private System.Windows.Forms.ComboBox comboSalonAdi;
        private System.Windows.Forms.ComboBox comboFilmAdi;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblKoltukSatis;
        private System.Windows.Forms.Label lblFilmSeans;
        private System.Windows.Forms.Label lblFilmTarih;
        private System.Windows.Forms.Label lblSalonAdi;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Label lblPerde;
        private System.Windows.Forms.Button btnBiletSatis;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.Button btnBiletIptal;
        private System.Windows.Forms.Label lblKoltukIptal;
        private System.Windows.Forms.PictureBox pictureAfis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblFilmAfisi;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSeansListele;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Panel pnlIslemler;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.ComboBox comboUcret;
        private System.Windows.Forms.TextBox txtKoltukIptal;
    }
}

