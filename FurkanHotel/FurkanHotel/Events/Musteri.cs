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
    class Musteri
    {
        private int musteriid;
        private string musteritc;
        private string musteriadsoyad;
        private string musterimail;
        private string musteritelefon;
        private string musteriarac;
        private DateTime musterigiristarih;
        private DateTime mustericikistarih;
        private string musteriodano;

        public int Musteriid { get => musteriid; set => musteriid = value; }
        public string Musteritc { get => musteritc; set => musteritc = value; }
        public string Musteriadsoyad { get => musteriadsoyad; set => musteriadsoyad = value; }
        public string Musterimail { get => musterimail; set => musterimail = value; }
        public string Musteritelefon { get => musteritelefon; set => musteritelefon = value; }
        public string Musteriarac { get => musteriarac; set => musteriarac = value; }
        public DateTime Musterigiristarih { get => musterigiristarih; set => musterigiristarih = value; }
        public DateTime Mustericikistarih { get => mustericikistarih; set => mustericikistarih = value; }
        public string Musteriodano { get => musteriodano; set => musteriodano = value; }

        SqlCommand komut;
        SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
        SqlDataReader oku;

        public void MusteriEkle()
        {
            komut = new SqlCommand("Insert Into tblMusteri (musteritc,musteriadsoyad,musterimail,musteritelefon,musteriarac,musterigiristarih,mustericikistarih,musteriodano) values (@tc, @adsoyad, @mail, @telefon, @arac, @giris, @cikis, @odano)", baglanti);
            komut.Parameters.AddWithValue("@tc", this.Musteritc);
            komut.Parameters.AddWithValue("@adsoyad", this.Musteriadsoyad);
            komut.Parameters.AddWithValue("@mail", this.Musterimail);
            komut.Parameters.AddWithValue("@telefon", this.Musteritelefon);
            komut.Parameters.AddWithValue("@arac", this.Musteriarac);
            komut.Parameters.AddWithValue("@giris", this.Musterigiristarih);
            komut.Parameters.AddWithValue("@cikis", this.Mustericikistarih);
            komut.Parameters.AddWithValue("@odano", this.Musteriodano);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void MusteriSil()
        {
            komut = new SqlCommand("Delete From tblMusteri Where musteriid=@id", baglanti);
            komut.Parameters.AddWithValue("@id", this.musteriid);

            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void MusteriGuncelle()
        {
            komut = new SqlCommand("Update tblMusteri Set musteritc=@tc,musteriadsoyad=@adsoyad,musterimail=@mail,musteritelefon=@telefon,musteriarac=@arac,musterigiristarih=@giris,mustericikistarih=@cikis,musteriodano=@odano Where musteriid=@id", baglanti);
            komut.Parameters.AddWithValue("@tc", this.Musteritc);
            komut.Parameters.AddWithValue("@adsoyad", this.Musteriadsoyad);
            komut.Parameters.AddWithValue("@mail", this.Musterimail);
            komut.Parameters.AddWithValue("@telefon", this.Musteritelefon);
            komut.Parameters.AddWithValue("@arac", this.Musteriarac);
            komut.Parameters.AddWithValue("@giris", this.Musterigiristarih);
            komut.Parameters.AddWithValue("@cikis", this.Mustericikistarih);
            komut.Parameters.AddWithValue("@odano", this.Musteriodano);
            komut.Parameters.AddWithValue("@id", this.musteriid);


            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public DataTable tblMusteri()
        {
            komut = new SqlCommand("SELECT * FROM tblMusteri", baglanti);
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
