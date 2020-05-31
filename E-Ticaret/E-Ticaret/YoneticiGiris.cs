using MySql.Data.MySqlClient;
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
        MySqlConnection sqlConnection;
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            GirisKontrol();
        }

        private void GirisKontrol()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                //Kullanıcı girişini kontrol etmek için veritabanına bir sorgu gönderildi
                String sorguKomutu = "SELECT COUNT(*) FROM Yoneticiler WHERE YoneticiKullanici='" + kullaniciAdiTextBox.Text + "' AND YoneticiSifre= '" + sifreTextBox.Text + "'";
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sorguKomutu, sqlConnection);
                //Sanal bir tablo yaratıldı
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                //Gelen sorguda bir değer var ise böyle bir kullanıcı adı ve şifresi var demektir.
                YonetimPaneli yp = new YonetimPaneli();
                if (dt.Rows[0][0].ToString() == "1") {
                    yp.Show(); this.Hide();
                }
                else MessageBox.Show("Kullanıcı Girişi Başarısız.");
            }
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}
