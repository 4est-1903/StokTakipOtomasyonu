﻿namespace StokTakipOtomasyonu
{
    partial class frmUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYeniBarkod = new System.Windows.Forms.TextBox();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.txtYeniAlis = new System.Windows.Forms.TextBox();
            this.txtYeniMiktar = new System.Windows.Forms.TextBox();
            this.txtYeniSatis = new System.Windows.Forms.TextBox();
            this.txtMevcutBarkod = new System.Windows.Forms.TextBox();
            this.txtMevcutKategori = new System.Windows.Forms.TextBox();
            this.txtMevcutMarka = new System.Windows.Forms.TextBox();
            this.txtMevcutUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMevcutMiktar = new System.Windows.Forms.TextBox();
            this.txtMevcutAlis = new System.Windows.Forms.TextBox();
            this.txtMevcutSatis = new System.Windows.Forms.TextBox();
            this.comboYeniKategori = new System.Windows.Forms.ComboBox();
            this.comboYeniMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.btnMevcutEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnYeniEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboYeniMarka);
            this.groupBox1.Controls.Add(this.comboYeniKategori);
            this.groupBox1.Controls.Add(this.txtYeniSatis);
            this.groupBox1.Controls.Add(this.txtYeniMiktar);
            this.groupBox1.Controls.Add(this.txtYeniAlis);
            this.groupBox1.Controls.Add(this.txtYeniUrunAdi);
            this.groupBox1.Controls.Add(this.txtYeniBarkod);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(114, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMiktar);
            this.groupBox2.Controls.Add(this.btnMevcutEkle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMevcutSatis);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMevcutAlis);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMevcutBarkod);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMevcutMiktar);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMevcutKategori);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtMevcutUrunAdi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtMevcutMarka);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(652, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 468);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mevcut Ürün";
            // 
            // txtYeniBarkod
            // 
            this.txtYeniBarkod.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniBarkod.Location = new System.Drawing.Point(174, 61);
            this.txtYeniBarkod.Name = "txtYeniBarkod";
            this.txtYeniBarkod.Size = new System.Drawing.Size(205, 38);
            this.txtYeniBarkod.TabIndex = 0;
            this.txtYeniBarkod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtYeniUrunAdi
            // 
            this.txtYeniUrunAdi.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniUrunAdi.Location = new System.Drawing.Point(174, 178);
            this.txtYeniUrunAdi.Name = "txtYeniUrunAdi";
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(205, 38);
            this.txtYeniUrunAdi.TabIndex = 1;
            this.txtYeniUrunAdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtYeniAlis
            // 
            this.txtYeniAlis.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniAlis.Location = new System.Drawing.Point(174, 264);
            this.txtYeniAlis.Name = "txtYeniAlis";
            this.txtYeniAlis.Size = new System.Drawing.Size(205, 38);
            this.txtYeniAlis.TabIndex = 2;
            this.txtYeniAlis.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtYeniMiktar
            // 
            this.txtYeniMiktar.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniMiktar.Location = new System.Drawing.Point(174, 221);
            this.txtYeniMiktar.Name = "txtYeniMiktar";
            this.txtYeniMiktar.Size = new System.Drawing.Size(205, 38);
            this.txtYeniMiktar.TabIndex = 3;
            this.txtYeniMiktar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtYeniSatis
            // 
            this.txtYeniSatis.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSatis.Location = new System.Drawing.Point(174, 307);
            this.txtYeniSatis.Name = "txtYeniSatis";
            this.txtYeniSatis.Size = new System.Drawing.Size(205, 38);
            this.txtYeniSatis.TabIndex = 4;
            // 
            // txtMevcutBarkod
            // 
            this.txtMevcutBarkod.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutBarkod.Location = new System.Drawing.Point(177, 59);
            this.txtMevcutBarkod.Name = "txtMevcutBarkod";
            this.txtMevcutBarkod.Size = new System.Drawing.Size(205, 38);
            this.txtMevcutBarkod.TabIndex = 5;
            this.txtMevcutBarkod.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtMevcutKategori
            // 
            this.txtMevcutKategori.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutKategori.Location = new System.Drawing.Point(177, 100);
            this.txtMevcutKategori.Name = "txtMevcutKategori";
            this.txtMevcutKategori.Size = new System.Drawing.Size(205, 38);
            this.txtMevcutKategori.TabIndex = 6;
            this.txtMevcutKategori.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtMevcutMarka
            // 
            this.txtMevcutMarka.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutMarka.Location = new System.Drawing.Point(177, 141);
            this.txtMevcutMarka.Name = "txtMevcutMarka";
            this.txtMevcutMarka.Size = new System.Drawing.Size(205, 38);
            this.txtMevcutMarka.TabIndex = 7;
            this.txtMevcutMarka.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtMevcutUrunAdi
            // 
            this.txtMevcutUrunAdi.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutUrunAdi.Location = new System.Drawing.Point(177, 182);
            this.txtMevcutUrunAdi.Name = "txtMevcutUrunAdi";
            this.txtMevcutUrunAdi.Size = new System.Drawing.Size(205, 38);
            this.txtMevcutUrunAdi.TabIndex = 8;
            this.txtMevcutUrunAdi.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtMevcutMiktar
            // 
            this.txtMevcutMiktar.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutMiktar.Location = new System.Drawing.Point(177, 223);
            this.txtMevcutMiktar.Name = "txtMevcutMiktar";
            this.txtMevcutMiktar.Size = new System.Drawing.Size(205, 38);
            this.txtMevcutMiktar.TabIndex = 9;
            this.txtMevcutMiktar.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtMevcutAlis
            // 
            this.txtMevcutAlis.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutAlis.Location = new System.Drawing.Point(177, 264);
            this.txtMevcutAlis.Name = "txtMevcutAlis";
            this.txtMevcutAlis.Size = new System.Drawing.Size(205, 38);
            this.txtMevcutAlis.TabIndex = 10;
            this.txtMevcutAlis.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtMevcutSatis
            // 
            this.txtMevcutSatis.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutSatis.Location = new System.Drawing.Point(177, 305);
            this.txtMevcutSatis.Name = "txtMevcutSatis";
            this.txtMevcutSatis.Size = new System.Drawing.Size(205, 38);
            this.txtMevcutSatis.TabIndex = 11;
            this.txtMevcutSatis.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // comboYeniKategori
            // 
            this.comboYeniKategori.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboYeniKategori.FormattingEnabled = true;
            this.comboYeniKategori.Location = new System.Drawing.Point(174, 102);
            this.comboYeniKategori.Name = "comboYeniKategori";
            this.comboYeniKategori.Size = new System.Drawing.Size(205, 33);
            this.comboYeniKategori.TabIndex = 5;
            this.comboYeniKategori.SelectedIndexChanged += new System.EventHandler(this.comboYeniKategori_SelectedIndexChanged);
            // 
            // comboYeniMarka
            // 
            this.comboYeniMarka.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboYeniMarka.FormattingEnabled = true;
            this.comboYeniMarka.Location = new System.Drawing.Point(174, 140);
            this.comboYeniMarka.Name = "comboYeniMarka";
            this.comboYeniMarka.Size = new System.Drawing.Size(205, 33);
            this.comboYeniMarka.TabIndex = 6;
            this.comboYeniMarka.SelectedIndexChanged += new System.EventHandler(this.comboYeniMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Satış Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ürün Adı:";
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.BackColor = System.Drawing.Color.White;
            this.btnYeniEkle.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniEkle.ForeColor = System.Drawing.Color.Black;
            this.btnYeniEkle.Location = new System.Drawing.Point(83, 400);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(222, 46);
            this.btnYeniEkle.TabIndex = 2;
            this.btnYeniEkle.Text = "Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = false;
            this.btnYeniEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMevcutEkle
            // 
            this.btnMevcutEkle.BackColor = System.Drawing.Color.White;
            this.btnMevcutEkle.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMevcutEkle.ForeColor = System.Drawing.Color.Black;
            this.btnMevcutEkle.Location = new System.Drawing.Point(85, 400);
            this.btnMevcutEkle.Name = "btnMevcutEkle";
            this.btnMevcutEkle.Size = new System.Drawing.Size(222, 46);
            this.btnMevcutEkle.TabIndex = 3;
            this.btnMevcutEkle.Text = "Ekle";
            this.btnMevcutEkle.UseVisualStyleBackColor = false;
            this.btnMevcutEkle.Click += new System.EventHandler(this.btnMevcutEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(-5, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ürün Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(-5, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Satış Fiyatı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(-5, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Alış Fiyatı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(-5, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Miktarı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(-5, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Marka:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(-5, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Kategori:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(-5, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Barkod Numarası:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(186, 363);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(0, 25);
            this.lblMiktar.TabIndex = 21;
            this.lblMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1259, 716);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme Sayfası";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboYeniKategori;
        private System.Windows.Forms.TextBox txtYeniSatis;
        private System.Windows.Forms.TextBox txtYeniMiktar;
        private System.Windows.Forms.TextBox txtYeniAlis;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.TextBox txtYeniBarkod;
        private System.Windows.Forms.TextBox txtMevcutSatis;
        private System.Windows.Forms.TextBox txtMevcutAlis;
        private System.Windows.Forms.TextBox txtMevcutBarkod;
        private System.Windows.Forms.TextBox txtMevcutMiktar;
        private System.Windows.Forms.TextBox txtMevcutKategori;
        private System.Windows.Forms.TextBox txtMevcutUrunAdi;
        private System.Windows.Forms.TextBox txtMevcutMarka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYeniMarka;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnMevcutEkle;
        private System.Windows.Forms.Label lblMiktar;
    }
}