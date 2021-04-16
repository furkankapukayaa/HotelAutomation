
namespace FurkanHotel
{
    partial class odaİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odaİslemleri));
            this.lblId = new System.Windows.Forms.Label();
            this.odaAdi = new System.Windows.Forms.TextBox();
            this.lblOdaAdi = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.ıd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblOdaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbFurkanOtelDataSetODA2 = new FurkanHotel.dbFurkanOtelDataSetODA2();
            this.tblOdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guncelle = new System.Windows.Forms.Button();
            this.geriDon = new System.Windows.Forms.Button();
            this.odaOlustur = new System.Windows.Forms.Button();
            this.lblOdaTuru = new System.Windows.Forms.Label();
            this.odaTur = new System.Windows.Forms.ComboBox();
            this.lblKacKisilik = new System.Windows.Forms.Label();
            this.yetiskin = new System.Windows.Forms.ComboBox();
            this.lblYetiskin = new System.Windows.Forms.Label();
            this.lblCocuk = new System.Windows.Forms.Label();
            this.cocuk = new System.Windows.Forms.ComboBox();
            this.lblEvcilHayvan = new System.Windows.Forms.Label();
            this.evcilHayvan = new System.Windows.Forms.ComboBox();
            this.odaAciklama = new System.Windows.Forms.TextBox();
            this.lblOdaAciklama = new System.Windows.Forms.Label();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.temizlik = new System.Windows.Forms.Button();
            this.lblOdaDurum = new System.Windows.Forms.Label();
            this.odaDurum = new System.Windows.Forms.ComboBox();
            this.tblOdaTableAdapter1 = new FurkanHotel.dbFurkanOtelDataSetODA2TableAdapters.tblOdaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetODA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblId.Location = new System.Drawing.Point(489, 12);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 37);
            this.lblId.TabIndex = 189;
            this.lblId.Text = "Id :";
            // 
            // odaAdi
            // 
            this.odaAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaAdi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaAdi.Location = new System.Drawing.Point(541, 51);
            this.odaAdi.Margin = new System.Windows.Forms.Padding(4);
            this.odaAdi.Name = "odaAdi";
            this.odaAdi.Size = new System.Drawing.Size(157, 27);
            this.odaAdi.TabIndex = 188;
            // 
            // lblOdaAdi
            // 
            this.lblOdaAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdaAdi.AutoSize = true;
            this.lblOdaAdi.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblOdaAdi.Location = new System.Drawing.Point(428, 49);
            this.lblOdaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaAdi.Name = "lblOdaAdi";
            this.lblOdaAdi.Size = new System.Drawing.Size(108, 37);
            this.lblOdaAdi.TabIndex = 184;
            this.lblOdaAdi.Text = "Oda Adı :";
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
            this.sil.Location = new System.Drawing.Point(802, 426);
            this.sil.Margin = new System.Windows.Forms.Padding(4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(60, 88);
            this.sil.TabIndex = 180;
            this.sil.Text = "Sil";
            this.sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
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
            // ıd
            // 
            this.ıd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ıd.Enabled = false;
            this.ıd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıd.Location = new System.Drawing.Point(541, 16);
            this.ıd.Margin = new System.Windows.Forms.Padding(4);
            this.ıd.Name = "ıd";
            this.ıd.Size = new System.Drawing.Size(157, 27);
            this.ıd.TabIndex = 190;
            this.ıd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.tblOdaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(144, 523);
            this.dataGridView1.TabIndex = 179;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblOdaBindingSource1
            // 
            this.tblOdaBindingSource1.DataMember = "tblOda";
            this.tblOdaBindingSource1.DataSource = this.dbFurkanOtelDataSetODA2;
            // 
            // dbFurkanOtelDataSetODA2
            // 
            this.dbFurkanOtelDataSetODA2.DataSetName = "dbFurkanOtelDataSetODA2";
            this.dbFurkanOtelDataSetODA2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOdaBindingSource
            // 
            this.tblOdaBindingSource.DataMember = "tblOda";
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
            this.guncelle.Location = new System.Drawing.Point(596, 426);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(84, 88);
            this.guncelle.TabIndex = 176;
            this.guncelle.Text = "Güncelle";
            this.guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // geriDon
            // 
            this.geriDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.geriDon.BackColor = System.Drawing.Color.Transparent;
            this.geriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriDon.BackgroundImage")));
            this.geriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geriDon.FlatAppearance.BorderSize = 0;
            this.geriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geriDon.Location = new System.Drawing.Point(1099, 476);
            this.geriDon.Margin = new System.Windows.Forms.Padding(4);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(74, 58);
            this.geriDon.TabIndex = 174;
            this.geriDon.UseVisualStyleBackColor = false;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // odaOlustur
            // 
            this.odaOlustur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odaOlustur.FlatAppearance.BorderSize = 0;
            this.odaOlustur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.odaOlustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.odaOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaOlustur.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.odaOlustur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.odaOlustur.ImageKey = "add.png";
            this.odaOlustur.ImageList = this.icons;
            this.odaOlustur.Location = new System.Drawing.Point(423, 426);
            this.odaOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.odaOlustur.Name = "odaOlustur";
            this.odaOlustur.Size = new System.Drawing.Size(60, 93);
            this.odaOlustur.TabIndex = 173;
            this.odaOlustur.Text = "Ekle";
            this.odaOlustur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.odaOlustur.UseVisualStyleBackColor = true;
            this.odaOlustur.Click += new System.EventHandler(this.odaOlustur_Click);
            // 
            // lblOdaTuru
            // 
            this.lblOdaTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdaTuru.AutoSize = true;
            this.lblOdaTuru.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblOdaTuru.Location = new System.Drawing.Point(416, 118);
            this.lblOdaTuru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaTuru.Name = "lblOdaTuru";
            this.lblOdaTuru.Size = new System.Drawing.Size(120, 37);
            this.lblOdaTuru.TabIndex = 191;
            this.lblOdaTuru.Text = "Oda Türü :";
            // 
            // odaTur
            // 
            this.odaTur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odaTur.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.odaTur.FormattingEnabled = true;
            this.odaTur.Items.AddRange(new object[] {
            "Seçiniz",
            "Tek Kişilik Oda",
            "Çift Kişilik Oda",
            "Üç Kişilik Oda",
            "Dört Kişilik Oda",
            "Suite Oda",
            "Aile Odası",
            "Balayı Odası",
            "Kral Dairesi"});
            this.odaTur.Location = new System.Drawing.Point(541, 120);
            this.odaTur.Name = "odaTur";
            this.odaTur.Size = new System.Drawing.Size(157, 31);
            this.odaTur.TabIndex = 192;
            // 
            // lblKacKisilik
            // 
            this.lblKacKisilik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKacKisilik.AutoSize = true;
            this.lblKacKisilik.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblKacKisilik.Location = new System.Drawing.Point(420, 155);
            this.lblKacKisilik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKacKisilik.Name = "lblKacKisilik";
            this.lblKacKisilik.Size = new System.Drawing.Size(116, 37);
            this.lblKacKisilik.TabIndex = 193;
            this.lblKacKisilik.Text = "Kaç Kişilik :";
            // 
            // yetiskin
            // 
            this.yetiskin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yetiskin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yetiskin.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.yetiskin.FormattingEnabled = true;
            this.yetiskin.Items.AddRange(new object[] {
            "Seçiniz",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.yetiskin.Location = new System.Drawing.Point(543, 157);
            this.yetiskin.Name = "yetiskin";
            this.yetiskin.Size = new System.Drawing.Size(78, 31);
            this.yetiskin.TabIndex = 194;
            // 
            // lblYetiskin
            // 
            this.lblYetiskin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYetiskin.AutoSize = true;
            this.lblYetiskin.Font = new System.Drawing.Font("Poppins ExtraLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetiskin.Location = new System.Drawing.Point(628, 160);
            this.lblYetiskin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYetiskin.Name = "lblYetiskin";
            this.lblYetiskin.Size = new System.Drawing.Size(63, 26);
            this.lblYetiskin.TabIndex = 195;
            this.lblYetiskin.Text = "Yetişkin";
            // 
            // lblCocuk
            // 
            this.lblCocuk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCocuk.AutoSize = true;
            this.lblCocuk.Font = new System.Drawing.Font("Poppins ExtraLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCocuk.Location = new System.Drawing.Point(783, 160);
            this.lblCocuk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCocuk.Name = "lblCocuk";
            this.lblCocuk.Size = new System.Drawing.Size(100, 26);
            this.lblCocuk.TabIndex = 197;
            this.lblCocuk.Text = "Çocuk (0-6)";
            // 
            // cocuk
            // 
            this.cocuk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cocuk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cocuk.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.cocuk.FormattingEnabled = true;
            this.cocuk.Items.AddRange(new object[] {
            "Seçiniz",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cocuk.Location = new System.Drawing.Point(698, 157);
            this.cocuk.Name = "cocuk";
            this.cocuk.Size = new System.Drawing.Size(78, 31);
            this.cocuk.TabIndex = 196;
            // 
            // lblEvcilHayvan
            // 
            this.lblEvcilHayvan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEvcilHayvan.AutoSize = true;
            this.lblEvcilHayvan.Font = new System.Drawing.Font("Poppins ExtraLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvcilHayvan.Location = new System.Drawing.Point(975, 161);
            this.lblEvcilHayvan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvcilHayvan.Name = "lblEvcilHayvan";
            this.lblEvcilHayvan.Size = new System.Drawing.Size(101, 26);
            this.lblEvcilHayvan.TabIndex = 199;
            this.lblEvcilHayvan.Text = "Evcil Hayvan";
            // 
            // evcilHayvan
            // 
            this.evcilHayvan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.evcilHayvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.evcilHayvan.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.evcilHayvan.FormattingEnabled = true;
            this.evcilHayvan.Items.AddRange(new object[] {
            "Seçiniz",
            "Evet",
            "Hayır"});
            this.evcilHayvan.Location = new System.Drawing.Point(890, 157);
            this.evcilHayvan.Name = "evcilHayvan";
            this.evcilHayvan.Size = new System.Drawing.Size(78, 31);
            this.evcilHayvan.TabIndex = 198;
            // 
            // odaAciklama
            // 
            this.odaAciklama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaAciklama.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaAciklama.Location = new System.Drawing.Point(543, 236);
            this.odaAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.odaAciklama.Multiline = true;
            this.odaAciklama.Name = "odaAciklama";
            this.odaAciklama.Size = new System.Drawing.Size(448, 162);
            this.odaAciklama.TabIndex = 201;
            // 
            // lblOdaAciklama
            // 
            this.lblOdaAciklama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdaAciklama.AutoSize = true;
            this.lblOdaAciklama.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblOdaAciklama.Location = new System.Drawing.Point(369, 233);
            this.lblOdaAciklama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaAciklama.Name = "lblOdaAciklama";
            this.lblOdaAciklama.Size = new System.Drawing.Size(169, 37);
            this.lblOdaAciklama.TabIndex = 200;
            this.lblOdaAciklama.Text = "Oda Açıklama :";
            // 
            // lblUyarı
            // 
            this.lblUyarı.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblUyarı.Location = new System.Drawing.Point(544, 194);
            this.lblUyarı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(0, 37);
            this.lblUyarı.TabIndex = 202;
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
            this.temizlik.Location = new System.Drawing.Point(970, 426);
            this.temizlik.Margin = new System.Windows.Forms.Padding(4);
            this.temizlik.Name = "temizlik";
            this.temizlik.Size = new System.Drawing.Size(81, 88);
            this.temizlik.TabIndex = 203;
            this.temizlik.Text = "Temizle";
            this.temizlik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.temizlik.UseVisualStyleBackColor = true;
            this.temizlik.Click += new System.EventHandler(this.temizlik_Click);
            // 
            // lblOdaDurum
            // 
            this.lblOdaDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdaDurum.AutoSize = true;
            this.lblOdaDurum.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblOdaDurum.Location = new System.Drawing.Point(391, 83);
            this.lblOdaDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaDurum.Name = "lblOdaDurum";
            this.lblOdaDurum.Size = new System.Drawing.Size(146, 37);
            this.lblOdaDurum.TabIndex = 205;
            this.lblOdaDurum.Text = "Oda Durum :";
            // 
            // odaDurum
            // 
            this.odaDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odaDurum.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.odaDurum.FormattingEnabled = true;
            this.odaDurum.Items.AddRange(new object[] {
            "Seçiniz",
            "Boş",
            "Dolu"});
            this.odaDurum.Location = new System.Drawing.Point(541, 83);
            this.odaDurum.Name = "odaDurum";
            this.odaDurum.Size = new System.Drawing.Size(157, 31);
            this.odaDurum.TabIndex = 206;
            // 
            // tblOdaTableAdapter1
            // 
            this.tblOdaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "odaid";
            this.dataGridViewTextBoxColumn1.HeaderText = "odaid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "odaad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Oda Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "odatur";
            this.dataGridViewTextBoxColumn3.HeaderText = "odatur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "odakisisayisi";
            this.dataGridViewTextBoxColumn4.HeaderText = "odakisisayisi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "odaaciklama";
            this.dataGridViewTextBoxColumn5.HeaderText = "odaaciklama";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "odadurum";
            this.dataGridViewTextBoxColumn6.HeaderText = "odadurum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // odaİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 547);
            this.Controls.Add(this.odaDurum);
            this.Controls.Add(this.lblOdaDurum);
            this.Controls.Add(this.temizlik);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.odaAciklama);
            this.Controls.Add(this.lblOdaAciklama);
            this.Controls.Add(this.lblEvcilHayvan);
            this.Controls.Add(this.evcilHayvan);
            this.Controls.Add(this.lblCocuk);
            this.Controls.Add(this.cocuk);
            this.Controls.Add(this.lblYetiskin);
            this.Controls.Add(this.yetiskin);
            this.Controls.Add(this.lblKacKisilik);
            this.Controls.Add(this.odaTur);
            this.Controls.Add(this.lblOdaTuru);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.odaAdi);
            this.Controls.Add(this.lblOdaAdi);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ıd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.geriDon);
            this.Controls.Add(this.odaOlustur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "odaİslemleri";
            this.Text = "odaİslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.odaİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFurkanOtelDataSetODA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox odaAdi;
        private System.Windows.Forms.Label lblOdaAdi;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox ıd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.Button odaOlustur;
        private System.Windows.Forms.Label lblOdaTuru;
        private System.Windows.Forms.ComboBox odaTur;
        private System.Windows.Forms.Label lblKacKisilik;
        private System.Windows.Forms.ComboBox yetiskin;
        private System.Windows.Forms.Label lblYetiskin;
        private System.Windows.Forms.Label lblCocuk;
        private System.Windows.Forms.ComboBox cocuk;
        private System.Windows.Forms.Label lblEvcilHayvan;
        private System.Windows.Forms.ComboBox evcilHayvan;
        private System.Windows.Forms.TextBox odaAciklama;
        private System.Windows.Forms.Label lblOdaAciklama;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Button temizlik;
        private System.Windows.Forms.Label lblOdaDurum;
        private System.Windows.Forms.ComboBox odaDurum;
        private System.Windows.Forms.BindingSource tblOdaBindingSource;
        private dbFurkanOtelDataSetODA2 dbFurkanOtelDataSetODA2;
        private System.Windows.Forms.BindingSource tblOdaBindingSource1;
        private dbFurkanOtelDataSetODA2TableAdapters.tblOdaTableAdapter tblOdaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}