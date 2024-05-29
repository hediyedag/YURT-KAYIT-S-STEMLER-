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

namespace YURT_KAYIT_SİSTEMLERİ
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,TC,telefon,dogum,bolum;



        private void button2_Click(object sender, EventArgs e)
        {
            //ogrenci silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", TxtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Silindi");

            //odanın aktif ögrenci sayısını azaltma

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda",CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }



        private void BtnGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogumTarihi=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrAdres=@p12 where Ogrid=@p1", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogumTarihi.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtOgrMail.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtOgrVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", RchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt Gücellendi");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Yeniden Deneyin");
            }
        }
      

        public string mail, odano, veliad, velitel, adres;

        SqlBaglantim bgl=new SqlBaglantim();


        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAd.Text=ad;
            TxtOgrSoyad.Text=soyad;
            MskTC.Text =TC;
            MskOgrTelefon.Text =telefon;
            MskDogumTarihi.Text = dogum;
            CmbBolum.Text = bolum;

            TxtOgrMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtOgrVeliAdSoyad.Text = veliad;
            MskVeliTelefon.Text = velitel;
            RchAdres.Text = adres;

        }
    }
}
