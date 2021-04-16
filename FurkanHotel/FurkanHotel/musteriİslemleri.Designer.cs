
namespace FurkanHotel
{
    partial class musteriİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriİslemleri));
            this.guncelle = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.geriDon = new System.Windows.Forms.Button();
            this.musteriOlustur = new System.Windows.Forms.Button();
            this.telefon = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteritcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriadsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterimailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteritelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriaracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterigiristarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustericikistarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriodanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbFurkanOtelDataSetMUSTERİ = new FurkanHotel.dbFurkanOtelDataSetMUSTERİ();
            this.sil = new System.Windows.Forms.Button();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lblArac = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.arac = new System.Windows.Forms.TextBox();
            this.girisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.odaNo = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.ıd = new System.Windows.Forms.TextBox();
            this.tblMusteriTableAdapter = new FurkanHotel.dbFurkanOtelDataSetMUSTERİTableAdapters.tblMusteriTableAdapter();
            this.temizlik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetMUSTERİ)).BeginInit();
            this.SuspendLayout();
            // 
            // guncelle
            // 
            this.guncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle.FlatAppearance.BorderSize = 0;
            this.guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.guncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guncelle.ImageKey = "update.png";
            this.guncelle.ImageList = this.icons;
            this.guncelle.Location = new System.Drawing.Point(529, 445);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(85, 88);
            this.guncelle.TabIndex = 152;
            this.guncelle.Text = "Güncelle";
            this.guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "add.png");
            this.icons.Images.SetKeyName(1, "update.png");
            this.icons.Images.SetKeyName(2, "delete.png");
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
            this.geriDon.Location = new System.Drawing.Point(930, 539);
            this.geriDon.Margin = new System.Windows.Forms.Padding(4);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(77, 61);
            this.geriDon.TabIndex = 150;
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // musteriOlustur
            // 
            this.musteriOlustur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musteriOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteriOlustur.FlatAppearance.BorderSize = 0;
            this.musteriOlustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.musteriOlustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.musteriOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriOlustur.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.musteriOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.musteriOlustur.ImageKey = "add.png";
            this.musteriOlustur.ImageList = this.icons;
            this.musteriOlustur.Location = new System.Drawing.Point(413, 445);
            this.musteriOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.musteriOlustur.Name = "musteriOlustur";
            this.musteriOlustur.Size = new System.Drawing.Size(60, 91);
            this.musteriOlustur.TabIndex = 149;
            this.musteriOlustur.Text = "Ekle";
            this.musteriOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteriOlustur.UseVisualStyleBackColor = true;
            this.musteriOlustur.Click += new System.EventHandler(this.musteriOlustur_Click);
            // 
            // telefon
            // 
            this.telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefon.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon.Location = new System.Drawing.Point(542, 241);
            this.telefon.Margin = new System.Windows.Forms.Padding(4);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(224, 27);
            this.telefon.TabIndex = 146;
            // 
            // mail
            // 
            this.mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.Location = new System.Drawing.Point(542, 204);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(224, 27);
            this.mail.TabIndex = 145;
            // 
            // adSoyad
            // 
            this.adSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adSoyad.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad.Location = new System.Drawing.Point(542, 169);
            this.adSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(224, 27);
            this.adSoyad.TabIndex = 142;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblAdSoyad.Location = new System.Drawing.Point(410, 164);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(124, 37);
            this.lblAdSoyad.TabIndex = 138;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblMail.Location = new System.Drawing.Point(469, 199);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(65, 37);
            this.lblMail.TabIndex = 137;
            this.lblMail.Text = "Mail :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblTelefon.Location = new System.Drawing.Point(434, 236);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(100, 37);
            this.lblTelefon.TabIndex = 134;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblTc
            // 
            this.lblTc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblTc.Location = new System.Drawing.Point(482, 127);
            this.lblTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(52, 37);
            this.lblTc.TabIndex = 153;
            this.lblTc.Text = "TC :";
            // 
            // tc
            // 
            this.tc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(542, 132);
            this.tc.Margin = new System.Windows.Forms.Padding(4);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(224, 27);
            this.tc.TabIndex = 154;
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
            this.musteriidDataGridViewTextBoxColumn,
            this.musteritcDataGridViewTextBoxColumn,
            this.musteriadsoyadDataGridViewTextBoxColumn,
            this.musterimailDataGridViewTextBoxColumn,
            this.musteritelefonDataGridViewTextBoxColumn,
            this.musteriaracDataGridViewTextBoxColumn,
            this.musterigiristarihDataGridViewTextBoxColumn,
            this.mustericikistarihDataGridViewTextBoxColumn,
            this.musteriodanoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(207, 589);
            this.dataGridView1.TabIndex = 155;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteriid";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteriid";
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            this.musteriidDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriidDataGridViewTextBoxColumn.Visible = false;
            // 
            // musteritcDataGridViewTextBoxColumn
            // 
            this.musteritcDataGridViewTextBoxColumn.DataPropertyName = "musteritc";
            this.musteritcDataGridViewTextBoxColumn.HeaderText = "musteritc";
            this.musteritcDataGridViewTextBoxColumn.Name = "musteritcDataGridViewTextBoxColumn";
            this.musteritcDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteritcDataGridViewTextBoxColumn.Visible = false;
            // 
            // musteriadsoyadDataGridViewTextBoxColumn
            // 
            this.musteriadsoyadDataGridViewTextBoxColumn.DataPropertyName = "musteriadsoyad";
            this.musteriadsoyadDataGridViewTextBoxColumn.HeaderText = "Müşteri Ad Soyad";
            this.musteriadsoyadDataGridViewTextBoxColumn.Name = "musteriadsoyadDataGridViewTextBoxColumn";
            this.musteriadsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musterimailDataGridViewTextBoxColumn
            // 
            this.musterimailDataGridViewTextBoxColumn.DataPropertyName = "musterimail";
            this.musterimailDataGridViewTextBoxColumn.HeaderText = "musterimail";
            this.musterimailDataGridViewTextBoxColumn.Name = "musterimailDataGridViewTextBoxColumn";
            this.musterimailDataGridViewTextBoxColumn.ReadOnly = true;
            this.musterimailDataGridViewTextBoxColumn.Visible = false;
            // 
            // musteritelefonDataGridViewTextBoxColumn
            // 
            this.musteritelefonDataGridViewTextBoxColumn.DataPropertyName = "musteritelefon";
            this.musteritelefonDataGridViewTextBoxColumn.HeaderText = "musteritelefon";
            this.musteritelefonDataGridViewTextBoxColumn.Name = "musteritelefonDataGridViewTextBoxColumn";
            this.musteritelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteritelefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // musteriaracDataGridViewTextBoxColumn
            // 
            this.musteriaracDataGridViewTextBoxColumn.DataPropertyName = "musteriarac";
            this.musteriaracDataGridViewTextBoxColumn.HeaderText = "musteriarac";
            this.musteriaracDataGridViewTextBoxColumn.Name = "musteriaracDataGridViewTextBoxColumn";
            this.musteriaracDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriaracDataGridViewTextBoxColumn.Visible = false;
            // 
            // musterigiristarihDataGridViewTextBoxColumn
            // 
            this.musterigiristarihDataGridViewTextBoxColumn.DataPropertyName = "musterigiristarih";
            this.musterigiristarihDataGridViewTextBoxColumn.HeaderText = "musterigiristarih";
            this.musterigiristarihDataGridViewTextBoxColumn.Name = "musterigiristarihDataGridViewTextBoxColumn";
            this.musterigiristarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.musterigiristarihDataGridViewTextBoxColumn.Visible = false;
            // 
            // mustericikistarihDataGridViewTextBoxColumn
            // 
            this.mustericikistarihDataGridViewTextBoxColumn.DataPropertyName = "mustericikistarih";
            this.mustericikistarihDataGridViewTextBoxColumn.HeaderText = "mustericikistarih";
            this.mustericikistarihDataGridViewTextBoxColumn.Name = "mustericikistarihDataGridViewTextBoxColumn";
            this.mustericikistarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.mustericikistarihDataGridViewTextBoxColumn.Visible = false;
            // 
            // musteriodanoDataGridViewTextBoxColumn
            // 
            this.musteriodanoDataGridViewTextBoxColumn.DataPropertyName = "musteriodano";
            this.musteriodanoDataGridViewTextBoxColumn.HeaderText = "musteriodano";
            this.musteriodanoDataGridViewTextBoxColumn.Name = "musteriodanoDataGridViewTextBoxColumn";
            this.musteriodanoDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriodanoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "tblMusteri";
            this.tblMusteriBindingSource.DataSource = this.dbFurkanOtelDataSetMUSTERİ;
            // 
            // dbFurkanOtelDataSetMUSTERİ
            // 
            this.dbFurkanOtelDataSetMUSTERİ.DataSetName = "dbFurkanOtelDataSetMUSTERİ";
            this.dbFurkanOtelDataSetMUSTERİ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sil
            // 
            this.sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sil.ImageKey = "delete.png";
            this.sil.ImageList = this.icons;
            this.sil.Location = new System.Drawing.Point(661, 445);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(60, 88);
            this.sil.TabIndex = 156;
            this.sil.Text = "Sil";
            this.sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblGiris.Location = new System.Drawing.Point(408, 310);
            this.lblGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(126, 37);
            this.lblGiris.TabIndex = 157;
            this.lblGiris.Text = "Giriş Tarihi :";
            // 
            // lblCikis
            // 
            this.lblCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblCikis.Location = new System.Drawing.Point(407, 347);
            this.lblCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(127, 37);
            this.lblCikis.TabIndex = 158;
            this.lblCikis.Text = "Çıkış Tarihi :";
            // 
            // lblArac
            // 
            this.lblArac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArac.AutoSize = true;
            this.lblArac.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblArac.Location = new System.Drawing.Point(461, 273);
            this.lblArac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArac.Name = "lblArac";
            this.lblArac.Size = new System.Drawing.Size(73, 37);
            this.lblArac.TabIndex = 159;
            this.lblArac.Text = "Araç :";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblOdaNo.Location = new System.Drawing.Point(429, 383);
            this.lblOdaNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(105, 37);
            this.lblOdaNo.TabIndex = 160;
            this.lblOdaNo.Text = "Oda No :";
            // 
            // arac
            // 
            this.arac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arac.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arac.Location = new System.Drawing.Point(542, 278);
            this.arac.Margin = new System.Windows.Forms.Padding(4);
            this.arac.Name = "arac";
            this.arac.Size = new System.Drawing.Size(224, 27);
            this.arac.TabIndex = 161;
            // 
            // girisTarihi
            // 
            this.girisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisTarihi.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.girisTarihi.Location = new System.Drawing.Point(542, 314);
            this.girisTarihi.Name = "girisTarihi";
            this.girisTarihi.Size = new System.Drawing.Size(224, 27);
            this.girisTarihi.TabIndex = 162;
            // 
            // cikisTarihi
            // 
            this.cikisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cikisTarihi.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cikisTarihi.Location = new System.Drawing.Point(542, 351);
            this.cikisTarihi.Name = "cikisTarihi";
            this.cikisTarihi.Size = new System.Drawing.Size(224, 27);
            this.cikisTarihi.TabIndex = 163;
            // 
            // odaNo
            // 
            this.odaNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaNo.Enabled = false;
            this.odaNo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaNo.Location = new System.Drawing.Point(542, 385);
            this.odaNo.Margin = new System.Windows.Forms.Padding(4);
            this.odaNo.Name = "odaNo";
            this.odaNo.Size = new System.Drawing.Size(224, 27);
            this.odaNo.TabIndex = 164;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblId.Location = new System.Drawing.Point(490, 90);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 37);
            this.lblId.TabIndex = 165;
            this.lblId.Text = "Id :";
            // 
            // ıd
            // 
            this.ıd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ıd.Enabled = false;
            this.ıd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıd.Location = new System.Drawing.Point(542, 95);
            this.ıd.Margin = new System.Windows.Forms.Padding(4);
            this.ıd.Name = "ıd";
            this.ıd.Size = new System.Drawing.Size(224, 27);
            this.ıd.TabIndex = 166;
            this.ıd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblMusteriTableAdapter
            // 
            this.tblMusteriTableAdapter.ClearBeforeFill = true;
            // 
            // temizlik
            // 
            this.temizlik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temizlik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizlik.FlatAppearance.BorderSize = 0;
            this.temizlik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.temizlik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.temizlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizlik.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.temizlik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.temizlik.ImageKey = "clean.png";
            this.temizlik.ImageList = this.icons;
            this.temizlik.Location = new System.Drawing.Point(764, 445);
            this.temizlik.Margin = new System.Windows.Forms.Padding(4);
            this.temizlik.Name = "temizlik";
            this.temizlik.Size = new System.Drawing.Size(85, 88);
            this.temizlik.TabIndex = 167;
            this.temizlik.Text = "Temizle";
            this.temizlik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.temizlik.UseVisualStyleBackColor = true;
            this.temizlik.Click += new System.EventHandler(this.temizlik_Click);
            // 
            // musteriİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 613);
            this.Controls.Add(this.temizlik);
            this.Controls.Add(this.ıd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.odaNo);
            this.Controls.Add(this.cikisTarihi);
            this.Controls.Add(this.girisTarihi);
            this.Controls.Add(this.arac);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.lblArac);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.musteriOlustur);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "musteriİslemleri";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.musteriİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetMUSTERİ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.Button musteriOlustur;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label lblArac;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.TextBox arac;
        private System.Windows.Forms.DateTimePicker girisTarihi;
        private System.Windows.Forms.DateTimePicker cikisTarihi;
        private System.Windows.Forms.TextBox odaNo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox ıd;
        private dbFurkanOtelDataSetMUSTERİ dbFurkanOtelDataSetMUSTERİ;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private dbFurkanOtelDataSetMUSTERİTableAdapters.tblMusteriTableAdapter tblMusteriTableAdapter;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Button temizlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteritcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriadsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterimailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteritelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriaracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterigiristarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustericikistarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriodanoDataGridViewTextBoxColumn;
    }
}