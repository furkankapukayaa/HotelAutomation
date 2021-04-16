
namespace FurkanHotel
{
    partial class uyeİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeİslemleri));
            this.sil = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.geriDon = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.uyeId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblUyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uYELER = new FurkanHotel.UYELER();
            this.sifreGoster = new System.Windows.Forms.CheckBox();
            this.uyeOlustur = new System.Windows.Forms.Button();
            this.temizlik = new System.Windows.Forms.Button();
            this.dosyaSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.profilFotografi = new System.Windows.Forms.PictureBox();
            this.tblUyeTableAdapter = new FurkanHotel.UYELERTableAdapters.tblUyeTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uYELER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilFotografi)).BeginInit();
            this.SuspendLayout();
            // 
            // sil
            // 
            this.sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sil.BackColor = System.Drawing.Color.Transparent;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sil.ImageIndex = 1;
            this.sil.ImageList = this.icons;
            this.sil.Location = new System.Drawing.Point(760, 487);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(50, 95);
            this.sil.TabIndex = 127;
            this.sil.Text = "Sil";
            this.sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "add.png");
            this.icons.Images.SetKeyName(1, "delete.png");
            this.icons.Images.SetKeyName(2, "update.png");
            this.icons.Images.SetKeyName(3, "clean.png");
            // 
            // geriDon
            // 
            this.geriDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriDon.BackgroundImage")));
            this.geriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriDon.FlatAppearance.BorderSize = 0;
            this.geriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDon.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.geriDon.Location = new System.Drawing.Point(1038, 653);
            this.geriDon.Margin = new System.Windows.Forms.Padding(4);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(96, 56);
            this.geriDon.TabIndex = 125;
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
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
            this.guncelle.ImageIndex = 2;
            this.guncelle.ImageList = this.icons;
            this.guncelle.Location = new System.Drawing.Point(596, 487);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(89, 91);
            this.guncelle.TabIndex = 124;
            this.guncelle.Text = "Güncelle";
            this.guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // yetki
            // 
            this.yetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.yetki.Location = new System.Drawing.Point(647, 292);
            this.yetki.Margin = new System.Windows.Forms.Padding(4);
            this.yetki.Name = "yetki";
            this.yetki.Size = new System.Drawing.Size(157, 31);
            this.yetki.TabIndex = 123;
            // 
            // telefon
            // 
            this.telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefon.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.Location = new System.Drawing.Point(647, 383);
            this.telefon.Margin = new System.Windows.Forms.Padding(4);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(157, 27);
            this.telefon.TabIndex = 121;
            // 
            // mail
            // 
            this.mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.Location = new System.Drawing.Point(647, 341);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(157, 27);
            this.mail.TabIndex = 120;
            // 
            // sifre
            // 
            this.sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(647, 246);
            this.sifre.Margin = new System.Windows.Forms.Padding(4);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '•';
            this.sifre.Size = new System.Drawing.Size(157, 27);
            this.sifre.TabIndex = 119;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciAdi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.Location = new System.Drawing.Point(647, 201);
            this.kullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(157, 27);
            this.kullaniciAdi.TabIndex = 118;
            // 
            // adSoyad
            // 
            this.adSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adSoyad.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad.Location = new System.Drawing.Point(647, 159);
            this.adSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(157, 27);
            this.adSoyad.TabIndex = 117;
            // 
            // lblYetki
            // 
            this.lblYetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblYetki.Location = new System.Drawing.Point(563, 291);
            this.lblYetki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(76, 37);
            this.lblYetki.TabIndex = 116;
            this.lblYetki.Text = "Yetki  :";
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblSifre.Location = new System.Drawing.Point(563, 243);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(69, 37);
            this.lblSifre.TabIndex = 115;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblAdSoyad.Location = new System.Drawing.Point(508, 156);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(124, 37);
            this.lblAdSoyad.TabIndex = 114;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblMail.Location = new System.Drawing.Point(574, 337);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(65, 37);
            this.lblMail.TabIndex = 113;
            this.lblMail.Text = "Mail :";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(489, 198);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(143, 37);
            this.lblKullaniciAdi.TabIndex = 112;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblFotograf
            // 
            this.lblFotograf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFotograf.AutoSize = true;
            this.lblFotograf.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblFotograf.Location = new System.Drawing.Point(526, 425);
            this.lblFotograf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFotograf.Name = "lblFotograf";
            this.lblFotograf.Size = new System.Drawing.Size(113, 37);
            this.lblFotograf.TabIndex = 111;
            this.lblFotograf.Text = "Fotoğraf :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblTelefon.Location = new System.Drawing.Point(539, 379);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(100, 37);
            this.lblTelefon.TabIndex = 110;
            this.lblTelefon.Text = "Telefon :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.label1.Location = new System.Drawing.Point(588, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 37);
            this.label1.TabIndex = 128;
            this.label1.Text = "Id :";
            // 
            // uyeId
            // 
            this.uyeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uyeId.Enabled = false;
            this.uyeId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeId.Location = new System.Drawing.Point(647, 118);
            this.uyeId.Margin = new System.Windows.Forms.Padding(4);
            this.uyeId.Name = "uyeId";
            this.uyeId.Size = new System.Drawing.Size(157, 27);
            this.uyeId.TabIndex = 129;
            this.uyeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.tblUyeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(272, 697);
            this.dataGridView1.TabIndex = 130;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblUyeBindingSource
            // 
            this.tblUyeBindingSource.DataMember = "tblUye";
            this.tblUyeBindingSource.DataSource = this.uYELER;
            // 
            // uYELER
            // 
            this.uYELER.DataSetName = "UYELER";
            this.uYELER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sifreGoster
            // 
            this.sifreGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreGoster.AutoSize = true;
            this.sifreGoster.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sifreGoster.Location = new System.Drawing.Point(811, 246);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(130, 25);
            this.sifreGoster.TabIndex = 131;
            this.sifreGoster.Text = "Şifreyi Göster";
            this.sifreGoster.UseVisualStyleBackColor = true;
            this.sifreGoster.CheckedChanged += new System.EventHandler(this.sifreGoster_CheckedChanged);
            // 
            // uyeOlustur
            // 
            this.uyeOlustur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uyeOlustur.BackColor = System.Drawing.Color.Transparent;
            this.uyeOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyeOlustur.FlatAppearance.BorderSize = 0;
            this.uyeOlustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uyeOlustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uyeOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyeOlustur.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uyeOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uyeOlustur.ImageIndex = 0;
            this.uyeOlustur.ImageList = this.icons;
            this.uyeOlustur.Location = new System.Drawing.Point(461, 487);
            this.uyeOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.uyeOlustur.Name = "uyeOlustur";
            this.uyeOlustur.Size = new System.Drawing.Size(50, 91);
            this.uyeOlustur.TabIndex = 132;
            this.uyeOlustur.Text = "Ekle";
            this.uyeOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uyeOlustur.UseVisualStyleBackColor = false;
            this.uyeOlustur.Click += new System.EventHandler(this.uyeOlustur_Click);
            // 
            // temizlik
            // 
            this.temizlik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temizlik.BackColor = System.Drawing.Color.Transparent;
            this.temizlik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizlik.FlatAppearance.BorderSize = 0;
            this.temizlik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.temizlik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.temizlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizlik.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.temizlik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.temizlik.ImageIndex = 3;
            this.temizlik.ImageList = this.icons;
            this.temizlik.Location = new System.Drawing.Point(883, 488);
            this.temizlik.Margin = new System.Windows.Forms.Padding(4);
            this.temizlik.Name = "temizlik";
            this.temizlik.Size = new System.Drawing.Size(82, 94);
            this.temizlik.TabIndex = 133;
            this.temizlik.Text = "Temizle";
            this.temizlik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.temizlik.UseVisualStyleBackColor = false;
            this.temizlik.Click += new System.EventHandler(this.temizlik_Click);
            // 
            // dosyaSec
            // 
            this.dosyaSec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosyaSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dosyaSec.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.dosyaSec.Location = new System.Drawing.Point(645, 428);
            this.dosyaSec.Name = "dosyaSec";
            this.dosyaSec.Size = new System.Drawing.Size(158, 27);
            this.dosyaSec.TabIndex = 153;
            this.dosyaSec.Text = "Dosya Seç";
            this.dosyaSec.UseVisualStyleBackColor = true;
            this.dosyaSec.Click += new System.EventHandler(this.dosyaSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // profilFotografi
            // 
            this.profilFotografi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilFotografi.Location = new System.Drawing.Point(290, 12);
            this.profilFotografi.Name = "profilFotografi";
            this.profilFotografi.Size = new System.Drawing.Size(160, 138);
            this.profilFotografi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilFotografi.TabIndex = 154;
            this.profilFotografi.TabStop = false;
            // 
            // tblUyeTableAdapter
            // 
            this.tblUyeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "uyeid";
            this.dataGridViewTextBoxColumn1.HeaderText = "uyeid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "uyeadsoyad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Çalışan Ad Soyad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "uyekullaniciadi";
            this.dataGridViewTextBoxColumn3.HeaderText = "uyekullaniciadi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "uyesifre";
            this.dataGridViewTextBoxColumn4.HeaderText = "uyesifre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "uyeyetki";
            this.dataGridViewTextBoxColumn5.HeaderText = "uyeyetki";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uyemail";
            this.dataGridViewTextBoxColumn6.HeaderText = "uyemail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "uyetelefon";
            this.dataGridViewTextBoxColumn7.HeaderText = "uyetelefon";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "uyefotograf";
            this.dataGridViewTextBoxColumn8.HeaderText = "uyefotograf";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // uyeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1147, 722);
            this.Controls.Add(this.profilFotografi);
            this.Controls.Add(this.dosyaSec);
            this.Controls.Add(this.temizlik);
            this.Controls.Add(this.uyeOlustur);
            this.Controls.Add(this.sifreGoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uyeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.guncelle);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uyeİslemleri";
            this.Text = "uyeler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.uyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uYELER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilFotografi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.Button guncelle;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uyeId;
        private System.Windows.Forms.CheckBox sifreGoster;
        private System.Windows.Forms.Button uyeOlustur;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Button temizlik;
        private System.Windows.Forms.Button dosyaSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox profilFotografi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UYELER uYELER;
        private System.Windows.Forms.BindingSource tblUyeBindingSource;
        private UYELERTableAdapters.tblUyeTableAdapter tblUyeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}