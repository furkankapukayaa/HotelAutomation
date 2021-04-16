using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurkanHotel.Events;

namespace FurkanHotel
{
    public partial class musteriİslemleri : Form
    {
        public musteriİslemleri()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.Show();
            this.Close();
        }

        public void Bildirim(string msg)
        {
            bildirim bildirim = new bildirim();
            bildirim.BildirimGoster(msg);
        }
        public void Temizle()
        {
            tc.Clear();
            adSoyad.Clear();
            mail.Clear();
            telefon.Clear();
            arac.Clear();
            girisTarihi.Value= DateTime.Now;
            cikisTarihi.Value= DateTime.Now;
            odaNo.Clear();
            this.Bildirim("Temizlik Yapıldı! Oh misss :)");
        }

        private void musteriOlustur_Click(object sender, EventArgs e)
        {
            if (tc.Text != String.Empty)
            {
                Musteri musteri = new Musteri();
                musteri.Musteritc = tc.Text;
                musteri.Musteriadsoyad = adSoyad.Text;
                musteri.Musterimail = mail.Text;
                musteri.Musteritelefon = telefon.Text;
                musteri.Musteriarac = arac.Text;
                musteri.Musterigiristarih = girisTarihi.Value;
                musteri.Mustericikistarih = cikisTarihi.Value;
                musteri.Musteriodano = "Satış İşlemi Bekleniyor";
                musteri.MusteriEkle();
                Temizle();
                musteriİslemleri_Load(sender, e);
                this.Bildirim("Başarıyla Eklendi!");
               //MessageBox.Show("Müşteri Başarıyla Eklendi!", "Müşteri Ekleme İşlemi");
            }
            else
            {
                this.Bildirim("Boş Alan Bırakmayınız!");
                //MessageBox.Show("Müşteri Ekleme Başarısız! Boş Alan Bırakmayınız!", "Müşteri Ekleme İşlemi");
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Musteriid = id;
            musteri.Musteritc = tc.Text;
            musteri.Musteriadsoyad = adSoyad.Text;
            musteri.Musterimail = mail.Text;
            musteri.Musteritelefon = telefon.Text;
            musteri.Musteriarac = arac.Text;
            musteri.Musterigiristarih = girisTarihi.Value;
            musteri.Mustericikistarih = cikisTarihi.Value;
            musteri.Musteriodano = odaNo.Text;
            musteri.MusteriGuncelle();
            Temizle();
            musteriİslemleri_Load(sender, e);
            this.Bildirim("Güncelleme Başarılı!");
            //MessageBox.Show("GÜNCELLENDİ");
        }

        int id = 0;
        
        private void sil_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Musteriid= id;
            musteri.MusteriSil();
            Temizle();
            musteriİslemleri_Load(sender, e);
            this.Bildirim("Silme İşlemi Başarılı!");
            //MessageBox.Show("SİLİNDİ");
        }

        private void musteriİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mUSTERİLER.tblMusteri' table. You can move, or remove it, as needed.
            this.tblMusteriTableAdapter.Fill(this.mUSTERİLER.tblMusteri);
            Musteri musteri = new Musteri();
            DataTable tblMusteri = musteri.tblMusteri();
            dataGridView1.DataSource = tblMusteri;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(musteriOlustur, "Müşteri Ekle");
            Aciklama.SetToolTip(guncelle, "Müşteri Güncelle");
            Aciklama.SetToolTip(sil, "Müşteri Sil");
            Aciklama.SetToolTip(geriDon, "Ana Menüye Dön");
            Aciklama.SetToolTip(temizlik, "Kutuları Temizle");
            DataGridViewTasarım(dataGridView1);
        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = int.Parse(row.Cells[0].Value.ToString());

            secilen = dataGridView1.SelectedCells[0].RowIndex;

            ıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            adSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            telefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            arac.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            girisTarihi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cikisTarihi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            odaNo.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void temizlik_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        public void DataGridViewTasarım(DataGridView DataGridViewAdi)
        {
            DataGridViewAdi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 12, FontStyle.Bold);
            DataGridViewAdi.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 10);
            DataGridViewAdi.EnableHeadersVisualStyles = false;
            DataGridViewAdi.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DataGridViewAdi.MultiSelect = false;
        }
    }
}
