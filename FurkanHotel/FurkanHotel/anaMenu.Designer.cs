
namespace FurkanHotel
{
    partial class anaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaMenu));
            this.firmaLogo = new System.Windows.Forms.PictureBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.cikisYap = new System.Windows.Forms.Button();
            this.timerTarih = new System.Windows.Forms.Timer(this.components);
            this.uyeİslemleri = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.musteriİslemleri = new System.Windows.Forms.Button();
            this.odaİslemleri = new System.Windows.Forms.Button();
            this.satisİslemleri = new System.Windows.Forms.Button();
            this.profil = new System.Windows.Forms.Button();
            this.odalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firmaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaLogo
            // 
            this.firmaLogo.Image = ((System.Drawing.Image)(resources.GetObject("firmaLogo.Image")));
            this.firmaLogo.Location = new System.Drawing.Point(13, 13);
            this.firmaLogo.Margin = new System.Windows.Forms.Padding(4);
            this.firmaLogo.Name = "firmaLogo";
            this.firmaLogo.Size = new System.Drawing.Size(134, 132);
            this.firmaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firmaLogo.TabIndex = 67;
            this.firmaLogo.TabStop = false;
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarih.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(745, 9);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(257, 97);
            this.lblTarih.TabIndex = 66;
            this.lblTarih.Text = "Tarih ve Saat";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTarih.UseCompatibleTextRendering = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(99, 567);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(0, 37);
            this.lblKullaniciAdi.TabIndex = 71;
            // 
            // cikisYap
            // 
            this.cikisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisYap.BackColor = System.Drawing.Color.Transparent;
            this.cikisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisYap.BackgroundImage")));
            this.cikisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisYap.FlatAppearance.BorderSize = 0;
            this.cikisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cikisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisYap.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.ForeColor = System.Drawing.Color.Transparent;
            this.cikisYap.Location = new System.Drawing.Point(930, 550);
            this.cikisYap.Margin = new System.Windows.Forms.Padding(4);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(72, 57);
            this.cikisYap.TabIndex = 70;
            this.cikisYap.UseVisualStyleBackColor = true;
            this.cikisYap.Click += new System.EventHandler(this.cikisYap_Click);
            // 
            // timerTarih
            // 
            this.timerTarih.Enabled = true;
            this.timerTarih.Interval = 1000;
            this.timerTarih.Tick += new System.EventHandler(this.timerTarih_Tick);
            // 
            // uyeİslemleri
            // 
            this.uyeİslemleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uyeİslemleri.BackColor = System.Drawing.Color.Transparent;
            this.uyeİslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyeİslemleri.FlatAppearance.BorderSize = 0;
            this.uyeİslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uyeİslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uyeİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uyeİslemleri.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uyeİslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.uyeİslemleri.ImageIndex = 0;
            this.uyeİslemleri.ImageList = this.icons;
            this.uyeİslemleri.Location = new System.Drawing.Point(241, 109);
            this.uyeİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.uyeİslemleri.Name = "uyeİslemleri";
            this.uyeİslemleri.Size = new System.Drawing.Size(147, 134);
            this.uyeİslemleri.TabIndex = 74;
            this.uyeİslemleri.Text = "Çalışan İşlemleri";
            this.uyeİslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uyeİslemleri.UseVisualStyleBackColor = false;
            this.uyeİslemleri.Click += new System.EventHandler(this.uyeİslemleri_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "administrator.png");
            this.icons.Images.SetKeyName(1, "room.png");
            this.icons.Images.SetKeyName(2, "client.png");
            this.icons.Images.SetKeyName(3, "payment-method.png");
            this.icons.Images.SetKeyName(4, "rooms.png");
            // 
            // musteriİslemleri
            // 
            this.musteriİslemleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musteriİslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteriİslemleri.FlatAppearance.BorderSize = 0;
            this.musteriİslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.musteriİslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.musteriİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriİslemleri.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriİslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.musteriİslemleri.ImageIndex = 2;
            this.musteriİslemleri.ImageList = this.icons;
            this.musteriİslemleri.Location = new System.Drawing.Point(638, 110);
            this.musteriİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.musteriİslemleri.Name = "musteriİslemleri";
            this.musteriİslemleri.Size = new System.Drawing.Size(147, 133);
            this.musteriİslemleri.TabIndex = 75;
            this.musteriİslemleri.Text = "Müşteri İşlemleri";
            this.musteriİslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteriİslemleri.UseVisualStyleBackColor = true;
            this.musteriİslemleri.Click += new System.EventHandler(this.musteriİslemleri_Click);
            // 
            // odaİslemleri
            // 
            this.odaİslemleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odaİslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odaİslemleri.FlatAppearance.BorderSize = 0;
            this.odaİslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.odaİslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.odaİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaİslemleri.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaİslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.odaİslemleri.ImageIndex = 1;
            this.odaİslemleri.ImageList = this.icons;
            this.odaİslemleri.Location = new System.Drawing.Point(593, 265);
            this.odaİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.odaİslemleri.Name = "odaİslemleri";
            this.odaİslemleri.Size = new System.Drawing.Size(119, 136);
            this.odaİslemleri.TabIndex = 76;
            this.odaİslemleri.Text = "Oda İşlemleri";
            this.odaİslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.odaİslemleri.UseVisualStyleBackColor = true;
            this.odaİslemleri.Click += new System.EventHandler(this.odaİslemleri_Click);
            // 
            // satisİslemleri
            // 
            this.satisİslemleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.satisİslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.satisİslemleri.FlatAppearance.BorderSize = 0;
            this.satisİslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.satisİslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.satisİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisİslemleri.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisİslemleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.satisİslemleri.ImageIndex = 3;
            this.satisİslemleri.ImageList = this.icons;
            this.satisİslemleri.Location = new System.Drawing.Point(469, 425);
            this.satisİslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.satisİslemleri.Name = "satisİslemleri";
            this.satisİslemleri.Size = new System.Drawing.Size(130, 135);
            this.satisİslemleri.TabIndex = 77;
            this.satisİslemleri.Text = "Satış İşlemleri";
            this.satisİslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.satisİslemleri.UseVisualStyleBackColor = true;
            this.satisİslemleri.Click += new System.EventHandler(this.satisİslemleri_Click);
            // 
            // profil
            // 
            this.profil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profil.BackColor = System.Drawing.Color.Transparent;
            this.profil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profil.BackgroundImage")));
            this.profil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profil.FlatAppearance.BorderSize = 0;
            this.profil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profil.Location = new System.Drawing.Point(13, 530);
            this.profil.Margin = new System.Windows.Forms.Padding(4);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(105, 77);
            this.profil.TabIndex = 78;
            this.profil.UseVisualStyleBackColor = false;
            this.profil.Click += new System.EventHandler(this.profil_Click);
            // 
            // odalar
            // 
            this.odalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.odalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odalar.FlatAppearance.BorderSize = 0;
            this.odalar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.odalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.odalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odalar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odalar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.odalar.ImageIndex = 4;
            this.odalar.ImageList = this.icons;
            this.odalar.Location = new System.Drawing.Point(337, 265);
            this.odalar.Margin = new System.Windows.Forms.Padding(4);
            this.odalar.Name = "odalar";
            this.odalar.Size = new System.Drawing.Size(120, 134);
            this.odalar.TabIndex = 79;
            this.odalar.Text = "Odalar";
            this.odalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.odalar.UseVisualStyleBackColor = true;
            this.odalar.Click += new System.EventHandler(this.odalar_Click);
            // 
            // anaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 620);
            this.Controls.Add(this.odalar);
            this.Controls.Add(this.satisİslemleri);
            this.Controls.Add(this.odaİslemleri);
            this.Controls.Add(this.musteriİslemleri);
            this.Controls.Add(this.uyeİslemleri);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.cikisYap);
            this.Controls.Add(this.firmaLogo);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.profil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anaMenu";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.anaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox firmaLogo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button cikisYap;
        private System.Windows.Forms.Timer timerTarih;
        private System.Windows.Forms.Button uyeİslemleri;
        private System.Windows.Forms.Button musteriİslemleri;
        private System.Windows.Forms.Button odaİslemleri;
        private System.Windows.Forms.Button satisİslemleri;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Button profil;
        private System.Windows.Forms.Button odalar;
    }
}