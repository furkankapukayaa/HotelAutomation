using System;
using System.Windows.Forms;

namespace FurkanHotel
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            girisEkrani girisEkrani = new girisEkrani();
            girisEkrani.Show();
            this.Close();
        }

        private void anaMenu_Load(object sender, EventArgs e)
        {
            timerTarih.Start();
            profil profil = new profil();
            lblKullaniciAdi.Text = profil.gonderAdSoyad;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(firmaLogo, "Firma Logo");
            Aciklama.SetToolTip(cikisYap, "Çıkış Yap");
            Aciklama.SetToolTip(uyeİslemleri, "Çalışan İşlemleri");
            Aciklama.SetToolTip(odaİslemleri, "Oda İşlemleri");
            Aciklama.SetToolTip(musteriİslemleri, "Müşteri İşlemleri");
            Aciklama.SetToolTip(satisİslemleri, "Satış İşlemleri");
            Aciklama.SetToolTip(profil, "Profil");
            Aciklama.SetToolTip(odalar, "Odalar");
        }

        private void timerTarih_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }

        private void uyeİslemleri_Click(object sender, EventArgs e)
        {
            uyeİslemleri uyeİslemleri = new uyeİslemleri();
            uyeİslemleri.Show();
            this.Close();
        }

        private void musteriİslemleri_Click(object sender, EventArgs e)
        {
            musteriİslemleri musteriİslemleri = new musteriİslemleri();
            musteriİslemleri.Show();
            this.Close();
        }

        private void odaİslemleri_Click(object sender, EventArgs e)
        {
            odaİslemleri odaİslemleri = new odaİslemleri();
            odaİslemleri.Show();
            this.Close();
        }

        private void satisİslemleri_Click(object sender, EventArgs e)
        {
            satisİslemleri satisİslemleri = new satisİslemleri();
            satisİslemleri.Show();
            this.Close();
        }

        private void profil_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.Show();
            this.Close();
        }

        private void odalar_Click(object sender, EventArgs e)
        {
            odaListesi odalar = new odaListesi();
            odalar.Show();
            this.Close();
        }
    }
}