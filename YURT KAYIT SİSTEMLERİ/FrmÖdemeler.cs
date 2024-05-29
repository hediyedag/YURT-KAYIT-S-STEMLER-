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

namespace YURT_KAYIT_SİSTEMLERİ
{
    public partial class FrmÖdemeler : Form
    {
        public FrmÖdemeler()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

          SqlBaglantim bgl=new SqlBaglantim();
        private void FrmÖdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yURT_KAYITDataSet6.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter2.Fill(this.yURT_KAYITDataSet6.Borclar);
            // TODO: Bu kod satırı 'yURT_KAYITDataSet5.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yURT_KAYITDataSet5.Borclar);
            // TODO: Bu kod satırı 'yURT_KAYITDataSet4.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yURT_KAYITDataSet4.Borclar);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, adı, soyadı, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adı = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadı = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtAdı.Text = adı;
            TxtSoyadı.Text=soyadı;
            TxtKalan.Text = kalan;
            TxtOgrid.Text = id;

        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            //odenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen=Convert.ToInt16( TxtOdenen.Text);
            kalan=Convert.ToInt16( TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text=yeniborc.ToString();

            //Yeni tutrı veri tabanına kaydetme
            SqlCommand komut=new SqlCommand("update Borclar set OgrKalanborc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2",TxtOgrid.Text);
            komut.Parameters.AddWithValue("@p1",TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yURT_KAYITDataSet4.Borclar);

            //Kasa tablosna ekleme yapma

            SqlCommand komut2=new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) Values(@k1,@k2)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1",TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2",TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void TxtOdenenAy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
