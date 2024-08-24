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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void KayitGoster()
        {
            baglan.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT *FROM müşteri", baglan);
            adapter.Fill(ds,"müşteri");
            dataGridView1.DataSource = ds.Tables["müşteri"];
            baglan.Close();
            ds.Tables["müşteri"].Clear();
            KayitGoster();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txttckimlik.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txteposta.Text = dataGridView1.CurrentRow.Cells["eposta"].Value.ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("UPDATE müşteri set adsoyad=@adsoyad, telefon=@telefon, adres=@adres, eposta=@eposta where tc=@tc", baglan);

            komut.Parameters.AddWithValue("@tc", txttckimlik.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@eposta", txteposta.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Müşteri Kaydı Güncellendi");

            foreach (Control Item in this.Controls)
            {
                if (Item is TextBox)
                {
                    Item.Text = "";
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand($"DELETE FROM müşteri where tc='{dataGridView1.CurrentRow.Cells["tc"].Value.ToString()}'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            ds.Tables["müşteri"].Clear();
            KayitGoster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtTCara_TextChanged(object sender, EventArgs e)
        {

            DataTable tablo = new DataTable();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter($"SELECT *FROM müşteri where tc like '%{txtTCara.Text}%'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttckimlik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
