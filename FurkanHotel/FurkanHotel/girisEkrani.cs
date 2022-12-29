using FurkanHotel.Events;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace FurkanHotel
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string gonderid = "";
        public void Bildirim(string msg)
        {
            bildirim bildirim = new bildirim();
            bildirim.BildirimGoster(msg);
        }
        private void girisYap_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text != String.Empty && sifre.Text != String.Empty)
            {
                try
                {
                    anaMenu anaMenu = new anaMenu();
                    Uye uye = new Uye();

                    // uye.GirisYap(kullaniciAdi.Text, sifre.Text);
                    var kullanici = uye.GirisYap(kullaniciAdi.Text, sifre.Text);
                    profil profil = new profil();
                    uyeid.Text = kullanici[0];
                    gonderid = uyeid.Text;
                    girisEkrani girisEkrani = new girisEkrani();
                    girisEkrani.Hide();
                }
                catch (Exception)
                {
                }
            }
            else
            {
                // MessageBox.Show("Boş Bırakmayınız!", "Üye Giriş İşlemi");
                this.Bildirim("Boş Bırakmayınız! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.Show();
            this.Hide();
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

        private void girisEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uYELER.tblUye' table. You can move, or remove it, as needed.
            this.tblUyeTableAdapter.Fill(this.uYELER.tblUye);

            // TODO: This line of code loads data into the 'dbFurkanOtelDataSetSIL.tblUye' table. You can move, or remove it, as needed.
            kullaniciAdi.Focus();
            sifreGoster.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(sifremiUnuttum, "Şifremi Unuttum");
            Aciklama.SetToolTip(girisYap, "Giriş Yap");
            Aciklama.SetToolTip(cikisYap, "Çıkış Yap");
            Aciklama.SetToolTip(button1, "Test Girişi");
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

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));

                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));

                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));

                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));

                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void giris_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Red);
        }

        private void sifremiUnuttum_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text != String.Empty)
            {
                if (kullaniciAdi.Text != String.Empty)
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblUye Where uyekullaniciadi='" + kullaniciAdi.Text + "'", baglanti);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tblUye");
                    dataGridView1.DataSource = ds.Tables["tblUye"];

                    try
                    {
                        Random r = new Random();
                        string eMail = dataGridView1[5, 0].Value.ToString();
                        int x = r.Next(100000, 999999);
                        SmtpClient sc = new SmtpClient();
                        sc.Port = 587;
                        sc.Host = "smtp.gmail.com";

                        //Hotmail veya Outlook = 'smtp.live.com'
                        //Gmail = 'smtp.gmail.com'
                        //Office 365 = 'smtp.office365.com'

                        sc.EnableSsl = true;
                        sc.Credentials = new System.Net.NetworkCredential("example@gmail.com", "password");

                        MailMessage mesaj = new MailMessage("example@gmail.com", eMail);

                        mesaj.Subject = "[Furkan Otel] Lütfen cihazınızı doğrulayın!";
                        mesaj.Body = "Şifrenizi sıfırlayabilmek için 6 haneli aktivasyon kodunu programa giriniz. \n \n Aktivasyon Kodunuz: " + x + "\n \n Teşekkürler, \n Furkan Otel Otomasyon Ekibi";

                        sc.Send(mesaj);

                        sifremiUnuttum sifremiUnuttum = new sifremiUnuttum();
                        sifremiUnuttum.eMail = eMail;
                        sifremiUnuttum.x = x;
                        sifremiUnuttum.Show();
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("Böyle bir kullanıcı adı yok!", "Şifremi Unuttum İşlemi");
                        this.Bildirim("Böyle bir kullanıcı adı yok!");

                        // MessageBox.Show(ex.ToString(), "Böyle bir kullanıcı adı yok!");
                    }
                }
            }
            else
            {
                this.Bildirim("Kullanıcı Adı Giriniz! ");
            }
        }
    }
}