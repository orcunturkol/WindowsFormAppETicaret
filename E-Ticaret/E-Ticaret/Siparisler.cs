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
    public partial class Siparisler : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;
        //Referanslar
        MySqlConnection sqlConnection;
        MySqlCommand command;
        MySqlDataReader dr;

        String musteriId;
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
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

                    string sorgu = "SELECT s.SiparisId, u.UrunAdi, u.UrunFiyati FROM urunler u INNER JOIN siparisler s ON u.UrunId = s.UrunId INNER JOIN musteriler m ON m.MusteriId = s.MusteriId WHERE m.MusteriId=@musteriId";
                    command = new MySqlCommand(sorgu);
                    command.Parameters.AddWithValue("@musteriId", musteriId);
                    MySqlDataAdapter dt = new MySqlDataAdapter();
                    command.Connection = sqlConnection;
                    dt.SelectCommand = command;

                    DataTable dTable = new DataTable();
                    dt.Fill(dTable);
                    siparislerDtgw.DataSource = dTable;
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
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}
