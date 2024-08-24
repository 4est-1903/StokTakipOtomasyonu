using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipOtomasyonu
{
    public partial class frmUrunListele : Form
    {
        public frmUrunListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet ds = new DataSet();
        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            KategoriGetir();

        }
        private void KategoriGetir()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM kategoribilgileri", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboKategori.Items.Add(oku["kategori"].ToString());
            }
            baglan.Close();
        }
        private void UrunListele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT *FROM urun", baglan);
            adtr.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            baglan.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMevcutBarkod.Text = dataGridView1.CurrentRow.Cells["barkod"].Value.ToString();
            txtMevcutKategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtMevcutMarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtMevcutUrunAdi.Text = dataGridView1.CurrentRow.Cells["urunad"].Value.ToString();
            txtMevcutMiktar.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            txtMevcutAlis.Text = dataGridView1.CurrentRow.Cells["alisfiyat"].Value.ToString();
            txtMevcutSatis.Text = dataGridView1.CurrentRow.Cells["satisfiyat"].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("UPDATE urun SET urunad = @urunad, miktar = @miktar, alisfiyat = @alisfiyat, satisfiyat = @satisfiyat WHERE barkod = @barkod",baglan);
            komut.Parameters.AddWithValue("@barkod",txtMevcutBarkod.Text);
            komut.Parameters.AddWithValue("@urunad", txtMevcutUrunAdi.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(txtMevcutMiktar.Text));
            komut.Parameters.AddWithValue("@alisfiyat", double.Parse(txtMevcutAlis.Text));
            komut.Parameters.AddWithValue("@satisfiyat", double.Parse(txtMevcutSatis.Text));
            komut.ExecuteNonQuery();
            baglan.Close();
            ds.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Güncelleme Başarılı");

            foreach (Control Item in this.Controls)
            {
                if (Item is TextBox)
                {
                    Item.Text = "";
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMevcutBarkod.Text != "")
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("UPDATE urun SET kategorei = @kategori, marka = @marka, WHERE barkod = @barkod", baglan);
                komut.Parameters.AddWithValue("@barkod", txtMevcutBarkod.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Güncelleme Başarılı");
                ds.Tables["urun"].Clear();
                UrunListele();

            }

            else
            {
                MessageBox.Show("Geçerli bir barkod numarası giriniz");
            }

            foreach (Control Item in this.Controls)
            {
                if (Item is ComboBox)
                {
                    Item.Text = "";
                }


            }

        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand($"SELECT *FROM markabilgileri where kategori = '{comboKategori.SelectedItem}'", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboMarka.Items.Add(oku["marka"].ToString());
            }
            baglan.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand($"DELETE FROM urun where barkod='{dataGridView1.CurrentRow.Cells["barkod"].Value.ToString()}'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            ds.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter($"SELECT *FROM urun where barkod like '%'{txtBarkodAra.Text}'%'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }
    }
}
