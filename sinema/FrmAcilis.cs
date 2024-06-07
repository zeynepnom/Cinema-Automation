using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Sinema_Bileti;Integrated Security=True");

        int sayac = 0;

        private void FilmveSalonGetir(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        private void FilmAfisiGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM film_bilgileri WHERE filmadi='" + comboFilmAdi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureAfis.ImageLocation = read["resim"].ToString();
            }
            baglanti.Close();
        }
        private void ComboDoluKoltuklar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Control item in pnlKoltuklar.Controls)
            {
                txtKoltukIptal.Text = "";

                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        txtKoltukIptal.Text = sb.ToString(); ;
                    }
                }
            }
        }
        private void YenidenRenklendir()
        {
            foreach (Control item in pnlKoltuklar.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void VeritabaniDoluKoltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM satis_bilgileri WHERE filmadi='" + comboFilmAdi.SelectedItem + "' and salonadi='" + comboSalonAdi.SelectedItem + "' and tarih='" + comboFilmTarihi.SelectedItem + "' and saat='" + comboFilmSeans.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in pnlKoltuklar.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukno"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;
                        }

                    }
                }
            }
            baglanti.Close();

        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            BosKoltuklar();
            FilmveSalonGetir(comboFilmAdi, "SELECT * FROM film_bilgileri", "filmadi");
            FilmveSalonGetir(comboSalonAdi, "SELECT * FROM salon_bilgileri", "salonadi");
            UcretBilgileriGetir();
        }

        private void BosKoltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.pnlKoltuklar.Controls.Add(btn);
                    btn.Click += BtnClick;
                }
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();


        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle = new frmFilmEkle();
            ekle.Show();

        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            frmSeansEkle ekle = new frmSeansEkle();
            ekle.Show();

        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            frmSeansListele ekle = new frmSeansListele();
            ekle.Show();

        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            frmSatisListeleme ekle = new frmSatisListeleme();
            ekle.Show();

        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeans.Items.Clear();
            comboFilmTarihi.Items.Clear();
            comboFilmSeans.Text = "";
            comboFilmTarihi.Text = "";
            comboSalonAdi.Text = "";
            foreach (Control item in grpBoxBiletSatis.Controls) if (item is TextBox) item.Text = "";

            FilmAfisiGoster();
            YenidenRenklendir();
            ComboDoluKoltuklar();
        }
        sinemaTableAdapters.Satis_BilgileriTableAdapter satis = new sinemaTableAdapters.Satis_BilgileriTableAdapter();

        private void btnBiletSatis_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text != "")
            {
                try
                {
                    satis.SatisYap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeans.Text, txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString());
                    foreach (Control item in grpBoxBiletSatis.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    VeritabaniDoluKoltuklar();
                    ComboDoluKoltuklar();
                    MessageBox.Show("Bilet satışı başarılı.", "Bilgi");

                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata oluştu!" + hata.Message, "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!", "Uyarı");
            }
        }
        private void FilmTarihiGetir()
        {

            comboFilmTarihi.Text = "";
            comboFilmSeans.Text = "";
            comboFilmTarihi.Items.Clear();
            comboFilmSeans.Items.Clear();
            //hem textini hem içeriğini temizledik
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM seans_bilgileri WHERE filmadi='" + comboFilmAdi.SelectedItem + "' and salonadi='" + comboSalonAdi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["tarih"].ToString());
                    }

                }

            }
            baglanti.Close();
        }
        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmTarihiGetir();
        }
        private void FilmSeansiGetir()
        {
            comboFilmSeans.Text = "";
            comboFilmSeans.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM seans_bilgileri WHERE filmadi='" + comboFilmAdi.SelectedItem + "' and salonadi='" + comboSalonAdi.SelectedItem + "' and tarih='" + comboFilmTarihi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["seans"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        comboFilmSeans.Items.Add(read["seans"].ToString());
                    }



                }
                else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    comboFilmSeans.Items.Add(read["seans"].ToString());

                }

            }
            baglanti.Close();
        }
        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmSeansiGetir();
        }

        private void comboFilmSeans_SelectedIndexChanged(object sender, EventArgs e)
        {

            YenidenRenklendir();
            VeritabaniDoluKoltuklar();
            ComboDoluKoltuklar();
        }

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {

        }
        int tamBilet = 70;
        int ögrenciBilet = 50;
        private void UcretBilgileriGetir()
        {
            comboUcret.Items.Add("Tam: " + tamBilet);
            comboUcret.Items.Add("İndirimli: " + ögrenciBilet);

        }

        private void comboUcret_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretBilgileriGetir();
        }

        private void comboKoltuIİptal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SatisIptal(string filmadi, string salonadi, string tarih, string saat, string koltukno)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Sinema_Bileti;Integrated Security=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM satis_bilgileri WHERE filmadi=@filmadi AND salonadi=@salonadi AND tarih=@tarih AND saat=@saat AND koltukno=@koltukno", baglanti);
                komut.Parameters.AddWithValue("@filmadi", filmadi);
                komut.Parameters.AddWithValue("@salonadi", salonadi);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@saat", saat);
                komut.Parameters.AddWithValue("@koltukno", koltukno);

                int result = komut.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new Exception("Bilet iptal edilemedi.");
                }
            }
        }

        



        private void txtKoltukIptal_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1Grs giris = new frm1Grs ();
            giris .ShowDialog();
        }

        private void btnBiletIptal_Click_2(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtKoltukIptal.Text))
            {
                try
                {
                    // Bilet iptal işlemini gerçekleştir
                    SatisIptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboFilmSeans.Text, txtKoltukIptal.Text);

                    // İşlemler tamamlandığında mesaj göster
                    MessageBox.Show("Bilet iptal edildi.", "Bilgi");

                    // Ekranı temizle ve durumu güncelle
                    YenidenRenklendir();
                    VeritabaniDoluKoltuklar();
                    ComboDoluKoltuklar();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata oluştu! " + hata.Message, "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!", "Uyarı");
            }
        }
    }
    }

