using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FurkanHotel
{
    public partial class sifremiUnuttum : Form
    {
        public sifremiUnuttum()
        {
            InitializeComponent();
        }

        public string eMail;
        public int x;
        private void dogrula_Click(object sender, EventArgs e)
        {
            if (onayKodu.Text == x.ToString())
            {
                sifreSifirla.Visible = true;
                onayKodu.Enabled = false;
                MessageBox.Show("Aktivasyon Kodu Doğru!");
            }
            else
            {
                MessageBox.Show("Aktivasyon Kodu Yanlış!");
            }
        }

        private void sifreGuncelle_Click(object sender, EventArgs e)
        {
            if (sifre.Text == sifreTekrar.Text)
            {
                try
                {
                    SqlCommand komut;
                    SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
                    komut = new SqlCommand("Update tblUye Set  uyesifre=@sifre Where uyemail=@mail ", baglanti);
                    komut.Parameters.AddWithValue("@sifre", this.sifre.Text);
                    komut.Parameters.AddWithValue("@mail", this.eMail.ToString());
                    if ((baglanti.State == ConnectionState.Closed))
                    {
                        baglanti.Open();
                    }
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz Başarıyla Değiştirildi!");
                    girisEkrani girisEkrani = new girisEkrani();
                    girisEkrani.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor!");
            }
        }

        private void onayKodu_TextChanged(object sender, EventArgs e)
        {
            if (onayKodu.Text != String.Empty)
            {
                lblAktivasyonGir.Visible = false;
            }
            else
            {
                lblAktivasyonGir.Visible = true;
            }
        }

        private void sifremiUnuttum_Load(object sender, EventArgs e)
        {
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            if (sifre.Text != String.Empty)
            {
                lblYeniSifre.Visible = false;
                sifreGoster.Visible = true;
            }
            else
            {
                lblYeniSifre.Visible = true;
                sifreGoster.Visible = false;
            }
        }

        private void sifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (sifreTekrar.Text != String.Empty)
            {
                lblTekrarYeniSifre.Visible = false;
                sifreGosterTekrar.Visible = true;
            }
            else
            {
                lblTekrarYeniSifre.Visible = true;
                sifreGosterTekrar.Visible = false;
            }
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

        private void sifreGosterTekrar_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGosterTekrar.Checked)
            {
                sifreTekrar.UseSystemPasswordChar = false;
                sifreTekrar.PasswordChar = '\0';
            }
            else
            {
                sifreTekrar.UseSystemPasswordChar = true;
                sifreTekrar.PasswordChar = 'a';
            }
        }
    }
}