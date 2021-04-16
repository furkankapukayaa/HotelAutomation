using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FurkanHotel.Events
{
    class Satis
    {
        private int satisid;
        private string satisadsoyad;
        private string satisodaadi;
        private string satisfiyat;
        private string satisodendimi;
        private string satisodemeyontemi;

        public int Satisid { get => satisid; set => satisid = value; }
        public string Satisadsoyad { get => satisadsoyad; set => satisadsoyad = value; }
        public string Satisodaadi { get => satisodaadi; set => satisodaadi = value; }
        public string Satisfiyat { get => satisfiyat; set => satisfiyat = value; }
        public string SatisOdendimi { get => satisodendimi; set => satisodendimi = value; }
        public string SatisOdemeyontemi { get => satisodemeyontemi; set => satisodemeyontemi = value; }

        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
        SqlDataReader oku;

        public void SatisEkle()
        {
            komut = new SqlCommand("Insert Into tblSatis (satisadsoyad,satisodaadi,satisfiyat,satisodendimi,satisodemeyontemi) values (@adsoyad, @odaadi, @fiyat, @odendimi, @odemeyontemi)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", this.Satisadsoyad);
            komut.Parameters.AddWithValue("@odaadi", this.Satisodaadi);
            komut.Parameters.AddWithValue("@fiyat", this.Satisfiyat);
            komut.Parameters.AddWithValue("@odendimi", this.SatisOdendimi);
            komut.Parameters.AddWithValue("@odemeyontemi", this.SatisOdemeyontemi);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void SatisSil()
        {
            komut = new SqlCommand("Delete From tblSatis Where satisid=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.satisid);

            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void SatisGuncelle()
        {
            komut = new SqlCommand("Update tblSatis Set satisadsoyad=@adsoyad, satisodaadi=@odaadi, satisfiyat=@fiyat, satisOdendimi=@odendimi, satisOdemeyontemi=@odemeyontemi  Where satisid=@id", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", this.Satisadsoyad);
            komut.Parameters.AddWithValue("@odaadi", this.Satisodaadi);
            komut.Parameters.AddWithValue("@fiyat", this.Satisfiyat);
            komut.Parameters.AddWithValue("@odendimi", this.SatisOdendimi);
            komut.Parameters.AddWithValue("@odemeyontemi", this.SatisOdemeyontemi);
            komut.Parameters.AddWithValue("@id", this.satisid);


            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public DataTable tblSatis()
        {
            komut = new SqlCommand("SELECT * FROM tblSatis", baglanti);
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
    }
}
