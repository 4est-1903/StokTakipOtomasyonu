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
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FOREST;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet ds = new DataSet();

        private void SatisListele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT *FROM satis", baglan);
            adtr.Fill(ds, "satis");
            dataGridView1.DataSource = ds.Tables["satis"];
            baglan.Close();
        }

        private void frnSatisListele_Load(object sender, EventArgs e)
        {

        }
    }
}
