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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (txtMevcutBarkod.Text == "")
            {
                lblMiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }


            baglan.Open();
            SqlCommand komut = new SqlCommand($"SELECT *FROM urun WHERE barkod like '{txtMevcutBarkod.Text}'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtMevcutKategori.Text = oku["kategori"].ToString();
                txtMevcutMarka.Text = oku["marka"].ToString();
                txtMevcutUrunAdi.Text = oku["urunad"].ToString();
                lblMiktar.Text = oku["miktar"].ToString();
                txtMevcutAlis.Text = oku["alisfiyat"].ToString();
                txtMevcutSatis.Text = oku["satisfiyat"].ToString();

            }

            baglan.Close();
        }



        private void barkodengelle()
        {
            durum = true;
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM urun", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (txtYeniBarkod.Text == oku["barkod"].ToString() || txtYeniBarkod.Text == "")
                {
                    durum = false;
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            barkodengelle();
            if (durum == true)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO urun(barkod, kategori, marka, urunad, miktar, alisfiyat, satisfiyat, tarih) VALUES (@barkod, @kategori, @marka, @urunad, @miktar, @alisfiyat, @satisfiyat, @tarih) ", baglan);
                komut.Parameters.AddWithValue("@barkod", txtYeniBarkod.Text);
                komut.Parameters.AddWithValue("@kategori", comboYeniKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboYeniMarka.Text);
                komut.Parameters.AddWithValue("@urunad", txtYeniUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txtYeniMiktar.Text));
                komut.Parameters.AddWithValue("@alisfiyat", double.Parse(txtYeniAlis.Text));
                komut.Parameters.AddWithValue("@satisfiyat", double.Parse(txtYeniSatis.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Ürün Eklendi");
            }

            else
            {
                MessageBox.Show("Girmiş Olduğunuz Barkod Zaten Mevcut!");
            }
            
            comboYeniMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls) 
            {
                if (item is TextBox) 
                {
                    item.Text = "";
                }

                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        
        
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void KategoriGetir()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM kategoribilgileri", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboYeniKategori.Items.Add(oku["kategori"].ToString());
            }
            baglan.Close();
        }

        private void comboYeniMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboYeniKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboYeniMarka.Items.Clear();
            comboYeniMarka.Text = ""; 
            baglan.Open();
            SqlCommand komut = new SqlCommand($"SELECT *FROM markabilgileri where kategori = '{comboYeniKategori.SelectedItem}'", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboYeniMarka.Items.Add(oku["marka"].ToString());
            }
            baglan.Close();
        }

        private void btnMevcutEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand($"UPDATE  urun SET miktar= miktar '{int.Parse(txtMevcutMiktar.Text)}' WHERE barkod='{txtMevcutBarkod.Text}'",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Değişklik Kaydedildi");
        }
    }
}
