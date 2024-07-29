using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmsatissayfa : Form
    {
        public frmsatissayfa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void btnmusterilistele_Click(object sender, EventArgs e)
        {
            frmmusterilistele listele = new frmmusterilistele();
            listele.ShowDialog();
        }
    }
}
