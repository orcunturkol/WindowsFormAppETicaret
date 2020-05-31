using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;

namespace E_Ticaret
{
    public partial class AnaMenu : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;

        //Referanslar
        MySqlConnection sqlConnection;
        MySqlCommand command;
        MySqlDataReader dr;

        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            UrunListele();
            UrunListele2();
            UrunListele3();
            UrunListele4();
            UrunListele5();
            UrunListele6();
            MusteriAdSoyadListele();
        }

        private void MusteriAdSoyadListele()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                //Kullanıcı girişini kontrol etmek için veritabanına bir sorgu gönderildi
                sqlConnection.Open();
                String sorguKomutu = "SELECT * FROM kontrol";
                command = new MySqlCommand(sorguKomutu, sqlConnection);
                dr = command.ExecuteReader();
                dr.Read();
                int kontrol = Convert.ToInt32(dr[0]);
                if (kontrol == 1)
                {
                    dr.Close();
                    cikisYap.Visible = true;
                    String sorguKomutu2 = "SELECT m.MusteriAdSoyad FROM kontrol k INNER JOIN musteriler m ON m.MusteriEposta = k.MusteriEposta";
                    command = new MySqlCommand(sorguKomutu2, sqlConnection);
                    dr = command.ExecuteReader();
                    dr.Read();
                    kullaniciAdiLabel.Text = dr[0].ToString();
                    dr.Close();
                }
                sqlConnection.Close();
            }
        }

        void UrunListele()
        {
            using(sqlConnection = new MySqlConnection(connectionString))
            {
                string sorguMetni = "SELECT UrunAdi, UrunFiyati, UrunFotograf FROM Urunler WHERE UrunId=1";
                sqlConnection.Open();
                command = new MySqlCommand(sorguMetni, sqlConnection);
                dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    fiyat1.Text = dr[1].ToString();
                    urunAdiLabel.Text = dr[0].ToString();
                    byte[] img = ((byte[])dr[2]);
                    MemoryStream memoryStream = new MemoryStream(img);
                    katalogResmi1.Image = Image.FromStream(memoryStream);
                }
                sqlConnection.Close();
            }
           
        }
        void UrunListele2()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                string sorguMetni = "SELECT UrunAdi, UrunFiyati, UrunFotograf FROM Urunler WHERE UrunId=2";
                sqlConnection.Open();
                command = new MySqlCommand(sorguMetni, sqlConnection);
                dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    fiyat2.Text = dr[1].ToString();
                    urunAdi2.Text = dr[0].ToString();
                    byte[] img = ((byte[])dr[2]);
                    MemoryStream memoryStream = new MemoryStream(img);
                    katalogResmi2.Image = Image.FromStream(memoryStream);
                }
                sqlConnection.Close();
            }

        }

        void UrunListele3()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                string sorguMetni = "SELECT UrunAdi, UrunFiyati, UrunFotograf FROM Urunler WHERE UrunId=3";
                sqlConnection.Open();
                command = new MySqlCommand(sorguMetni, sqlConnection);
                dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    fiyat3.Text = dr[1].ToString();
                    urunAdi3.Text = dr[0].ToString();
                    byte[] img = ((byte[])dr[2]);
                    MemoryStream memoryStream = new MemoryStream(img);
                    katalogResmi3.Image = Image.FromStream(memoryStream);
                }
                sqlConnection.Close();
            }

        }

        void UrunListele4()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                string sorguMetni = "SELECT UrunAdi, UrunFiyati, UrunFotograf FROM Urunler WHERE UrunId=4";
                sqlConnection.Open();
                command = new MySqlCommand(sorguMetni, sqlConnection);
                dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    fiyat5.Text = dr[1].ToString();
                    urunAdi5.Text = dr[0].ToString();
                    byte[] img = ((byte[])dr[2]);
                    MemoryStream memoryStream = new MemoryStream(img);
                    kategroiFotografi5.Image = Image.FromStream(memoryStream);
                }
                sqlConnection.Close();
            }

        }

        void UrunListele5()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                string sorguMetni = "SELECT UrunAdi, UrunFiyati, UrunFotograf FROM Urunler WHERE UrunId=5";
                sqlConnection.Open();
                command = new MySqlCommand(sorguMetni, sqlConnection);
                dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    fiyat6.Text = dr[1].ToString();
                    urunAdi6.Text = dr[0].ToString();
                    byte[] img = ((byte[])dr[2]);
                    MemoryStream memoryStream = new MemoryStream(img);
                    katalogResmi6.Image = Image.FromStream(memoryStream);
                }
                sqlConnection.Close();
            }
        }

        void UrunListele6()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                string sorguMetni = "SELECT UrunAdi, UrunFiyati, UrunFotograf FROM Urunler WHERE UrunId=6";
                sqlConnection.Open();
                command = new MySqlCommand(sorguMetni, sqlConnection);
                dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    fiyat7.Text = dr[1].ToString();
                    urunAdi7.Text = dr[0].ToString();
                    byte[] img = ((byte[])dr[2]);
                    MemoryStream memoryStream = new MemoryStream(img);
                    katalogResmi7.Image = Image.FromStream(memoryStream);
                }
                sqlConnection.Close();
            }
        }
        private void yonetimPaneliButton_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            yoneticiGiris.Show();
            this.Hide();
        }

        private void userBox_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiLabel.Text == "-")
            {
                KullaniciGiris kullaniciGiris = new KullaniciGiris();
                kullaniciGiris.Show();
                this.Hide();
            }

            else
            {
                Siparisler siparisler = new Siparisler();
                siparisler.Show();
                this.Hide();
            }
           
        }

        private void kullaniciAdiLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {

                sqlConnection.Open();
                String sorguKomutu2 = "UPDATE kontrol SET kullaniciGirisYaptiMi=0, MusteriEposta='" + "" + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(sorguKomutu2, sqlConnection);
                int i = mySqlCommand.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Başarıyla çıkış yapıldı");
                }
                else
                {
                    MessageBox.Show("Çıkışta bir hata oluştu.");
                }
                sqlConnection.Close();
            }
            cikisYap.Visible = false;
            kullaniciAdiLabel.Text = "-";
        }

        private void sepeteEkleBtn1_Click(object sender, EventArgs e)
        {
            if(kullaniciAdiLabel.Text != "-")
            {
                using (sqlConnection = new MySqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    String sorguKomutu2 = "INSERT INTO sepet (MusteriId, UrunId) VALUES (@musteriId, @urunId)";
                    MySqlCommand mySqlCommand = new MySqlCommand(sorguKomutu2, sqlConnection);
                    String sorguKomutu3 = "SELECT m.MusteriId FROM kontrol k INNER JOIN musteriler m ON m.MusteriEposta=k.MusteriEposta";
                    command = new MySqlCommand(sorguKomutu3, sqlConnection);
                    dr = command.ExecuteReader();
                    dr.Read();
                    string musteriId = dr[0].ToString();
                    dr.Close();
                    mySqlCommand.Parameters.AddWithValue("@musteriId", musteriId);
                    mySqlCommand.Parameters.AddWithValue("@urunId", 1);
                    int i = mySqlCommand.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Ürün sepete eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Ürün sepete eklenirken bir hata oluştu.");
                    }
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen ilk önce giriş yapınız.");
            }
        }

        private void sepetBox_Click(object sender, EventArgs e)
        {
            if(kullaniciAdiLabel.Text != "-")
            {
                Sepet sepet = new Sepet();
                sepet.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen ilk önce giriş yapınız");
            }
        }

        private void sepeteEkleBtn2_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiLabel.Text != "-")
            {
                using (sqlConnection = new MySqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    String sorguKomutu2 = "INSERT INTO sepet (MusteriId, UrunId) VALUES (@musteriId, @urunId)";
                    MySqlCommand mySqlCommand = new MySqlCommand(sorguKomutu2, sqlConnection);
                    String sorguKomutu3 = "SELECT m.MusteriId FROM kontrol k INNER JOIN musteriler m ON m.MusteriEposta=k.MusteriEposta";
                    command = new MySqlCommand(sorguKomutu3, sqlConnection);
                    dr = command.ExecuteReader();
                    dr.Read();
                    string musteriId = dr[0].ToString();
                    dr.Close();
                    mySqlCommand.Parameters.AddWithValue("@musteriId", musteriId);
                    mySqlCommand.Parameters.AddWithValue("@urunId", 2);
                    int i = mySqlCommand.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Ürün sepete eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Ürün sepete eklenirken bir hata oluştu.");
                    }
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen ilk önce giriş yapınız.");
            }
        }

        private void sepeteEkleBtn3_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiLabel.Text != "-")
            {
                using (sqlConnection = new MySqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    String sorguKomutu2 = "INSERT INTO sepet (MusteriId, UrunId) VALUES (@musteriId, @urunId)";
                    MySqlCommand mySqlCommand = new MySqlCommand(sorguKomutu2, sqlConnection);
                    String sorguKomutu3 = "SELECT m.MusteriId FROM kontrol k INNER JOIN musteriler m ON m.MusteriEposta=k.MusteriEposta";
                    command = new MySqlCommand(sorguKomutu3, sqlConnection);
                    dr = command.ExecuteReader();
                    dr.Read();
                    string musteriId = dr[0].ToString();
                    dr.Close();
                    mySqlCommand.Parameters.AddWithValue("@musteriId", musteriId);
                    mySqlCommand.Parameters.AddWithValue("@urunId", 3);
                    int i = mySqlCommand.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Ürün sepete eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Ürün sepete eklenirken bir hata oluştu.");
                    }
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen ilk önce giriş yapınız.");
            }
        }
    }
}
