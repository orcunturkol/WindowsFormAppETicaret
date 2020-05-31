using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class KullaniciGiris : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;

        //Referanslar
        MySqlConnection sqlConnection;
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtOl kayıtOl = new KayıtOl();
            kayıtOl.Show();
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
                String sorguKomutu = "SELECT COUNT(*) FROM Musteriler WHERE MusteriEposta='" + epostaAdresi.Text + "' AND MusteriSifre= '" + sifreText.Text + "'";
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sorguKomutu, sqlConnection);
                String eposta = epostaAdresi.Text.ToString();
                //Sanal bir tablo yaratıldı
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                //Gelen sorguda bir değer var ise böyle bir kullanıcı adı ve şifresi var demektir.
                AnaMenu yp = new AnaMenu();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    sqlConnection.Open();
                    String sorguKomutu2 = "UPDATE kontrol SET kullaniciGirisYaptiMi=1, MusteriEposta='"+eposta+"'";
                    MySqlCommand mySqlCommand = new MySqlCommand(sorguKomutu2, sqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    yp.Show(); this.Hide();
                    sqlConnection.Close();
                }
                else MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış.");
            }
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
