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
using FurkanHotel.Events;

namespace FurkanHotel
{
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.Show();
            this.Close();
        }

        public static string gonderAdSoyad = "";
        private void profil_Load(object sender, EventArgs e)
        {
            sifreGoster.Visible = false;
            uyeId.Text= girisEkrani.gonderid;
            SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
            baglanti.Open();
            SqlCommand verioku = new SqlCommand("select * from tblUye where uyeid = '" + uyeId.Text + "'", baglanti);
            verioku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = verioku.ExecuteReader();

            while (oku.Read())
            {
                adSoyad.Text = oku["uyeadsoyad"].ToString();
                kullaniciAdi.Text = oku["uyekullaniciadi"].ToString();
                sifre.Text = oku["uyesifre"].ToString();
                yetki.Text = oku["uyeyetki"].ToString();
                mail.Text = oku["uyemail"].ToString();
                telefon.Text = oku["uyetelefon"].ToString();
                profilFotografi.ImageLocation = oku["uyefotograf"].ToString();
            }
            oku.Close();
            baglanti.Close();
            gonderAdSoyad = adSoyad.Text;
        }

        private void dosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png|Tüm Dosyalar |*.*";
            dosya.Title = "Profil Fotoğrafı Seç";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            profilFotografi.ImageLocation = DosyaYolu;
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            if (sifre.Text != String.Empty)
            {
                sifreGoster.Visible = true;
            }
            else
            {
                sifreGoster.Visible = false;
            }
        }

        public void Bildirim(string msg)
        {
            bildirim bildirim = new bildirim();
            bildirim.BildirimGoster(msg);
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            //SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
            //baglanti.Open();
            //SqlCommand verioku = new SqlCommand("select * from tblUye where uyeid = '" + uyeId.Text + "'", baglanti);
            //verioku.ExecuteNonQuery();
            //SqlDataReader oku;
            //oku = verioku.ExecuteReader();

            //while (oku.Read())
            //{

            //    adSoyad.Text = oku["uyeadsoyad"].ToString();
            //    kullaniciAdi.Text = oku["uyekullaniciadi"].ToString();
            //    sifre.Text = oku["uyesifre"].ToString();
            //    mail.Text = oku["uyemail"].ToString();
            //    telefon.Text = oku["uyetelefon"].ToString();
            //    yetki.Text = oku["uyeyetki"].ToString();
            //    profilFotografi.ImageLocation = oku["uyefotograf"].ToString();

            //}
            //oku.Close();
            //baglanti.Close();

            Uye uye = new Uye();
            uye.Uyeid = Int32.Parse(uyeId.Text);
            uye.Uyeadsoyad = adSoyad.Text;
            uye.Uyekullaniciadi = kullaniciAdi.Text;
            uye.Uyesifre = sifre.Text;
            uye.Uyeyetki = yetki.SelectedItem.ToString();
            uye.Uyemail = mail.Text;
            uye.Uyetelefon = telefon.Text;
            uye.Uyefotograf = profilFotografi.ImageLocation;
            uye.UyeGuncelle();
            profil_Load(sender, e);
            this.Bildirim("Güncelleme Başarılı!");
        }
        private void sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGoster.Checked)
            {
                sifre.UseSystemPasswordChar = false;
                sifre.PasswordChar = '\0';
            }
            else
            {
                sifre.UseSystemPasswordChar = true;
                sifre.PasswordChar = 'a';
            }
        }
    }
}
