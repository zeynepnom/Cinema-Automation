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
    public partial class frmSeansEkle : Form
    {
        public frmSeansEkle()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Seans_BilgileriTableAdapter filmSeansi = new sinemaTableAdapters.Seans_BilgileriTableAdapter();

        string seans = "";

        // Radyo butonlarının seçili olup olmadığını kontrol eden metot
        private void RadioButtonSeciliyse()
        {
            if (radioButton1.Checked == true) seans = radioButton1.Text;
           else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;

        }
        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            RadioButtonSeciliyse();
            if (seans!="")
            {
                RadioButtonSeciliyse();
                filmSeansi.SeansEkleme(comboFilm .Text , comboSalon .Text ,dateTimePicker .Text ,seans);
                MessageBox.Show("Seans ekleme işlemi yapıldı", "Kayıt");
            }
            else if (seans=="")
            {
                MessageBox.Show("Seans seçimi yapmadınız", "Uyarı");
            }
            comboFilm.Text = "";
            comboSalon.Text = "";
            dateTimePicker.Text = DateTime.Now.ToShortDateString();
        }

        private void frmSeansEkle_Load(object sender, EventArgs e)
        {
            FilmveSalonGoster (comboFilm, "SELECT*FROM film_bilgileri","filmadi");
            FilmveSalonGoster(comboSalon, "SELECT*FROM salon_bilgileri", "salonadi");
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Sinema_Bileti;Integrated Security=True");
      
        // Film ve salon bilgilerini ComboBox'a ekleyen metot
        private void FilmveSalonGoster(ComboBox combo , string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items .Add(read[sql2].ToString ());
            }
            baglanti.Close();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control  item3 in groupBox1 .Controls )
            {
                item3 .Enabled = true;
            }
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker.Text);
            if (yeni ==bugun )
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text)) 
                    {
                        item.Enabled = false;
                    }
                }
                TarihiKarşılaştır();
            }
            else if (yeni>bugun)
            {
                TarihiKarşılaştır();
            }
            else if (yeni<bugun )
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz!","Uyarı");
                dateTimePicker.Text = DateTime.Now.ToShortDateString();
            }
        }

       

       
        private void TarihiKarşılaştır()
        {
            try
            {
                baglanti.Open();

                // SQL sorgusu için parametreler 
                string query = "SELECT seans FROM seans_bilgileri WHERE salonadi = @salonadi AND tarih = @tarih";
                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    // Parametreleri ekledik
                    komut.Parameters.AddWithValue("@salonadi", comboSalon.Text);
                    komut.Parameters.AddWithValue("@tarih", dateTimePicker.Value);

                    using (SqlDataReader read = komut.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            foreach (Control item2 in groupBox1.Controls)
                            {
                                if (read["seans"].ToString() == item2.Text)
                                {
                                    item2.Enabled = false;
                                }
                            }
                        }
                    }
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

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker.Text = DateTime.Now.ToShortDateString();
        }

       

        private void frmSeansEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.ShowDialog();
        }

       
    }
}
