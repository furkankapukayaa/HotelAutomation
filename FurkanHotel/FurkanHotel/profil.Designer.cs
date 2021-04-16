
namespace FurkanHotel
{
    partial class profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profil));
            this.geriDon = new System.Windows.Forms.Button();
            this.profilFotografi = new System.Windows.Forms.PictureBox();
            this.sifreGoster = new System.Windows.Forms.CheckBox();
            this.uyeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yetki = new System.Windows.Forms.ComboBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblFotograf = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.guncelle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dosyaSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilFotografi)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDon
            // 
            this.geriDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriDon.BackgroundImage")));
            this.geriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriDon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.geriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDon.ForeColor = System.Drawing.Color.Transparent;
            this.geriDon.Location = new System.Drawing.Point(721, 651);
            this.geriDon.Margin = new System.Windows.Forms.Padding(4);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(66, 57);
            this.geriDon.TabIndex = 20;
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // profilFotografi
            // 
            this.profilFotografi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilFotografi.Location = new System.Drawing.Point(314, 28);
            this.profilFotografi.Name = "profilFotografi";
            this.profilFotografi.Size = new System.Drawing.Size(160, 138);
            this.profilFotografi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilFotografi.TabIndex = 21;
            this.profilFotografi.TabStop = false;
            // 
            // sifreGoster
            // 
            this.sifreGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreGoster.AutoSize = true;
            this.sifreGoster.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sifreGoster.Location = new System.Drawing.Point(481, 332);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(130, 25);
            this.sifreGoster.TabIndex = 149;
            this.sifreGoster.Text = "Şifreyi Göster";
            this.sifreGoster.UseVisualStyleBackColor = true;
            this.sifreGoster.CheckedChanged += new System.EventHandler(this.sifreGoster_CheckedChanged);
            // 
            // uyeId
            // 
            this.uyeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uyeId.Enabled = false;
            this.uyeId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeId.Location = new System.Drawing.Point(317, 181);
            this.uyeId.Margin = new System.Windows.Forms.Padding(4);
            this.uyeId.Name = "uyeId";
            this.uyeId.Size = new System.Drawing.Size(157, 27);
            this.uyeId.TabIndex = 148;
            this.uyeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.label1.Location = new System.Drawing.Point(258, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 37);
            this.label1.TabIndex = 147;
            this.label1.Text = "Id :";
            // 
            // yetki
            // 
            this.yetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yetki.Enabled = false;
            this.yetki.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.yetki.FormattingEnabled = true;
            this.yetki.Items.AddRange(new object[] {
            "Seçiniz",
            "Yönetici",
            "Rezervasyonist",
            "Mutfak",
            "Temizlik",
            "Teknik",
            "Müşteri"});
            this.yetki.Location = new System.Drawing.Point(317, 293);
            this.yetki.Margin = new System.Windows.Forms.Padding(4);
            this.yetki.Name = "yetki";
            this.yetki.Size = new System.Drawing.Size(157, 31);
            this.yetki.TabIndex = 145;
            // 
            // telefon
            // 
            this.telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefon.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.Location = new System.Drawing.Point(316, 415);
            this.telefon.Margin = new System.Windows.Forms.Padding(4);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(159, 27);
            this.telefon.TabIndex = 143;
            // 
            // mail
            // 
            this.mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.Location = new System.Drawing.Point(315, 376);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(160, 27);
            this.mail.TabIndex = 142;
            // 
            // sifre
            // 
            this.sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(315, 332);
            this.sifre.Margin = new System.Windows.Forms.Padding(4);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '•';
            this.sifre.Size = new System.Drawing.Size(159, 27);
            this.sifre.TabIndex = 141;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciAdi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.Location = new System.Drawing.Point(317, 258);
            this.kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(157, 27);
            this.kullaniciAdi.TabIndex = 140;
            // 
            // adSoyad
            // 
            this.adSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adSoyad.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad.Location = new System.Drawing.Point(317, 216);
            this.adSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(157, 27);
            this.adSoyad.TabIndex = 139;
            // 
            // lblYetki
            // 
            this.lblYetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblYetki.Location = new System.Drawing.Point(225, 292);
            this.lblYetki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(76, 37);
            this.lblYetki.TabIndex = 138;
            this.lblYetki.Text = "Yetki  :";
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblSifre.Location = new System.Drawing.Point(231, 329);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(69, 37);
            this.lblSifre.TabIndex = 137;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblAdSoyad.Location = new System.Drawing.Point(178, 213);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(124, 37);
            this.lblAdSoyad.TabIndex = 136;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblMail.Location = new System.Drawing.Point(236, 370);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(65, 37);
            this.lblMail.TabIndex = 135;
            this.lblMail.Text = "Mail :";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(159, 255);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(143, 37);
            this.lblKullaniciAdi.TabIndex = 134;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblFotograf
            // 
            this.lblFotograf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFotograf.AutoSize = true;
            this.lblFotograf.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblFotograf.Location = new System.Drawing.Point(188, 458);
            this.lblFotograf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFotograf.Name = "lblFotograf";
            this.lblFotograf.Size = new System.Drawing.Size(113, 37);
            this.lblFotograf.TabIndex = 133;
            this.lblFotograf.Text = "Fotoğraf :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblTelefon.Location = new System.Drawing.Point(201, 412);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(100, 37);
            this.lblTelefon.TabIndex = 132;
            this.lblTelefon.Text = "Telefon :";
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "update.png");
            // 
            // guncelle
            // 
            this.guncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guncelle.BackColor = System.Drawing.Color.Transparent;
            this.guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle.FlatAppearance.BorderSize = 0;
            this.guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.guncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guncelle.ImageIndex = 0;
            this.guncelle.ImageList = this.icons;
            this.guncelle.Location = new System.Drawing.Point(306, 523);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(176, 91);
            this.guncelle.TabIndex = 150;
            this.guncelle.Text = "Bilgilerimi Güncelle";
            this.guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaSec
            // 
            this.dosyaSec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosyaSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dosyaSec.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.dosyaSec.Location = new System.Drawing.Point(313, 461);
            this.dosyaSec.Name = "dosyaSec";
            this.dosyaSec.Size = new System.Drawing.Size(162, 27);
            this.dosyaSec.TabIndex = 152;
            this.dosyaSec.Text = "Dosya Seç";
            this.dosyaSec.UseVisualStyleBackColor = true;
            this.dosyaSec.Click += new System.EventHandler(this.dosyaSec_Click);
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.dosyaSec);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sifreGoster);
            this.Controls.Add(this.uyeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yetki);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblFotograf);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.profilFotografi);
            this.Controls.Add(this.geriDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profil";
            this.Text = "Profil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilFotografi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.PictureBox profilFotografi;
        private System.Windows.Forms.CheckBox sifreGoster;
        private System.Windows.Forms.TextBox uyeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yetki;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblFotograf;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button dosyaSec;
    }
}