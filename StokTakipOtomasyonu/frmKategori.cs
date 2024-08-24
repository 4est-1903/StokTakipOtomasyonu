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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void kategoriengelle()
        {
            durum = true;
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM kategoribilgileri", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (txtkategori.Text == oku["kategori"].ToString() || txtkategori.Text == "")
                {
                    durum = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();

            if (durum = true)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand($"INSERT INTO kategoribilgileri (kategori) VALUES ('{txtkategori.Text}')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                txtkategori.Clear();
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kategori Zaten Mevcut","UYARI!");
            }

            txtkategori.Text = "";

        }
    }
}
