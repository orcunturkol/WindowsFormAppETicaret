using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class YoneticiGiris : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;

        //Referanslar
        SqlConnection sqlConnection;
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                //Kullanıcı girişini kontrol etmek için veritabanına bir sorgu gönderildi
                String sorguKomutu = "SELECT COUNT(*) FROM Yoneticiler WHERE YoneticiKullaniciAdi='" + kullaniciAdiTextBox.Text + "' AND YoneticiSifre= '" + sifreTextBox.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorguKomutu, sqlConnection);
                //Sanal bir tablo yaratıldı
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                //Gelen sorguda bir değer var ise böyle bir kullanıcı adı ve şifresi var demektir.
                if (dt.Rows[0][0].ToString() == "1") MessageBox.Show("Kullanıcı Girişi Başarıyla Yapıldı.");
                else MessageBox.Show("Kullanıcı Girişi Başarısız.");
            }
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
