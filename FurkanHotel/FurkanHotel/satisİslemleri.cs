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
    public partial class satisİslemleri : Form
    {
        public satisİslemleri()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.Show();
            this.Close();
        }

        private void satisİslemleri_Load(object sender, EventArgs e)
        {
            this.tblSatisTableAdapter.Fill(this.sATİSLAR.tblSatis);
            this.tblOdaTableAdapter.Fill(this.oDALAR.tblOda);
            this.tblMusteriTableAdapter.Fill(this.mUSTERİLER.tblMusteri);
            satisOdendiMi.SelectedIndex = 0;
            satisOdemeYontemi.SelectedIndex = 0;
            odaOdaTur.SelectedIndex = 0;
            odaDurum.SelectedIndex = 0;
            lblUyarı.Text = "Veri Bekleniyor...";
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(satisEkle, "Satış Ekle");
            Aciklama.SetToolTip(guncelle, "Satış Güncelle");
            Aciklama.SetToolTip(sil, "Satış Sil");
            Aciklama.SetToolTip(temizlik, "Kutuları Temizle");
            Aciklama.SetToolTip(geriDon, "Ana Menüye Dön");
            DataGridViewTasarım(dataGridView1);
            DataGridViewTasarım(dataGridView2);
            DataGridViewTasarım(dataGridView3);
        }
        public void Bildirim(string msg)
        {
            bildirim bildirim = new bildirim();
            bildirim.BildirimGoster(msg);
        }

        int id = 0;
        int secilen;
        
        public void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            lblUyarı.Text = "";
            satisOdendiMi.SelectedIndex = 0;
            satisOdemeYontemi.SelectedIndex = 0;
            odaDurum.SelectedIndex = 0;
            odaOdaTur.SelectedIndex = 0;
            musteriGirisTarihi.Value = DateTime.Now;
            musteriCikisTarihi.Value= DateTime.Now;
            this.Bildirim("Temizlik Yapıldı! Oh misss :)");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = int.Parse(row.Cells[0].Value.ToString());

            secilen = dataGridView1.SelectedCells[0].RowIndex;

            musteriId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            musteriTC.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            musteriAdSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            musteriMail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            musteriTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            musteriArac.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            musteriGirisTarihi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            musteriCikisTarihi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            musteriOdaNo.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            
            satisAdSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            satisOdaAdi.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            id = int.Parse(row.Cells[0].Value.ToString());

            secilen = dataGridView2.SelectedCells[0].RowIndex;

            odaId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            
            odaOdaAdi.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            odaOdaTur.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            lblUyarı.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            odaOdaAciklama.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            odaDurum.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();

            satisOdaAdi.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
        }

        private void satisEkle_Click(object sender, EventArgs e)
        {

            if (satisFiyat.Text != String.Empty)
            {
                Oda oda = new Oda();
                oda.Odaid = Int32.Parse(odaId.Text);
                oda.Odaad = odaOdaAdi.Text;
                oda.Odatur = odaOdaTur.SelectedItem.ToString();
                oda.Odakisisayisi = lblUyarı.Text;
                oda.Odaaciklama = odaOdaAciklama.Text;
                oda.Odadurum = "Dolu";
                oda.OdaGuncelle();

                Satis satis = new Satis();
                satis.Satisadsoyad = satisAdSoyad.Text;
                satis.Satisodaadi = satisOdaAdi.Text;
                satis.Satisfiyat = satisFiyat.Text;
                satis.SatisOdendimi = satisOdendiMi.SelectedItem.ToString();
                satis.SatisOdemeyontemi = satisOdemeYontemi.SelectedItem.ToString();
                satis.SatisEkle();

                Musteri musteri = new Musteri();
                musteri.Musteriid = Int32.Parse(musteriId.Text);
                musteri.Musteritc = musteriTC.Text;
                musteri.Musteriadsoyad = musteriAdSoyad.Text;
                musteri.Musterimail = musteriMail.Text;
                musteri.Musteritelefon = musteriTelefon.Text;
                musteri.Musteriarac = musteriArac.Text;
                musteri.Musterigiristarih = musteriGirisTarihi.Value;
                musteri.Mustericikistarih = musteriCikisTarihi.Value;
                musteri.Musteriodano = satisOdaAdi.Text;
                musteri.MusteriGuncelle();
                Temizle();
                satisİslemleri_Load(sender, e);
                this.Bildirim("Başarıyla Eklendi!");
                //MessageBox.Show("Satış Başarıyla Eklendi!", "Satış Ekleme İşlemi");
            }
            else
            {
                this.Bildirim("Boş Alan Bırakmayınız!");
                //MessageBox.Show("Satış Ekleme Başarısız! Boş Alan Bırakmayınız!", "Satış Ekleme İşlemi");
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Satisid = id;
            satis.Satisadsoyad = satisAdSoyad.Text;
            satis.Satisodaadi = satisOdaAdi.Text;
            satis.Satisfiyat = satisFiyat.Text;
            satis.SatisOdendimi = satisOdendiMi.SelectedItem.ToString();
            satis.SatisOdemeyontemi = satisOdemeYontemi.SelectedItem.ToString();
            satis.SatisGuncelle();
            Temizle();
            satisİslemleri_Load(sender, e);
            this.Bildirim("Güncelleme Başarılı!");
            //MessageBox.Show("GÜNCELLENDİ");
        }

        private void sil_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Satisid = id;
            satis.SatisSil();
            Temizle();
            satisİslemleri_Load(sender, e);
            this.Bildirim("Silme İşlemi Başarılı!");
            //MessageBox.Show("SİLİNDİ");
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
            id = int.Parse(row.Cells[0].Value.ToString());

            secilen = dataGridView3.SelectedCells[0].RowIndex;

            satisId.Text = dataGridView3.Rows[secilen].Cells[0].Value.ToString();
            satisAdSoyad.Text = dataGridView3.Rows[secilen].Cells[1].Value.ToString();
            satisOdaAdi.Text = dataGridView3.Rows[secilen].Cells[2].Value.ToString();
            satisFiyat.Text = dataGridView3.Rows[secilen].Cells[3].Value.ToString();
            satisOdendiMi.Text = dataGridView3.Rows[secilen].Cells[4].Value.ToString();
            satisOdemeYontemi.Text = dataGridView3.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
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
