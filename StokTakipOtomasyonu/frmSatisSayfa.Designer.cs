namespace StokTakipOtomasyonu
{
    partial class frmSatisSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txttckimlik = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttoplamfiyat = new System.Windows.Forms.TextBox();
            this.txtsatisfiyat = new System.Windows.Forms.TextBox();
            this.txturunmiktar = new System.Windows.Forms.TextBox();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.btnsatisiptal = new System.Windows.Forms.Button();
            this.lblgeneltoplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnsatislistele = new System.Windows.Forms.Button();
            this.btnurunlistele = new System.Windows.Forms.Button();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.btnmusterilistele = new System.Windows.Forms.Button();
            this.btnmusteriekle = new System.Windows.Forms.Button();
            this.stok_TakipDataSet = new StokTakipOtomasyonu.Stok_TakipDataSet();
            this.stokTakipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(520, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txttelefon);
            this.groupBox1.Controls.Add(this.txtadsoyad);
            this.groupBox1.Controls.Add(this.txttckimlik);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(61, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(134, 112);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(226, 33);
            this.txttelefon.TabIndex = 2;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(134, 71);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(226, 33);
            this.txtadsoyad.TabIndex = 1;
            // 
            // txttckimlik
            // 
            this.txttckimlik.Location = new System.Drawing.Point(134, 32);
            this.txttckimlik.Name = "txttckimlik";
            this.txttckimlik.Size = new System.Drawing.Size(226, 33);
            this.txttckimlik.TabIndex = 0;
            this.txttckimlik.TextChanged += new System.EventHandler(this.txttckimlik_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txttoplamfiyat);
            this.groupBox2.Controls.Add(this.txtsatisfiyat);
            this.groupBox2.Controls.Add(this.txturunmiktar);
            this.groupBox2.Controls.Add(this.txturunad);
            this.groupBox2.Controls.Add(this.txtbarkod);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(61, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 247);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Satış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ürün Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod No:";
            // 
            // txttoplamfiyat
            // 
            this.txttoplamfiyat.Location = new System.Drawing.Point(134, 200);
            this.txttoplamfiyat.Name = "txttoplamfiyat";
            this.txttoplamfiyat.Size = new System.Drawing.Size(226, 33);
            this.txttoplamfiyat.TabIndex = 5;
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Location = new System.Drawing.Point(134, 161);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(226, 33);
            this.txtsatisfiyat.TabIndex = 4;
            this.txtsatisfiyat.TextChanged += new System.EventHandler(this.txtsatisfiyat_TextChanged);
            // 
            // txturunmiktar
            // 
            this.txturunmiktar.Location = new System.Drawing.Point(134, 122);
            this.txturunmiktar.Name = "txturunmiktar";
            this.txturunmiktar.Size = new System.Drawing.Size(226, 33);
            this.txturunmiktar.TabIndex = 3;
            this.txturunmiktar.Text = "1";
            this.txturunmiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txturunmiktar.TextChanged += new System.EventHandler(this.txturunmiktar_TextChanged);
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(134, 83);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(226, 33);
            this.txturunad.TabIndex = 2;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(134, 44);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(226, 33);
            this.txtbarkod.TabIndex = 1;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(690, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 30);
            this.label9.TabIndex = 3;
            this.label9.Text = "Genel Toplam:";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DimGray;
            this.btnekle.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.LightCyan;
            this.btnekle.Location = new System.Drawing.Point(520, 629);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(154, 43);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DimGray;
            this.btnsil.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.LightCyan;
            this.btnsil.Location = new System.Drawing.Point(680, 629);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(154, 43);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.BackColor = System.Drawing.Color.DimGray;
            this.btnsatisyap.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatisyap.ForeColor = System.Drawing.Color.LightCyan;
            this.btnsatisyap.Location = new System.Drawing.Point(840, 629);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(154, 43);
            this.btnsatisyap.TabIndex = 7;
            this.btnsatisyap.Text = "Satış Yap";
            this.btnsatisyap.UseVisualStyleBackColor = false;
            this.btnsatisyap.Click += new System.EventHandler(this.btnsatisyap_Click);
            // 
            // btnsatisiptal
            // 
            this.btnsatisiptal.BackColor = System.Drawing.Color.DimGray;
            this.btnsatisiptal.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatisiptal.ForeColor = System.Drawing.Color.LightCyan;
            this.btnsatisiptal.Location = new System.Drawing.Point(1000, 629);
            this.btnsatisiptal.Name = "btnsatisiptal";
            this.btnsatisiptal.Size = new System.Drawing.Size(154, 43);
            this.btnsatisiptal.TabIndex = 8;
            this.btnsatisiptal.Text = "Satış İptal";
            this.btnsatisiptal.UseVisualStyleBackColor = false;
            this.btnsatisiptal.Click += new System.EventHandler(this.btnsatisiptal_Click);
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.AutoSize = true;
            this.lblgeneltoplam.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgeneltoplam.Location = new System.Drawing.Point(840, 567);
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Size = new System.Drawing.Size(0, 30);
            this.lblgeneltoplam.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnsatislistele);
            this.panel1.Controls.Add(this.btnurunlistele);
            this.panel1.Controls.Add(this.btnurunekle);
            this.panel1.Controls.Add(this.btnmusterilistele);
            this.panel1.Controls.Add(this.btnmusteriekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 100);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMarka
            // 
            this.btnMarka.BackColor = System.Drawing.Color.Silver;
            this.btnMarka.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarka.ForeColor = System.Drawing.Color.Black;
            this.btnMarka.Location = new System.Drawing.Point(1058, 55);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(170, 37);
            this.btnMarka.TabIndex = 12;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = false;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.Silver;
            this.btnKategori.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.ForeColor = System.Drawing.Color.Black;
            this.btnKategori.Location = new System.Drawing.Point(1058, 12);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(170, 37);
            this.btnKategori.TabIndex = 11;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnsatislistele
            // 
            this.btnsatislistele.BackColor = System.Drawing.Color.Silver;
            this.btnsatislistele.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatislistele.ForeColor = System.Drawing.Color.Black;
            this.btnsatislistele.Location = new System.Drawing.Point(845, 24);
            this.btnsatislistele.Name = "btnsatislistele";
            this.btnsatislistele.Size = new System.Drawing.Size(154, 43);
            this.btnsatislistele.TabIndex = 10;
            this.btnsatislistele.Text = "Satış Listeleme";
            this.btnsatislistele.UseVisualStyleBackColor = false;
            this.btnsatislistele.Click += new System.EventHandler(this.btnsatislistele_Click);
            // 
            // btnurunlistele
            // 
            this.btnurunlistele.BackColor = System.Drawing.Color.Silver;
            this.btnurunlistele.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurunlistele.ForeColor = System.Drawing.Color.Black;
            this.btnurunlistele.Location = new System.Drawing.Point(680, 25);
            this.btnurunlistele.Name = "btnurunlistele";
            this.btnurunlistele.Size = new System.Drawing.Size(154, 43);
            this.btnurunlistele.TabIndex = 9;
            this.btnurunlistele.Text = "Ürün Listeleme";
            this.btnurunlistele.UseVisualStyleBackColor = false;
            this.btnurunlistele.Click += new System.EventHandler(this.btnurunlistele_Click);
            // 
            // btnurunekle
            // 
            this.btnurunekle.BackColor = System.Drawing.Color.Silver;
            this.btnurunekle.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurunekle.ForeColor = System.Drawing.Color.Black;
            this.btnurunekle.Location = new System.Drawing.Point(495, 25);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(154, 43);
            this.btnurunekle.TabIndex = 8;
            this.btnurunekle.Text = "Ürün Ekleme";
            this.btnurunekle.UseVisualStyleBackColor = false;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // btnmusterilistele
            // 
            this.btnmusterilistele.BackColor = System.Drawing.Color.Silver;
            this.btnmusterilistele.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusterilistele.ForeColor = System.Drawing.Color.Black;
            this.btnmusterilistele.Location = new System.Drawing.Point(251, 24);
            this.btnmusterilistele.Name = "btnmusterilistele";
            this.btnmusterilistele.Size = new System.Drawing.Size(154, 43);
            this.btnmusterilistele.TabIndex = 7;
            this.btnmusterilistele.Text = "Müşteri Listeleme";
            this.btnmusterilistele.UseVisualStyleBackColor = false;
            this.btnmusterilistele.Click += new System.EventHandler(this.btnmusterilistele_Click);
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.BackColor = System.Drawing.Color.Silver;
            this.btnmusteriekle.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusteriekle.ForeColor = System.Drawing.Color.Black;
            this.btnmusteriekle.Location = new System.Drawing.Point(61, 24);
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(154, 43);
            this.btnmusteriekle.TabIndex = 6;
            this.btnmusteriekle.Text = "Müşteri Ekleme";
            this.btnmusteriekle.UseVisualStyleBackColor = false;
            this.btnmusteriekle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // stok_TakipDataSet
            // 
            this.stok_TakipDataSet.DataSetName = "Stok_TakipDataSet";
            this.stok_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokTakipDataSetBindingSource
            // 
            this.stokTakipDataSetBindingSource.DataSource = this.stok_TakipDataSet;
            this.stokTakipDataSetBindingSource.Position = 0;
            // 
            // frmSatisSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1240, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblgeneltoplam);
            this.Controls.Add(this.btnsatisiptal);
            this.Controls.Add(this.btnsatisyap);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatisSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatisSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txttckimlik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttoplamfiyat;
        private System.Windows.Forms.TextBox txtsatisfiyat;
        private System.Windows.Forms.TextBox txturunmiktar;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Button btnsatisiptal;
        private System.Windows.Forms.Label lblgeneltoplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsatislistele;
        private System.Windows.Forms.Button btnurunlistele;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button btnmusterilistele;
        private System.Windows.Forms.Button btnmusteriekle;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.BindingSource stokTakipDataSetBindingSource;
        private Stok_TakipDataSet stok_TakipDataSet;
    }
}

