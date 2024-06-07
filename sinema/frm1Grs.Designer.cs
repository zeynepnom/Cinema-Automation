namespace sinema
{
    partial class frm1Grs
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
            this.groupBoxGiris = new System.Windows.Forms.GroupBox();
            this.brnGiris = new System.Windows.Forms.Button();
            this.txtSifreGrs = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdiGrs = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.groupBoxKayit = new System.Windows.Forms.GroupBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtKullaniciAdiKayit = new System.Windows.Forms.TextBox();
            this.TxtSifreKayit = new System.Windows.Forms.TextBox();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSifre2 = new System.Windows.Forms.Label();
            this.groupBoxGiris.SuspendLayout();
            this.groupBoxKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.Controls.Add(this.brnGiris);
            this.groupBoxGiris.Controls.Add(this.txtSifreGrs);
            this.groupBoxGiris.Controls.Add(this.TxtKullaniciAdiGrs);
            this.groupBoxGiris.Controls.Add(this.lblSifre);
            this.groupBoxGiris.Controls.Add(this.lblKullaniciAdi);
            this.groupBoxGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxGiris.Location = new System.Drawing.Point(91, 67);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Size = new System.Drawing.Size(266, 302);
            this.groupBoxGiris.TabIndex = 0;
            this.groupBoxGiris.TabStop = false;
            this.groupBoxGiris.Text = "Kullanıcı Girişi";
            // 
            // brnGiris
            // 
            this.brnGiris.BackColor = System.Drawing.Color.LightBlue;
            this.brnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnGiris.ForeColor = System.Drawing.Color.IndianRed;
            this.brnGiris.Location = new System.Drawing.Point(103, 153);
            this.brnGiris.Name = "brnGiris";
            this.brnGiris.Size = new System.Drawing.Size(99, 32);
            this.brnGiris.TabIndex = 4;
            this.brnGiris.Text = "Giriş Yap";
            this.brnGiris.UseVisualStyleBackColor = false;
            this.brnGiris.Click += new System.EventHandler(this.brnGiris_Click);
            // 
            // txtSifreGrs
            // 
            this.txtSifreGrs.Location = new System.Drawing.Point(103, 109);
            this.txtSifreGrs.Name = "txtSifreGrs";
            this.txtSifreGrs.PasswordChar = '*';
            this.txtSifreGrs.Size = new System.Drawing.Size(99, 20);
            this.txtSifreGrs.TabIndex = 3;
            // 
            // TxtKullaniciAdiGrs
            // 
            this.TxtKullaniciAdiGrs.Location = new System.Drawing.Point(103, 54);
            this.TxtKullaniciAdiGrs.Name = "TxtKullaniciAdiGrs";
            this.TxtKullaniciAdiGrs.Size = new System.Drawing.Size(99, 20);
            this.TxtKullaniciAdiGrs.TabIndex = 2;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(16, 112);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(33, 13);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(6, 57);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(77, 13);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // groupBoxKayit
            // 
            this.groupBoxKayit.Controls.Add(this.btnKayitOl);
            this.groupBoxKayit.Controls.Add(this.txtKullaniciAdiKayit);
            this.groupBoxKayit.Controls.Add(this.TxtSifreKayit);
            this.groupBoxKayit.Controls.Add(this.lblKullanici);
            this.groupBoxKayit.Controls.Add(this.lblSifre2);
            this.groupBoxKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxKayit.Location = new System.Drawing.Point(429, 67);
            this.groupBoxKayit.Name = "groupBoxKayit";
            this.groupBoxKayit.Size = new System.Drawing.Size(253, 302);
            this.groupBoxKayit.TabIndex = 1;
            this.groupBoxKayit.TabStop = false;
            this.groupBoxKayit.Text = "Kayıt Olma";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.LightBlue;
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitOl.ForeColor = System.Drawing.Color.IndianRed;
            this.btnKayitOl.Location = new System.Drawing.Point(102, 153);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(88, 32);
            this.btnKayitOl.TabIndex = 5;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click_1);
            // 
            // txtKullaniciAdiKayit
            // 
            this.txtKullaniciAdiKayit.Location = new System.Drawing.Point(101, 58);
            this.txtKullaniciAdiKayit.Name = "txtKullaniciAdiKayit";
            this.txtKullaniciAdiKayit.Size = new System.Drawing.Size(89, 20);
            this.txtKullaniciAdiKayit.TabIndex = 4;
            // 
            // TxtSifreKayit
            // 
            this.TxtSifreKayit.Location = new System.Drawing.Point(101, 109);
            this.TxtSifreKayit.Name = "TxtSifreKayit";
            this.TxtSifreKayit.PasswordChar = '*';
            this.TxtSifreKayit.Size = new System.Drawing.Size(89, 20);
            this.TxtSifreKayit.TabIndex = 5;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(15, 61);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(77, 13);
            this.lblKullanici.TabIndex = 2;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblSifre2
            // 
            this.lblSifre2.AutoSize = true;
            this.lblSifre2.Location = new System.Drawing.Point(15, 105);
            this.lblSifre2.Name = "lblSifre2";
            this.lblSifre2.Size = new System.Drawing.Size(33, 13);
            this.lblSifre2.TabIndex = 3;
            this.lblSifre2.Text = "Şifre";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKayit);
            this.Controls.Add(this.groupBoxGiris);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş İşemleri";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            this.groupBoxKayit.ResumeLayout(false);
            this.groupBoxKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGiris;
        private System.Windows.Forms.Button brnGiris;
        private System.Windows.Forms.TextBox txtSifreGrs;
        private System.Windows.Forms.TextBox TxtKullaniciAdiGrs;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.GroupBox groupBoxKayit;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtKullaniciAdiKayit;
        private System.Windows.Forms.TextBox TxtSifreKayit;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSifre2;
    }
}