using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FurkanHotel.Events
{
    class Uye
    {
        private int uyeid;
        private string uyeadsoyad;
        private string uyekullaniciadi;
        private string uyesifre;
        private string uyeyetki;
        private string uyemail;
        private string uyetelefon;
        private string uyefotograf;

        public int Uyeid { get => uyeid; set => uyeid = value; }
        public string Uyeadsoyad { get => uyeadsoyad; set => uyeadsoyad = value; }
        public string Uyekullaniciadi { get => uyekullaniciadi; set => uyekullaniciadi = value; }
        public string Uyesifre { get => uyesifre; set => uyesifre = value; }
        public string Uyeyetki { get => uyeyetki; set => uyeyetki = value; }
        public string Uyemail { get => uyemail; set => uyemail = value; }
        public string Uyetelefon { get => uyetelefon; set => uyetelefon = value; }
        public string Uyefotograf { get => uyefotograf; set => uyefotograf = value; }

        private SqlCommand komut;
        private SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
        private SqlDataReader oku;

        public void UyeEkle()
        {
            komut = new SqlCommand("Insert Into tblUye (uyeadsoyad,uyekullaniciadi,uyesifre,uyeyetki,uyemail,uyetelefon,uyefotograf) values (@adsoyad, @kullaniciadi, @sifre, @yetki, @mail, @telefon, @fotograf)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", this.Uyeadsoyad);
            komut.Parameters.AddWithValue("@kullaniciadi", this.Uyekullaniciadi);
            komut.Parameters.AddWithValue("@sifre", this.Uyesifre);
            komut.Parameters.AddWithValue("@yetki", this.Uyeyetki);
            komut.Parameters.AddWithValue("@mail", this.Uyemail);
            komut.Parameters.AddWithValue("@telefon", this.Uyetelefon);
            komut.Parameters.AddWithValue("@fotograf", this.Uyefotograf);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void UyeSil()
        {
            komut = new SqlCommand("Delete From tblUye Where uyeid=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.uyeid);

            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void UyeGuncelle()
        {
            komut = new SqlCommand("Update tblUye Set uyeadsoyad=@adsoyad, uyekullaniciadi=@kullaniciadi, uyesifre=@sifre, uyeyetki=@yetki, uyemail=@mail, uyetelefon=@telefon, uyefotograf=@fotograf Where uyeid=@id", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", this.Uyeadsoyad);
            komut.Parameters.AddWithValue("@kullaniciadi", this.Uyekullaniciadi);
            komut.Parameters.AddWithValue("@sifre", this.Uyesifre);
            komut.Parameters.AddWithValue("@yetki", this.Uyeyetki);
            komut.Parameters.AddWithValue("@mail", this.Uyemail);
            komut.Parameters.AddWithValue("@telefon", this.Uyetelefon);
            komut.Parameters.AddWithValue("@fotograf", this.Uyefotograf);
            komut.Parameters.AddWithValue("@id", this.uyeid);

            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public DataTable tblUye()
        {
            komut = new SqlCommand("SELECT * FROM tblUye", baglanti);
            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();
            }
            oku = komut.ExecuteReader();
            DataTable tablo = new DataTable();

            if (oku.HasRows)
            {
                tablo.Load(oku);
            }
            baglanti.Close();

            return tablo;
        }

        public void Bildirim(string msg)
        {
            bildirim bildirim = new bildirim();
            bildirim.BildirimGoster(msg);
        }

        public dynamic GirisYap(string kullaniciadisorgu, string sifresorgu)
        {
            komut = new SqlCommand("SELECT * FROM tblUye Where uyekullaniciadi='" + kullaniciadisorgu + "' and uyesifre='" + sifresorgu + "'", baglanti);
            baglanti.Open();
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                girisEkrani girisEkrani = new girisEkrani();
                girisEkrani.Close();
                anaMenu anaMenu = new anaMenu();
                anaMenu.Show();

                //MessageBox.Show("Giriş Başarılı!", "Üye Giriş İşlemi");
                this.Bildirim("Merhaba " + kullaniciadisorgu.ToUpper() + " Hoş Geldin!");

                List<string> aa = new List<string>();

                for (int i = 0; i < oku.FieldCount; i++)
                {
                    aa.Add(oku[i].ToString());
                }
                return aa;
            }
            else
            {
                // MessageBox.Show("Hatalı Giriş!", "Üye Giriş İşlemi");
                this.Bildirim("Hatalı Giriş! " + kullaniciadisorgu.ToUpper() + " Tekrar Dene!");
                return null;
            }

            // baglanti.Close();
            // komut.Dispose();
        }
    }
}