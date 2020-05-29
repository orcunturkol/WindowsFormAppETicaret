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

namespace E_Ticaret
{
    public partial class AnaMenu : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;

        //Referanslar
        SqlConnection sqlConnection;

        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            using(sqlConnection = new SqlConnection(connectionString))
            {
                String sorguKomutu = "SELECT UrunAdi, UrunFotograf, UrunFiyati FROM Urunler WHERE UrunId=12";
                SqlCommand cmd = new SqlCommand(sorguKomutu, sqlConnection);
                sqlConnection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                
                if (dr.HasRows)
                {
                    fiyat1.Text = dr[2].ToString();
                    urunAdiLabel.Text = dr[0].ToString();
                    byte[] data = (byte[])dr[1];
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        katalogResmi1.Image = new Bitmap(stream);
                    }
                }
                sqlConnection.Close();
            }
        }

        static void UrunListele()
        {
            //string sorguMetni = "SELECT * FROM UrunFiyati WHERE @ "
        }

        private void yonetimPaneliButton_Click(object sender, EventArgs e)
        {
            YoneticiGiris yoneticiGiris = new YoneticiGiris();
            yoneticiGiris.Show();
        }
    }
}
