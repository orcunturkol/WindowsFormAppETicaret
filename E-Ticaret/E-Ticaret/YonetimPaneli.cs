using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Ticaret
{
    public partial class YonetimPaneli : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;
        //Referanslar
        SqlConnection sqlConnection;
        SqlCommand cmd;
        byte[] data;
        //Değişkenler
        String fileName;
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void fotografSectirme()
        {
            //Bilgisayarımızdan bir dosya seçebilmek için FileDialog nesnesini kullanıyoruz
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {             
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    dosyaAdiLabel.Text = fileName;
                    urunFotografi.Image = Image.FromFile(fileName);
                }
            }
        }
        void fotografCevir()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image myImage = Image.FromFile(dosyaAdiLabel.Text);
                myImage.Save(ms, ImageFormat.Bmp);
                data = ms.ToArray();
            }
        }

        private void urunuYukle()
        {
            using(sqlConnection = new SqlConnection(connectionString))
            {
                string sorguKomutu = "INSERT INTO Urunler (UrunAdi, StokSayisi, KategoriId, UrunFotograf, UrunFiyati) VALUES (@urunAdi, @stokSayisi, @kategoriId, '@urunFotograf', @urunFiyati)";
                cmd = new SqlCommand(sorguKomutu, sqlConnection);
                //Sorgudaki parametleri tanımlama
                cmd.Parameters.AddWithValue("@urunAdi", urunAdiTextBox.Text);
                cmd.Parameters.AddWithValue("@stokSayisi", Convert.ToInt32(stokSayisiTextBox.Text));
                cmd.Parameters.AddWithValue("@kategoriId", Convert.ToInt32(kategoriComboBox.Text));
                //Yüklenen resmi binary'e çevirme metodunu kullanıldı
                fotografCevir();
                cmd.Parameters.AddWithValue("@urunFotograf", data);
                cmd.Parameters.AddWithValue("@urunFiyati", Convert.ToDecimal(urunFiyatıTextBox.Text));
                try
                {
                    sqlConnection.Open();
                    int kontrol = cmd.ExecuteNonQuery();
                    if (kontrol > 0) MessageBox.Show("Ürünleriniz başarıyla veritabanına yüklendi");
                    else MessageBox.Show("Ürünleriniz veritabanına yüklenirken bir hata ile karşılaşıldı. Lütfen tekrar deneyiniz");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı: " + e.Message);;
                }                  
                sqlConnection.Close();
            }
        }
        private void YonetimPaneli_Load(object sender, EventArgs e)
        {
            
        }

        private void urunFotografiButton_Click(object sender, EventArgs e)
        {
            fotografSectirme();
        }

        private void yukleButton_Click(object sender, EventArgs e)
        {
            urunuYukle();
        }
    }
}
