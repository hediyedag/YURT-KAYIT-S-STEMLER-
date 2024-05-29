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

namespace YURT_KAYIT_SİSTEMLERİ
{
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }

        public string elektirik, su, dogalgaz, internet, gida, personel, diger,id ;


        SqlBaglantim bgl=new SqlBaglantim();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektirik=@p1, Su=@p2, Dogalgaz=@p3, internet=@p4, Gıda=@p5, Personel=@p6, Diger=@p7 where Odemeid=@p8", bgl.baglanti());

                komut.Parameters.AddWithValue("@p8", TxtGiderid.Text);
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtİnternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDıger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Güncelleme Yapıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Yeniden Deneyin");
            }

        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            TxtGiderid.Text = id;
            TxtElektrik.Text = elektirik;
            TxtSu.Text = su;
            TxtDogalGaz.Text = dogalgaz;
            Txtİnternet.Text = internet;
            TxtGıda.Text = gida;
            TxtPersonel.Text = personel;
            TxtDıger.Text = diger;
        }
    }
}
