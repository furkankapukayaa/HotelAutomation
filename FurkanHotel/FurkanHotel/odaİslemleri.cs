using FurkanHotel.Events;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FurkanHotel
{
    public partial class odaİslemleri : Form
    {
        public odaİslemleri()
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
            ıd.Clear();
            odaAdi.Clear();
            odaTur.SelectedIndex = 0;
            yetiskin.SelectedIndex = 0;
            cocuk.SelectedIndex = 0;
            evcilHayvan.SelectedIndex = 0;
            odaDurum.SelectedIndex = 0;
            odaAciklama.Clear();
            lblUyarı.Visible = false;
            this.Bildirim("Temizlik Yapıldı! Oh misss :)");
        }
        private void odaOlustur_Click(object sender, EventArgs e)
        {
            if (odaAdi.Text != String.Empty)
            {
                Oda oda = new Oda();
                oda.Odaad = odaAdi.Text;
                oda.Odatur = odaTur.SelectedItem.ToString();
                oda.Odakisisayisi = yetiskin.SelectedItem.ToString() + " Yetişkin " + cocuk.SelectedItem.ToString() + " Çocuk " + " Evcil Hayvan : " + evcilHayvan.SelectedItem.ToString();
                oda.Odaaciklama = odaAciklama.Text;
                oda.Odadurum = odaDurum.SelectedItem.ToString();
                oda.OdaEkle();
                Temizle();
                odaİslemleri_Load(sender, e);
                this.Bildirim("Başarıyla Eklendi!");

                //MessageBox.Show("Oda Başarıyla Eklendi!", "Oda Ekleme İşlemi");
            }
            else
            {
                this.Bildirim("Boş Alan Bırakmayınız!");

                //MessageBox.Show("Oda Ekleme Başarısız! Boş Alan Bırakmayınız!", "Oda Ekleme İşlemi");
            }
        }

        private int id = 0;
        private void guncelle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            oda.Odaid = id;
            oda.Odaad = odaAdi.Text;
            oda.Odatur = odaTur.SelectedItem.ToString();
            oda.Odakisisayisi = yetiskin.SelectedItem.ToString() + " Yetişkin " + cocuk.SelectedItem.ToString() + " Çocuk " + " Evcil Hayvan : " + evcilHayvan.SelectedItem.ToString();
            oda.Odaaciklama = odaAciklama.Text;
            oda.Odadurum = odaDurum.SelectedItem.ToString();
            oda.OdaGuncelle();
            Temizle();
            odaİslemleri_Load(sender, e);
            this.Bildirim("Güncelleme Başarılı!");

            //MessageBox.Show("GÜNCELLENDİ");
        }

        private void sil_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            oda.Odaid = id;
            oda.OdaSil();
            Temizle();
            odaİslemleri_Load(sender, e);
            this.Bildirim("Silme İşlemi Başarılı!");

            //MessageBox.Show("SİLİNDİ");
        }

        private int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = int.Parse(row.Cells[0].Value.ToString());

            secilen = dataGridView1.SelectedCells[0].RowIndex;

            ıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            odaAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            odaTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            lblUyarı.Visible = true;
            lblUyarı.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            odaAciklama.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            odaDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void odaİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oDALAR.tblOda' table. You can move, or remove it, as needed.
            this.tblOdaTableAdapter.Fill(this.oDALAR.tblOda);
            Oda oda = new Oda();
            DataTable tblOda = oda.tblOda();
            dataGridView1.DataSource = tblOda;
            odaTur.SelectedIndex = 0;
            yetiskin.SelectedIndex = 0;
            cocuk.SelectedIndex = 0;
            evcilHayvan.SelectedIndex = 0;
            odaDurum.SelectedIndex = 0;
            lblUyarı.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(odaOlustur, "Oda Ekle");
            Aciklama.SetToolTip(guncelle, "Oda Güncelle");
            Aciklama.SetToolTip(sil, "Oda Sil");
            Aciklama.SetToolTip(temizlik, "Kutuları Temizle");
            Aciklama.SetToolTip(geriDon, "Ana Menüye Dön");
            DataGridViewTasarım(dataGridView1);
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