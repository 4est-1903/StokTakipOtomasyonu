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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void frmMarka_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM kategoribilgileri",baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboKategori.Items.Add(oku["kategori"].ToString());
            }
            baglan.Close();
        }
        private void markaengelle()
        {
            durum = true;
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM markabilgileri", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (comboKategori.Text==oku["kategori"].ToString() && txtMarka.Text == oku["marka"].ToString() || txtMarka.Text == "")
                {
                    durum = false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (durum == true)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand($"insert into markabilgileri (kategori, marka) values ('{comboKategori.Text}','{txtMarka.Text}')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Marka Eklendi");
            }

            else
            {
                MessageBox.Show("Girdiğiniz Marka Zaten Mevcut", "UYARI!");
            }

            txtMarka.Clear();
            comboKategori.Text = "";
            
        }
    }
}
