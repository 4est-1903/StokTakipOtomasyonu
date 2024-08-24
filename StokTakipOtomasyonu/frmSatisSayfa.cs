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

namespace StokTakipOtomasyonu
{
    public partial class frmSatisSayfa : Form
    {
        public frmSatisSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet ds = new DataSet();

        private void SepetListele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT *FROM sepet",baglan);
            adtr.Fill(ds,"sepet");
            dataGridView1.DataSource = ds.Tables["sepet"];
            baglan.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hesapla()
        {
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("SELECT SUM (toplamfiyat) FROM sepet",baglan);
                lblgeneltoplam.Text = komut.ExecuteScalar() + " TL";
                baglan.Close();

            }
            catch (Exception)
            {


                ;
            }

        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void btnmusterilistele_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            frmUrunEkle urunekle = new frmUrunEkle();
            urunekle.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void frmSatisSayfa_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void btnurunlistele_Click(object sender, EventArgs e)
        {
            frmUrunListele urunlistele = new frmUrunListele();
            urunlistele.ShowDialog();
        }

        private void txttckimlik_TextChanged(object sender, EventArgs e)
        {
            if (txttckimlik.Text == "")
            {
                txtadsoyad.Text = "";
                txttelefon.Text = "";
            }


            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM müşteri WHERE tc LIKE '"+txttckimlik.Text+"' ",baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtadsoyad.Text = oku["adsoyad"].ToString();
                txttelefon.Text = oku["telefon"].ToString();

            }
            baglan.Close();
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM urun WHERE barkod LIKE '" + txtbarkod.Text + "' ", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txturunad.Text = oku["urunad"].ToString();
                txtsatisfiyat.Text = oku["satisfiyat"].ToString();

            }
            baglan.Close();

        }

        private void Temizle()
        {
            if (txtbarkod.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {


                        if (item != txturunmiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }
        bool durum;

        private void BarkodKontrol()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT *FROM sepet", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (txtbarkod.Text == oku["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglan.Close();
        } 

        private void btnekle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();

            if (durum == true)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO sepet(tc, adsoyad, telefon, barkod, urunad, miktar, satisfiyat, toplamfiyat, tarih) VALUES(@tc, @adsoyad, @telefon, @barkod, @urunad, @miktar, @satisfiyat, @toplamfiyat, @tarih)", baglan);
                komut.Parameters.AddWithValue("@tc", txttckimlik.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@barkod", txtbarkod.Text);
                komut.Parameters.AddWithValue("@urunad", txturunad.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txturunmiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyat", double.Parse(txtsatisfiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txttoplamfiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand komut2 = new SqlCommand("UPDATE sepet SET miktar = miktar+'"+int.Parse(txturunmiktar.Text)+ "' WHERE barkod = '"+txtbarkod.Text+"' ", baglan);
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("UPDATE sepet SET toplamfiyat = miktar * satisfiyat WHERE barkod = '"+txtbarkod.Text+"' ", baglan);
                komut3.ExecuteNonQuery();

                baglan.Close();
            }
            txturunmiktar.Text = "1";
            ds.Tables["sepet"].Clear();
            SepetListele();
            Temizle();
            Hesapla();

        }

        private void txturunmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txturunmiktar.Text) * double.Parse(txtsatisfiyat.Text)).ToString();
            }

            catch (Exception)
            {
                ;
            }
        }

        private void txtsatisfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txturunmiktar.Text) * double.Parse(txtsatisfiyat.Text)).ToString();
            }

            catch (Exception)
            {
                ;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM sepet WHERE barkod = '" + dataGridView1.CurrentRow.Cells["barkod"].Value.ToString() +"' ",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            Hesapla();
            MessageBox.Show("Ürün sepetten çıkarıldı");
            ds.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();

        }

        private void btnsatisiptal_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM sepet  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı");
            ds.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsatislistele_Click(object sender, EventArgs e)
        {
            frmSatisListele liste = new frmSatisListele();
            liste.ShowDialog();
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglan.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO satis(tc, adsoyad, telefon, barkod, urunad, miktar, satisfiyat, toplamfiyat, tarih) VALUES(@tc, @adsoyad, @telefon, @barkod, @urunad, @miktar, @satisfiyat, @toplamfiyat, @tarih)", baglan);
                komut1.Parameters.AddWithValue("@tc", txttckimlik.Text);
                komut1.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                komut1.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut1.Parameters.AddWithValue("@barkod", dataGridView1.Rows[i].Cells["barkod"].Value.ToString());
                komut1.Parameters.AddWithValue("@urunad", dataGridView1.Rows[i].Cells["urunad"].Value.ToString());
                komut1.Parameters.AddWithValue("@miktar", int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()));
                komut1.Parameters.AddWithValue("@satisfiyat", double.Parse(dataGridView1.Rows[i].Cells["satisfiyat"].Value.ToString()));
                komut1.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut1.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut1.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand($"UPDATE  urun SET miktar= miktar-'{int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString())}' WHERE barkod='{dataGridView1.Rows[i].Cells["barkod"].Value.ToString()}'", baglan);
                komut2.ExecuteNonQuery();
                baglan.Close();

             
            }
            baglan.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM sepet  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();

            ds.Tables["sepet"].Clear();
            SepetListele();
            Hesapla();
        }
    }
}
