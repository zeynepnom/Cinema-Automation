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
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }

       
        sinemaTableAdapters.Salon_BilgileriTableAdapter salon = new sinemaTableAdapters.Salon_BilgileriTableAdapter();

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(txtSalonAdi.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı salonu daha önce eklediniz.","Uyarı!!");
            }
            txtSalonAdi.Text = "";
        }

        private void frmSalonEkle_Load(object sender, EventArgs e)
        {

        }

        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                // Eğer form normal şekilde kapatılıyorsa ve salon ekleme işlemi tamamlandıysa
                if (e.CloseReason == CloseReason.UserClosing && DialogResult == DialogResult.OK)
                {
                    frmAnaSayfa anasayfa = new frmAnaSayfa();
                    anasayfa.ShowDialog();
                }
            }

        }
    }
