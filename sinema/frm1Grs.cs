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
    public partial class frm1Grs : Form
    {
        public frm1Grs()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Sinema_Bileti;Integrated Security=True");

      

        private void btnKayitOl_Click_1(object sender, EventArgs e)
        {
            string yeniKullaniciAdi = txtKullaniciAdiKayit.Text;
            string yeniSifre = TxtSifreKayit.Text;
           

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Kisilerim (KullaniciAdi, Sifre) VALUES (@yeniKullaniciAdi, @yeniSifre)", baglanti);
                komut.Parameters.AddWithValue("@yeniKullaniciAdi", yeniKullaniciAdi);
                komut.Parameters.AddWithValue("@yeniSifre", yeniSifre);
               
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı!", "Başarılı");

                txtKullaniciAdiKayit.Text = "";
                TxtSifreKayit.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void brnGiris_Click(object sender, EventArgs e)
        {
           
            string kullaniciAdi = TxtKullaniciAdiGrs.Text;
            string sifre = txtSifreGrs.Text;

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Kisilerim WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre", baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Giriş başarılı!", "Başarılı");
                    // Ana formu açma
                    this.Hide();
                    frmAnaSayfa anaSayfa = new frmAnaSayfa();
                    anaSayfa.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}


