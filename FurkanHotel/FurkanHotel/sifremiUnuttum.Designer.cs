
namespace FurkanHotel
{
    partial class sifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifremiUnuttum));
            this.dogrula = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.onayKodu = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.sifreGuncelle = new System.Windows.Forms.Button();
            this.sifreTekrar = new System.Windows.Forms.TextBox();
            this.sifreSifirla = new System.Windows.Forms.GroupBox();
            this.sifreGosterTekrar = new System.Windows.Forms.CheckBox();
            this.sifreGoster = new System.Windows.Forms.CheckBox();
            this.lblTekrarYeniSifre = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.verify = new System.Windows.Forms.PictureBox();
            this.lblAktivasyonGir = new System.Windows.Forms.Label();
            this.sifreSifirla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verify)).BeginInit();
            this.SuspendLayout();
            // 
            // dogrula
            // 
            this.dogrula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dogrula.BackColor = System.Drawing.Color.Transparent;
            this.dogrula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dogrula.FlatAppearance.BorderSize = 0;
            this.dogrula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dogrula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dogrula.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dogrula.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dogrula.ImageKey = "check.png";
            this.dogrula.ImageList = this.icons;
            this.dogrula.Location = new System.Drawing.Point(600, 135);
            this.dogrula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dogrula.Name = "dogrula";
            this.dogrula.Size = new System.Drawing.Size(119, 110);
            this.dogrula.TabIndex = 36;
            this.dogrula.Text = "Doğrula";
            this.dogrula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dogrula.UseVisualStyleBackColor = false;
            this.dogrula.Click += new System.EventHandler(this.dogrula_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "check.png");
            this.icons.Images.SetKeyName(1, "rotation-lock.png");
            // 
            // onayKodu
            // 
            this.onayKodu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.onayKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayKodu.Location = new System.Drawing.Point(304, 171);
            this.onayKodu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onayKodu.Name = "onayKodu";
            this.onayKodu.Size = new System.Drawing.Size(249, 31);
            this.onayKodu.TabIndex = 35;
            this.onayKodu.TextChanged += new System.EventHandler(this.onayKodu_TextChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(231, 44);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(375, 72);
            this.lblBaslik.TabIndex = 34;
            this.lblBaslik.Text = "KAYITLI MAİL ADRESİNE AKTİVASYON\r\nKODU GÖNDERİLDİ!";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sifre
            // 
            this.sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(49, 54);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(249, 31);
            this.sifre.TabIndex = 30;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // sifreGuncelle
            // 
            this.sifreGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.sifreGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifreGuncelle.FlatAppearance.BorderSize = 0;
            this.sifreGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sifreGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sifreGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifreGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sifreGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sifreGuncelle.ImageKey = "rotation-lock.png";
            this.sifreGuncelle.ImageList = this.icons;
            this.sifreGuncelle.Location = new System.Drawing.Point(228, 199);
            this.sifreGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreGuncelle.Name = "sifreGuncelle";
            this.sifreGuncelle.Size = new System.Drawing.Size(177, 107);
            this.sifreGuncelle.TabIndex = 32;
            this.sifreGuncelle.Text = "Şifreyi Değiştir";
            this.sifreGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sifreGuncelle.UseVisualStyleBackColor = false;
            this.sifreGuncelle.Click += new System.EventHandler(this.sifreGuncelle_Click);
            // 
            // sifreTekrar
            // 
            this.sifreTekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTekrar.Location = new System.Drawing.Point(49, 135);
            this.sifreTekrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifreTekrar.Name = "sifreTekrar";
            this.sifreTekrar.Size = new System.Drawing.Size(249, 31);
            this.sifreTekrar.TabIndex = 31;
            this.sifreTekrar.UseSystemPasswordChar = true;
            this.sifreTekrar.TextChanged += new System.EventHandler(this.sifreTekrar_TextChanged);
            // 
            // sifreSifirla
            // 
            this.sifreSifirla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreSifirla.Controls.Add(this.sifreGosterTekrar);
            this.sifreSifirla.Controls.Add(this.sifreGoster);
            this.sifreSifirla.Controls.Add(this.lblTekrarYeniSifre);
            this.sifreSifirla.Controls.Add(this.sifreTekrar);
            this.sifreSifirla.Controls.Add(this.lblYeniSifre);
            this.sifreSifirla.Controls.Add(this.sifreGuncelle);
            this.sifreSifirla.Controls.Add(this.sifre);
            this.sifreSifirla.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.sifreSifirla.Location = new System.Drawing.Point(73, 350);
            this.sifreSifirla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreSifirla.Name = "sifreSifirla";
            this.sifreSifirla.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreSifirla.Size = new System.Drawing.Size(604, 332);
            this.sifreSifirla.TabIndex = 37;
            this.sifreSifirla.TabStop = false;
            this.sifreSifirla.Text = "Şifre Sıfırla";
            this.sifreSifirla.Visible = false;
            // 
            // sifreGosterTekrar
            // 
            this.sifreGosterTekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreGosterTekrar.AutoSize = true;
            this.sifreGosterTekrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sifreGosterTekrar.Location = new System.Drawing.Point(308, 143);
            this.sifreGosterTekrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifreGosterTekrar.Name = "sifreGosterTekrar";
            this.sifreGosterTekrar.Size = new System.Drawing.Size(130, 25);
            this.sifreGosterTekrar.TabIndex = 134;
            this.sifreGosterTekrar.Text = "Şifreyi Göster";
            this.sifreGosterTekrar.UseVisualStyleBackColor = true;
            this.sifreGosterTekrar.CheckedChanged += new System.EventHandler(this.sifreGosterTekrar_CheckedChanged);
            // 
            // sifreGoster
            // 
            this.sifreGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreGoster.AutoSize = true;
            this.sifreGoster.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.sifreGoster.Location = new System.Drawing.Point(308, 60);
            this.sifreGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifreGoster.Name = "sifreGoster";
            this.sifreGoster.Size = new System.Drawing.Size(130, 25);
            this.sifreGoster.TabIndex = 133;
            this.sifreGoster.Text = "Şifreyi Göster";
            this.sifreGoster.UseVisualStyleBackColor = true;
            this.sifreGoster.CheckedChanged += new System.EventHandler(this.sifreGoster_CheckedChanged);
            // 
            // lblTekrarYeniSifre
            // 
            this.lblTekrarYeniSifre.AutoSize = true;
            this.lblTekrarYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTekrarYeniSifre.ForeColor = System.Drawing.Color.Red;
            this.lblTekrarYeniSifre.Location = new System.Drawing.Point(45, 177);
            this.lblTekrarYeniSifre.Name = "lblTekrarYeniSifre";
            this.lblTekrarYeniSifre.Size = new System.Drawing.Size(165, 16);
            this.lblTekrarYeniSifre.TabIndex = 41;
            this.lblTekrarYeniSifre.Text = "*Yeni Şifreyi Tekrar Giriniz.";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblYeniSifre.ForeColor = System.Drawing.Color.Red;
            this.lblYeniSifre.Location = new System.Drawing.Point(45, 96);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(122, 16);
            this.lblYeniSifre.TabIndex = 40;
            this.lblYeniSifre.Text = "*Yeni Şifreyi Giriniz.";
            // 
            // verify
            // 
            this.verify.Image = ((System.Drawing.Image)(resources.GetObject("verify.Image")));
            this.verify.Location = new System.Drawing.Point(12, 19);
            this.verify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(221, 226);
            this.verify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verify.TabIndex = 38;
            this.verify.TabStop = false;
            // 
            // lblAktivasyonGir
            // 
            this.lblAktivasyonGir.AutoSize = true;
            this.lblAktivasyonGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktivasyonGir.ForeColor = System.Drawing.Color.Red;
            this.lblAktivasyonGir.Location = new System.Drawing.Point(300, 213);
            this.lblAktivasyonGir.Name = "lblAktivasyonGir";
            this.lblAktivasyonGir.Size = new System.Drawing.Size(169, 16);
            this.lblAktivasyonGir.TabIndex = 39;
            this.lblAktivasyonGir.Text = "*Aktivasyon Kodunu Giriniz.";
            // 
            // sifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 695);
            this.Controls.Add(this.lblAktivasyonGir);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.dogrula);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.onayKodu);
            this.Controls.Add(this.sifreSifirla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sifremiUnuttum";
            this.Text = "Şifremi Unuttum ";
            this.Load += new System.EventHandler(this.sifremiUnuttum_Load);
            this.sifreSifirla.ResumeLayout(false);
            this.sifreSifirla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dogrula;
        private System.Windows.Forms.TextBox onayKodu;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button sifreGuncelle;
        private System.Windows.Forms.TextBox sifreTekrar;
        private System.Windows.Forms.GroupBox sifreSifirla;
        private System.Windows.Forms.PictureBox verify;
        private System.Windows.Forms.Label lblAktivasyonGir;
        private System.Windows.Forms.Label lblTekrarYeniSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.CheckBox sifreGosterTekrar;
        private System.Windows.Forms.CheckBox sifreGoster;
        private System.Windows.Forms.ImageList icons;
    }
}