namespace OtelOtomasyonV._3
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtPersonelSifre = new System.Windows.Forms.TextBox();
            this.TxtPersonelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnPersonelGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtAdminSifre = new System.Windows.Forms.TextBox();
            this.TxtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(130, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 175);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.TxtPersonelSifre);
            this.tabPage1.Controls.Add(this.TxtPersonelKullaniciAdi);
            this.tabPage1.Controls.Add(this.BtnPersonelGiris);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Giriş";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtPersonelSifre
            // 
            this.TxtPersonelSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPersonelSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelSifre.Location = new System.Drawing.Point(133, 68);
            this.TxtPersonelSifre.Name = "TxtPersonelSifre";
            this.TxtPersonelSifre.Size = new System.Drawing.Size(113, 25);
            this.TxtPersonelSifre.TabIndex = 9;
            this.TxtPersonelSifre.UseSystemPasswordChar = true;
            // 
            // TxtPersonelKullaniciAdi
            // 
            this.TxtPersonelKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPersonelKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelKullaniciAdi.Location = new System.Drawing.Point(133, 39);
            this.TxtPersonelKullaniciAdi.Name = "TxtPersonelKullaniciAdi";
            this.TxtPersonelKullaniciAdi.Size = new System.Drawing.Size(113, 25);
            this.TxtPersonelKullaniciAdi.TabIndex = 8;
            // 
            // BtnPersonelGiris
            // 
            this.BtnPersonelGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.BtnPersonelGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPersonelGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonelGiris.ForeColor = System.Drawing.Color.White;
            this.BtnPersonelGiris.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonelGiris.Image")));
            this.BtnPersonelGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonelGiris.Location = new System.Drawing.Point(133, 99);
            this.BtnPersonelGiris.Name = "BtnPersonelGiris";
            this.BtnPersonelGiris.Size = new System.Drawing.Size(113, 40);
            this.BtnPersonelGiris.TabIndex = 10;
            this.BtnPersonelGiris.Text = "Giriş";
            this.BtnPersonelGiris.UseVisualStyleBackColor = false;
            this.BtnPersonelGiris.Click += new System.EventHandler(this.BtnPersonelGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtAdminSifre);
            this.tabPage2.Controls.Add(this.TxtAdminKullaniciAdi);
            this.tabPage2.Controls.Add(this.BtnAdminGiris);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 145);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin Giriş";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtAdminSifre
            // 
            this.TxtAdminSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtAdminSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdminSifre.Location = new System.Drawing.Point(132, 68);
            this.TxtAdminSifre.Name = "TxtAdminSifre";
            this.TxtAdminSifre.Size = new System.Drawing.Size(113, 25);
            this.TxtAdminSifre.TabIndex = 4;
            this.TxtAdminSifre.UseSystemPasswordChar = true;
            // 
            // TxtAdminKullaniciAdi
            // 
            this.TxtAdminKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtAdminKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdminKullaniciAdi.Location = new System.Drawing.Point(132, 39);
            this.TxtAdminKullaniciAdi.Name = "TxtAdminKullaniciAdi";
            this.TxtAdminKullaniciAdi.Size = new System.Drawing.Size(113, 25);
            this.TxtAdminKullaniciAdi.TabIndex = 3;
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.Red;
            this.BtnAdminGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdminGiris.CausesValidation = false;
            this.BtnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminGiris.ForeColor = System.Drawing.Color.White;
            this.BtnAdminGiris.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdminGiris.Image")));
            this.BtnAdminGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdminGiris.Location = new System.Drawing.Point(78, 100);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(130, 39);
            this.BtnAdminGiris.TabIndex = 5;
            this.BtnAdminGiris.Text = "Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 341);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Otomasyon";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtAdminSifre;
        private System.Windows.Forms.TextBox TxtAdminKullaniciAdi;
        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPersonelSifre;
        private System.Windows.Forms.TextBox TxtPersonelKullaniciAdi;
        private System.Windows.Forms.Button BtnPersonelGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

