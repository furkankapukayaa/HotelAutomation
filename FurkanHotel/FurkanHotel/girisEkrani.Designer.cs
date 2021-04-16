
namespace FurkanHotel
{
    partial class girisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkrani));
            this.button1 = new System.Windows.Forms.Button();
            this.girisYap = new System.Windows.Forms.Button();
            this.cikisYap = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.picGiris = new System.Windows.Forms.PictureBox();
            this.sifreGoster = new System.Windows.Forms.CheckBox();
            this.giris = new System.Windows.Forms.GroupBox();
            this.sifremiUnuttum = new System.Windows.Forms.Button();
            this.uyeid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uYELER = new FurkanHotel.UYELER();
            this.tblUyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUyeTableAdapter = new FurkanHotel.UYELERTableAdapters.tblUyeTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picGiris)).BeginInit();
            this.giris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uYELER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1015, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 60);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // girisYap
            // 
            this.girisYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisYap.BackColor = System.Drawing.Color.Transparent;
            this.girisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisYap.BackgroundImage")));
            this.girisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.girisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYap.ForeColor = System.Drawing.Color.Transparent;
            this.girisYap.Location = new System.Drawing.Point(365, 211);
            this.girisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(59, 46);
            this.girisYap.TabIndex = 19;
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // cikisYap
            // 
            this.cikisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisYap.BackColor = System.Drawing.Color.Transparent;
            this.cikisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisYap.BackgroundImage")));
            this.cikisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisYap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cikisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYap.ForeColor = System.Drawing.Color.Transparent;
            this.cikisYap.Location = new System.Drawing.Point(1084, 479);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(59, 60);
            this.cikisYap.TabIndex = 18;
            this.cikisYap.UseVisualStyleBackColor = false;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // sifre
            // 
            this.sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.sifre.Location = new System.Drawing.Point(183, 133);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '•';
            this.sifre.Size = new System.Drawing.Size(188, 27);
            this.sifre.TabIndex = 17;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(38, 90);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(143, 37);
            this.lblKullaniciAdi.TabIndex = 16;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Poppins ExtraLight", 15.75F);
            this.lblSifre.Location = new System.Drawing.Point(94, 138);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(69, 37);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre :";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciAdi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi.Location = new System.Drawing.Point(183, 90);
            this.kullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(188, 27);
            this.kullaniciAdi.TabIndex = 14;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSlogan.Location = new System.Drawing.Point(12, 375);
            this.lblSlogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(451, 48);
            this.lblSlogan.TabIndex = 12;
            this.lblSlogan.Text = "Furkan Otel Otomasyon Sistemi";
            // 
            // picGiris
            // 
            this.picGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGiris.Image = ((System.Drawing.Image)(resources.GetObject("picGiris.Image")));
            this.picGiris.Location = new System.Drawing.Point(33, 79);
            this.picGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picGiris.Name = "picGiris";
            this.picGiris.Size = new System.Drawing.Size(399, 292);
            this.picGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGiris.TabIndex = 11;
            this.picGiris.TabStop = false;
            // 
            // sifreGoster
            // 
            this.sifreGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreGoster.AutoSize = true;
            this.sifreGoster.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sifreGoster.Location = new System.Drawing.Point(378, 133);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(130, 25);
            this.sifreGoster.TabIndex = 132;
            this.sifreGoster.Text = "Şifreyi Göster";
            this.sifreGoster.UseVisualStyleBackColor = true;
            this.sifreGoster.CheckedChanged += new System.EventHandler(this.sifreGoster_CheckedChanged);
            // 
            // giris
            // 
            this.giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.giris.AutoSize = true;
            this.giris.Controls.Add(this.sifremiUnuttum);
            this.giris.Controls.Add(this.kullaniciAdi);
            this.giris.Controls.Add(this.lblSifre);
            this.giris.Controls.Add(this.sifreGoster);
            this.giris.Controls.Add(this.lblKullaniciAdi);
            this.giris.Controls.Add(this.sifre);
            this.giris.Controls.Add(this.girisYap);
            this.giris.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(508, 154);
            this.giris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giris.Name = "giris";
            this.giris.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.giris.Size = new System.Drawing.Size(516, 287);
            this.giris.TabIndex = 134;
            this.giris.TabStop = false;
            this.giris.Text = "Giriş Yap";
            this.giris.Paint += new System.Windows.Forms.PaintEventHandler(this.giris_Paint);
            // 
            // sifremiUnuttum
            // 
            this.sifremiUnuttum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.sifremiUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifremiUnuttum.FlatAppearance.BorderSize = 0;
            this.sifremiUnuttum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sifremiUnuttum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifremiUnuttum.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifremiUnuttum.Location = new System.Drawing.Point(205, 167);
            this.sifremiUnuttum.Name = "sifremiUnuttum";
            this.sifremiUnuttum.Size = new System.Drawing.Size(166, 28);
            this.sifremiUnuttum.TabIndex = 138;
            this.sifremiUnuttum.Text = "Şifremi Unuttum !";
            this.sifremiUnuttum.UseVisualStyleBackColor = false;
            this.sifremiUnuttum.Click += new System.EventHandler(this.sifremiUnuttum_Click);
            // 
            // uyeid
            // 
            this.uyeid.AutoSize = true;
            this.uyeid.Location = new System.Drawing.Point(976, 503);
            this.uyeid.Name = "uyeid";
            this.uyeid.Size = new System.Drawing.Size(32, 13);
            this.uyeid.TabIndex = 135;
            this.uyeid.Text = "uyeid";
            this.uyeid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(936, 502);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(34, 37);
            this.dataGridView1.TabIndex = 138;
            this.dataGridView1.Visible = false;
            // 
            // uYELER
            // 
            this.uYELER.DataSetName = "UYELER";
            this.uYELER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUyeBindingSource
            // 
            this.tblUyeBindingSource.DataMember = "tblUye";
            this.tblUyeBindingSource.DataSource = this.uYELER;
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
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "uyeadsoyad";
            this.dataGridViewTextBoxColumn2.HeaderText = "uyeadsoyad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "uyekullaniciadi";
            this.dataGridViewTextBoxColumn3.HeaderText = "uyekullaniciadi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "uyesifre";
            this.dataGridViewTextBoxColumn4.HeaderText = "uyesifre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "uyeyetki";
            this.dataGridViewTextBoxColumn5.HeaderText = "uyeyetki";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uyemail";
            this.dataGridViewTextBoxColumn6.HeaderText = "uyemail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "uyetelefon";
            this.dataGridViewTextBoxColumn7.HeaderText = "uyetelefon";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "uyefotograf";
            this.dataGridViewTextBoxColumn8.HeaderText = "uyefotograf";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // girisEkrani
            // 
            this.AcceptButton = this.girisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cikisYap;
            this.ClientSize = new System.Drawing.Size(1153, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.uyeid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.picGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisEkrani";
            this.Text = "Giriş Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.girisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGiris)).EndInit();
            this.giris.ResumeLayout(false);
            this.giris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uYELER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUyeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.PictureBox picGiris;
        private System.Windows.Forms.CheckBox sifreGoster;
        private System.Windows.Forms.GroupBox giris;
        private System.Windows.Forms.Label uyeid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sifremiUnuttum;
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

