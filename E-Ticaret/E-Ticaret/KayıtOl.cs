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
    public partial class KayıtOl : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;

        //Referanslar
        MySqlConnection sqlConnection;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public KayıtOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adSoyadTextBox.Text != "" && sifreTextBox.Text != "" && telefonNumarasiTextBox.Text != "" && adresTextBox.Text != "")
            {
                sqlConnection = new MySqlConnection(connectionString);
                String sorgu = "INSERT INTO Musteriler(MusteriAdSoyad, MusteriEposta, MusteriAdres, MusteriSifre, MusteriTelefonNo) VALUES(@musteriAdSoyad, @musteriEposta, @musteriAdres, @musteriSifre, @musteriTelefonNo)";
                sqlConnection.Open();
                cmd = new MySqlCommand(sorgu, sqlConnection);
                cmd.Parameters.AddWithValue("@musteriAdSoyad", adSoyadTextBox.Text);
                cmd.Parameters.AddWithValue("@musteriEposta", ePostaAdresiTextBox.Text);
                cmd.Parameters.AddWithValue("@musteriAdres", adresTextBox.Text);
                cmd.Parameters.AddWithValue("@musteriSifre", sifreTextBox.Text);
                cmd.Parameters.AddWithValue("@musteriTelefonNo", telefonNumarasiTextBox.Text);
                try
                {
                    if (cmd.ExecuteNonQuery() == 1) MessageBox.Show("Kaydınız başarıyla tamamlandı.");
                    else MessageBox.Show("Başarısız. Lütfen tekrar deneyiniz.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bütün parametreleri giriniz.");
            }
        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {
        
        }
    }
}
