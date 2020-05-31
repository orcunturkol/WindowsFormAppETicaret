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
    public partial class Sepet : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;
        //Referanslar
        MySqlConnection sqlConnection;
        MySqlCommand command;
        MySqlDataReader dr;

        string musteriId;
        int i;
        public Sepet()
        {
            InitializeComponent();
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            SepetiListele();
        }

        private void SepetiListele()
        {
            using (sqlConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    String sorguKomutu3 = "SELECT m.MusteriId FROM kontrol k INNER JOIN musteriler m ON m.MusteriEposta=k.MusteriEposta";
                    command = new MySqlCommand(sorguKomutu3, sqlConnection);
                    dr = command.ExecuteReader();
                    dr.Read();
                     musteriId = dr[0].ToString();
                    dr.Close();

                    string sorgu = "SELECT s.SepetId, u.UrunId, u.UrunAdi, u.UrunFiyati FROM sepet s INNER JOIN urunler u ON u.UrunId = " +
                        "s.UrunId INNER JOIN musteriler m ON m.MusteriId = s.MusteriId WHERE m.MusteriId=@musteriId";
                    command = new MySqlCommand(sorgu);

                    command.Parameters.AddWithValue("@musteriId", musteriId);
                    MySqlDataAdapter dt = new MySqlDataAdapter();
                    command.Connection = sqlConnection;
                    
                    dt.SelectCommand = command;

                    DataTable dTable = new DataTable();
                    dt.Fill(dTable);
                    sepetimDataGrid.DataSource = dTable;
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (sqlConnection = new MySqlConnection(connectionString))
                {
                    int rowIndex = sepetimDataGrid.CurrentCell.RowIndex;
                    String sorgu3 = "DELETE FROM sepet WHERE SepetId=" + sepetimDataGrid.CurrentRow.Cells[0].Value.ToString();
                    command = new MySqlCommand(sorgu3, sqlConnection);
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
            SepetiListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                sqlConnection = new MySqlConnection(connectionString);
                sqlConnection.Open();
                for (int j = 0; j < sepetimDataGrid.Rows.Count; j++)
                {
                    string sorguKomutu3 = "INSERT INTO siparisler (MusteriId, UrunId) VALUES (@musteriId, @urunId)";
                    MySqlCommand mySqlCommand = new MySqlCommand(sorguKomutu3, sqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@musteriId", musteriId);
                    mySqlCommand.Parameters.AddWithValue("@urunId", sepetimDataGrid.Rows[j].Cells["UrunId"].Value);
                     i = mySqlCommand.ExecuteNonQuery();
                }
                if (i == 1)
                {
                    MessageBox.Show("Siparişiniz alındı");
                }
                else
                {
                    MessageBox.Show("Siparişiniz oluşturulurken bir hata oluştu.");
                }
            string sorguKomutu = "DELETE FROM sepet WHERE MusteriId=" + musteriId;
            command = new MySqlCommand(sorguKomutu, sqlConnection);
            command.ExecuteNonQuery();
                sqlConnection.Close();
            Siparisler siparisler = new Siparisler();
            siparisler.Show();
            this.Hide();
        }
    }
}
