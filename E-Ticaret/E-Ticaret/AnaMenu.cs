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

        private void yonetimPaneliButton_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            yoneticiGiris.Show();
        }
    }
}
