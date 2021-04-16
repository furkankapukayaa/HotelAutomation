using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FurkanHotel.Events
{
    class Oda
    {
        private int odaid;
        private string odaad;
        private string odatur;
        private string odakisisayisi;
        private string odaaciklama;
        private string odadurum;

        public int Odaid { get => odaid; set => odaid = value; }
        public string Odaad { get => odaad; set => odaad = value; }
        public string Odatur { get => odatur; set => odatur = value; }
        public string Odakisisayisi { get => odakisisayisi; set => odakisisayisi = value; }
        public string Odaaciklama { get => odaaciklama; set => odaaciklama = value; }
        public string Odadurum { get => odadurum; set => odadurum = value; }

        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
        SqlDataReader oku;

        public void OdaEkle()
        {
            komut = new SqlCommand("Insert Into tblOda (odaad,odatur,odakisisayisi,odaaciklama,odadurum) values (@ad, @tur, @kisisayisi, @aciklama, @durum)", baglanti);
            komut.Parameters.AddWithValue("@ad", this.Odaad);
            komut.Parameters.AddWithValue("@tur", this.Odatur);
            komut.Parameters.AddWithValue("@kisisayisi", this.Odakisisayisi);
            komut.Parameters.AddWithValue("@aciklama", this.Odaaciklama);
            komut.Parameters.AddWithValue("@durum", this.Odadurum);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void OdaSil()
        {
            komut = new SqlCommand("Delete From tblOda Where odaid=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.odaid);

            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void OdaGuncelle()
        {
            komut = new SqlCommand("Update tblOda Set odaad=@ad, odatur=@tur, odakisisayisi=@kisisayisi, odaaciklama=@aciklama, odadurum=@durum Where odaid=@id", baglanti);
            komut.Parameters.AddWithValue("@ad", this.Odaad);
            komut.Parameters.AddWithValue("@tur", this.Odatur);
            komut.Parameters.AddWithValue("@kisisayisi", this.Odakisisayisi);
            komut.Parameters.AddWithValue("@aciklama", this.Odaaciklama);
            komut.Parameters.AddWithValue("@durum", this.Odadurum);
            komut.Parameters.AddWithValue("@id", this.odaid);


            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public DataTable tblOda()
        {
            komut = new SqlCommand("SELECT * FROM tblOda", baglanti);
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

        public dynamic OdaKontrol(string odadurumsorgu)
        {
            SqlCommand komut;
            SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
            SqlDataReader oku;

            komut = new SqlCommand("SELECT * FROM tblOda Where odaid='" + odadurumsorgu + "'", baglanti);
            baglanti.Open();
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("onay");

                List<string> aa = new List<string>();

                for (int i = 0; i < oku.FieldCount; i++)
                {
                    aa.Add(oku[i].ToString());
                }
                return aa;
            }
            else
            {
                MessageBox.Show("hata");
                return null;
            }
        }
    }
}
