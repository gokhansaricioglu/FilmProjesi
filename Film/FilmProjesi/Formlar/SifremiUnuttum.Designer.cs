namespace FilmProjesi.Formlar
{
    partial class SifremiUnuttum
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
            this.TbKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbGuvenlikSorusu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MtBSifre = new System.Windows.Forms.MaskedTextBox();
            this.MtBSifreTekrar = new System.Windows.Forms.MaskedTextBox();
            this.BtnSiteyeGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // TbKullanıcıAdi
            // 
            this.TbKullanıcıAdi.Location = new System.Drawing.Point(132, 32);
            this.TbKullanıcıAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbKullanıcıAdi.Name = "TbKullanıcıAdi";
            this.TbKullanıcıAdi.Size = new System.Drawing.Size(122, 20);
            this.TbKullanıcıAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Güvenlik Sorusu";
            // 
            // LbGuvenlikSorusu
            // 
            this.LbGuvenlikSorusu.AutoSize = true;
            this.LbGuvenlikSorusu.Location = new System.Drawing.Point(130, 82);
            this.LbGuvenlikSorusu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbGuvenlikSorusu.Name = "LbGuvenlikSorusu";
            this.LbGuvenlikSorusu.Size = new System.Drawing.Size(124, 13);
            this.LbGuvenlikSorusu.TabIndex = 3;
            this.LbGuvenlikSorusu.Text = "Güvenlik sorusu gelecek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yeni Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yeni Şifre Tekrar:";
            // 
            // MtBSifre
            // 
            this.MtBSifre.Location = new System.Drawing.Point(132, 112);
            this.MtBSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MtBSifre.Name = "MtBSifre";
            this.MtBSifre.Size = new System.Drawing.Size(122, 20);
            this.MtBSifre.TabIndex = 6;
            // 
            // MtBSifreTekrar
            // 
            this.MtBSifreTekrar.Location = new System.Drawing.Point(132, 153);
            this.MtBSifreTekrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MtBSifreTekrar.Name = "MtBSifreTekrar";
            this.MtBSifreTekrar.Size = new System.Drawing.Size(122, 20);
            this.MtBSifreTekrar.TabIndex = 7;
            // 
            // BtnSiteyeGiris
            // 
            this.BtnSiteyeGiris.Location = new System.Drawing.Point(82, 186);
            this.BtnSiteyeGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSiteyeGiris.Name = "BtnSiteyeGiris";
            this.BtnSiteyeGiris.Size = new System.Drawing.Size(152, 47);
            this.BtnSiteyeGiris.TabIndex = 8;
            this.BtnSiteyeGiris.Text = "Giriş";
            this.BtnSiteyeGiris.UseVisualStyleBackColor = true;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 273);
            this.Controls.Add(this.BtnSiteyeGiris);
            this.Controls.Add(this.MtBSifreTekrar);
            this.Controls.Add(this.MtBSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbGuvenlikSorusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbKullanıcıAdi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SifremiUnuttum";
            this.Text = "Sifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbKullanıcıAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbGuvenlikSorusu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MtBSifre;
        private System.Windows.Forms.MaskedTextBox MtBSifreTekrar;
        private System.Windows.Forms.Button BtnSiteyeGiris;
    }
}