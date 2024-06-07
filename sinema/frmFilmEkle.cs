using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema
{
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }
        //  sinemaTableAdapters.Film_BilgileriTableAdapter film = new sinemaTableAdapters.Film_BilgileriTableAdapter();
        sinemaTableAdapters.Film_BilgileriTableAdapter film = new sinemaTableAdapters.Film_BilgileriTableAdapter();

        private void btnAfisSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureAfis.ImageLocation = openFileDialog1.FileName;
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtFilmSuresi.Text, dateTimeTarih.Text, txtYapimYili.Text, pictureAfis.ImageLocation);
                film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, txtFilmTuru.Text, txtFilmSuresi.Text, dateTimeTarih.Text, txtYapimYili.Text, pictureAfis.ImageLocation);
                MessageBox.Show("Film bilgileri eklendi.", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu film daha önce eklendi!", "Uyarı");
            }
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            txtFilmTuru.Text = "";
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void frmFilmEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.ShowDialog();
        }


    }
}
