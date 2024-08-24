using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipOtomasyonu
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void btntemizle_Click(object sender, EventArgs e)
        {
            txttckimlik.Clear();
            txtadsoyad.Clear();
            txttelefon.Clear();
            txtadres.Clear();
            txteposta.Clear();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO müşteri(tc,adsoyad,telefon,adres,eposta) VALUES(@tc,@adsoyad,@telefon,@adres,@eposta)", baglan);
            komut.Parameters.AddWithValue("@tc", txttckimlik.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@eposta", txteposta.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Müşteri Kaydı Eklendi");

            foreach (Control Item in this.Controls)
            {
                if (Item is TextBox)
                {
                    Item.Text = "";
                }
            }
        }
    }
}
