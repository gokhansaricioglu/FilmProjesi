namespace Giris
{
    partial class Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TbSifre = new System.Windows.Forms.TextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.LinklLblSfremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.LinkLblKAyitOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // TbKullaniciAdi
            // 
            this.TbKullaniciAdi.Location = new System.Drawing.Point(129, 39);
            this.TbKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TbKullaniciAdi.Name = "TbKullaniciAdi";
            this.TbKullaniciAdi.Size = new System.Drawing.Size(200, 22);
            this.TbKullaniciAdi.TabIndex = 2;
            // 
            // TbSifre
            // 
            this.TbSifre.Location = new System.Drawing.Point(129, 91);
            this.TbSifre.Margin = new System.Windows.Forms.Padding(4);
            this.TbSifre.Name = "TbSifre";
            this.TbSifre.PasswordChar = '*';
            this.TbSifre.Size = new System.Drawing.Size(200, 22);
            this.TbSifre.TabIndex = 3;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(129, 139);
            this.BtnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(100, 28);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "Giriş Yap ";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // LinklLblSfremiUnuttum
            // 
            this.LinklLblSfremiUnuttum.AutoSize = true;
            this.LinklLblSfremiUnuttum.Location = new System.Drawing.Point(126, 194);
            this.LinklLblSfremiUnuttum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinklLblSfremiUnuttum.Name = "LinklLblSfremiUnuttum";
            this.LinklLblSfremiUnuttum.Size = new System.Drawing.Size(108, 17);
            this.LinklLblSfremiUnuttum.TabIndex = 5;
            this.LinklLblSfremiUnuttum.TabStop = true;
            this.LinklLblSfremiUnuttum.Text = "Şifremi Unuttum";
            this.LinklLblSfremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklLblSfremiUnuttum_LinkClicked);
            // 
            // LinkLblKAyitOl
            // 
            this.LinkLblKAyitOl.AutoSize = true;
            this.LinkLblKAyitOl.Location = new System.Drawing.Point(144, 234);
            this.LinkLblKAyitOl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLblKAyitOl.Name = "LinkLblKAyitOl";
            this.LinkLblKAyitOl.Size = new System.Drawing.Size(57, 17);
            this.LinkLblKAyitOl.TabIndex = 6;
            this.LinkLblKAyitOl.TabStop = true;
            this.LinkLblKAyitOl.Text = "Kayıt Ol";
            this.LinkLblKAyitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblKAyitOl_LinkClicked);
            // 
            // Giris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 334);
            this.Controls.Add(this.LinkLblKAyitOl);
            this.Controls.Add(this.LinklLblSfremiUnuttum);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TbSifre);
            this.Controls.Add(this.TbKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbKullaniciAdi;
        private System.Windows.Forms.TextBox TbSifre;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.LinkLabel LinklLblSfremiUnuttum;
        private System.Windows.Forms.LinkLabel LinkLblKAyitOl;
    }
}

