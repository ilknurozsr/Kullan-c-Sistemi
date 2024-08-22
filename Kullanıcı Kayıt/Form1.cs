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

namespace Kullanıcı_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=ILKNUR\\MSSQLSERVER02;Initial Catalog=Kisiler;Integrated Security=True;Encrypt=False";
        SqlConnection baglanti = new SqlConnection(conString); // baglanti adında yeni bir sql nesnesi ürettim.

        private void işlemikaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string kayit = "insert into bilgi (kullanici_adi,ad_soyad,telefon) values (@kullanici_adi,@adsoyad,@telefon)"; // ilgili textbox'a girilen değerleri veri tabanındaki ilgili sütunlara atayacağız ve bunu kayit ismindeki bir değişkene tutturacağız.
            SqlCommand komut = new SqlCommand(kayit, baglanti); // kayıt ve bağlantıyı gönder diyorum tanımladığım değişkenime.

            komut.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text); // komutlarımıza parametrelerimizi göndereceğiz.

            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);

            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);

            komut.ExecuteNonQuery(); // parametrelerimizi çalıştırabilmek için.

            baglanti.Close();

            MessageBox.Show("Kaydetme Başarılı.");
            
        }
    }
}
