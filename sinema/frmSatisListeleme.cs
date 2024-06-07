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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sinema
{
    public partial class frmSatisListeleme : Form
    {
        public frmSatisListeleme()
        {
            InitializeComponent();
        }
        
         sinemaTableAdapters.Satis_BilgileriTableAdapter satisListesi = new sinemaTableAdapters.Satis_BilgileriTableAdapter();

        private void frmSatisListeleme_Load(object sender, EventArgs e)
        {
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.SatisListesi2();
          
        }

        
        private void frmSatisListeleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.ShowDialog();
        }

       


        
    } 
}
