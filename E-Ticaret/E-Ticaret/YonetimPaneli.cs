using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;

namespace E_Ticaret
{
    public partial class YonetimPaneli : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;
        //Referanslar
        MySqlConnection sqlConnection;
        MySqlCommand cmd;
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

       
        private void YonetimPaneli_Load(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM Kategoriler";
                using (sqlConnection = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sorgu, sqlConnection);
                    sqlConnection.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Kategori");
                    kategoriComboBox.DisplayMember = "KategoriAdi";
                    kategoriComboBox.ValueMember = "KategoriId";
                    kategoriComboBox.DataSource = ds.Tables["Kategori"];
                }
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }

            Listele();

        }

        private void Listele()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    string sorgu2 = "SELECT UrunId, UrunAdi, StokSayisi FROM Urunler";
                    cmd = new MySqlCommand(sorgu2);
                    MySqlDataAdapter dt = new MySqlDataAdapter();
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    dt.SelectCommand = cmd;

                    DataTable dTable = new DataTable();
                    dt.Fill(dTable);
                    urunlerDataGridView.DataSource = dTable;
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    //     
                }
            }
        }

        private void urunFotografiButton_Click(object sender, EventArgs e)
        {
            //Bilgisayarımızdan bir dosya seçebilmek için FileDialog nesnesini kullanıyoruz
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                urunFotografi.Image = Image.FromFile(opf.FileName);
            }

        }

        private void yukleButton_Click(object sender, EventArgs e)
        {
            //Seçilen fotoğraf byte formatına çeviriliyor
            sqlConnection = new MySqlConnection(connectionString);
            MemoryStream ms = new MemoryStream();
            urunFotografi.Image.Save(ms, urunFotografi.Image.RawFormat);
            byte[] img = ms.ToArray();

            String sorgu = "INSERT INTO Urunler(UrunAdi, UrunFiyati, StokSayisi, UrunFotograf) VALUES(@urunAdi, @urunFiyati, @stokSayisi, @img)";

            sqlConnection.Open();

            cmd = new MySqlCommand(sorgu, sqlConnection);

            cmd.Parameters.Add("@urunAdi", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("@urunFiyati", MySqlDbType.Double);
            cmd.Parameters.Add("@stokSayisi", MySqlDbType.Int32);
            cmd.Parameters.Add("@img", MySqlDbType.Blob);

            cmd.Parameters["@UrunAdi"].Value = urunAdiTextBox.Text;
            cmd.Parameters["@UrunFiyati"].Value = Convert.ToDouble(urunFiyatıTextBox.Text);
            cmd.Parameters["@StokSayisi"].Value = Convert.ToInt32(stokSayisiTextBox.Text);
            cmd.Parameters["@img"].Value = img;

            try
            {
             if (cmd.ExecuteNonQuery() == 1) MessageBox.Show("Ürün, veritabanına başarıyla eklendi.");
             else MessageBox.Show("Başarısız. Lütfen tekrar deneyiniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            sqlConnection.Close();
            Listele();
        }

        private void urunFiyatıTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (sqlConnection = new MySqlConnection(connectionString))
                {
                    int rowIndex = urunlerDataGridView.CurrentCell.RowIndex;
                    String sorgu3 = "DELETE FROM Urunler WHERE UrunId="+ urunlerDataGridView.CurrentRow.Cells[0].Value.ToString();
                    cmd = new MySqlCommand(sorgu3, sqlConnection);
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
        
            }
                    Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}
