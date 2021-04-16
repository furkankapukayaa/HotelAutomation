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
    public partial class uyeİslemleri : Form
    {
        public uyeİslemleri()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.Show();
            this.Close();
        }

        private void uyeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uYELER.tblUye' table. You can move, or remove it, as needed.
            this.tblUyeTableAdapter.Fill(this.uYELER.tblUye);
            Uye uye = new Uye();
            DataTable tblUye = uye.tblUye();
            dataGridView1.DataSource = tblUye;
            sifreGoster.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(uyeOlustur, "Çalışan Ekle");
            Aciklama.SetToolTip(guncelle, "Çalışan Güncelle");
            Aciklama.SetToolTip(sil, "Çalışan Sil");
            Aciklama.SetToolTip(geriDon, "Ana Menüye Dön");
            Aciklama.SetToolTip(temizlik, "Kutuları Temizle");
            DataGridViewTasarım(dataGridView1);
        }

        int id = 0;
        int secilen;

        public void Bildirim(string msg)
        {
            bildirim bildirim = new bildirim();
            bildirim.BildirimGoster(msg);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = int.Parse(row.Cells[0].Value.ToString());
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            uyeId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            kullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sifre.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            yetki.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            telefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            profilFotografi.ImageLocation = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.Uyeid = id;
            uye.Uyeadsoyad = adSoyad.Text;
            uye.Uyekullaniciadi = kullaniciAdi.Text;
            uye.Uyesifre = sifre.Text;
            uye.Uyeyetki = yetki.SelectedItem.ToString();
            uye.Uyemail = mail.Text;
            uye.Uyetelefon = telefon.Text;
            uye.Uyefotograf = profilFotografi.ImageLocation.ToString();
            uye.UyeGuncelle();
            Temizle();
            uyeler_Load(sender, e);
            this.Bildirim("Güncelleme Başarılı!");
            //MessageBox.Show("GÜNCELLENDİ");
        }

        private void sil_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.Uyeid = id;
            uye.UyeSil();
            Temizle();
            uyeler_Load(sender, e);
            this.Bildirim("Silme İşlemi Başarılı!");
            //MessageBox.Show("SİLİNDİ");
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

        public void Temizle()
        {
            uyeId.Clear();
            adSoyad.Clear();
            kullaniciAdi.Clear();
            sifre.Clear();
            yetki.SelectedIndex = 0;
            mail.Clear();
            telefon.Clear();
            profilFotografi.ImageLocation = "";
            this.Bildirim("Temizlik Yapıldı! Oh misss :)");
        }
        private void uyeOlustur_Click(object sender, EventArgs e)
        {
            if (adSoyad.Text != String.Empty && kullaniciAdi.Text != String.Empty && sifre.Text != String.Empty && yetki.SelectedIndex != 0 && mail.Text != String.Empty && telefon.Text != String.Empty && profilFotografi.ImageLocation != String.Empty)
            {
                Uye uye = new Uye();
                uye.Uyeadsoyad = adSoyad.Text;
                uye.Uyekullaniciadi = kullaniciAdi.Text;
                uye.Uyesifre = sifre.Text;
                uye.Uyeyetki = yetki.SelectedItem.ToString();
                uye.Uyemail = mail.Text;
                uye.Uyetelefon = telefon.Text;
                uye.Uyefotograf = profilFotografi.ImageLocation.ToString();

                uye.UyeEkle();
                Temizle();
                uyeler_Load(sender, e);
                //girisEkrani girisEkrani = new girisEkrani();
                //girisEkrani.Show();
                //this.Close();
                this.Bildirim("Başarıyla Eklendi!");
                //MessageBox.Show("Üye Başarıyla Eklendi!", "Üye Ekleme İşlemi");
            }
            else
            {
                this.Bildirim("Boş Alan Bırakmayınız!");
                //MessageBox.Show("Üye Ekleme Başarısız! Boş Alan Bırakmayınız!", "Üye Ekleme İşlemi");
            }


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

        private void temizlik_Click(object sender, EventArgs e)
        {
            Temizle();
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
