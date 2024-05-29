﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YURT_KAYIT_SİSTEMLERİ
{
    public partial class FrmYoneticiİslemleri : Form
    {
        public FrmYoneticiİslemleri()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yURT_KAYITDataSet9.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Yönetici Eklendi");
            this.adminTableAdapter.Fill(this.yURT_KAYITDataSet9.Admin);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;

            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtKullaniciAd.Text = ad;
            TxtSifre.Text = sifre;
            TxtYoneticiid.Text = id;

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where Yoneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Silme işlemi Gerçekleşti");
            this.adminTableAdapter.Fill(this.yURT_KAYITDataSet9.Admin);


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("update Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where Yoneticiid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtYoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Güncelleme Gerçekleşti");
            this.adminTableAdapter.Fill(this.yURT_KAYITDataSet9.Admin);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
