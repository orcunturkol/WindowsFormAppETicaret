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
    public partial class YonetimPaneli : Form
    {
        //Bağlantı Metni
        String connectionString = ConfigurationManager.ConnectionStrings["ETicaretVeriTabani"].ConnectionString;

        //Referanslar
        SqlConnection sqlConnection;
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void fotografSectirme()
        {
            using(sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    string fotograflarim = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    ofd.Filter = "...";
                    ofd.FileName = "Lütfen bir fotoğraf seçiniz.";
                    ofd.Title = "Fotoğraf seç..";
                    ofd.AddExtension = true;
                    ofd.FilterIndex = 0;
                    ofd.Multiselect = false;
                    ofd.ValidateNames = true;
                    ofd.InitialDirectory = fotograflarim;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        urunFotografi.Image = Image.FromFile(ofd.FileName);
                    }
                }
                catch 
                {
                    MessageBox.Show("Error : Something went wrong.", "Choose image : ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void YonetimPaneli_Load(object sender, EventArgs e)
        {

        }

        private void urunFotografiButton_Click(object sender, EventArgs e)
        {
            fotografSectirme();
        }
    }
}
