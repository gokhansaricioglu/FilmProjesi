namespace FilmProjesi.Formlar
{
    partial class AdminPanel
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
            this.BtnFilmİsleri = new System.Windows.Forms.Button();
            this.BtnDiziİSleri = new System.Windows.Forms.Button();
            this.BtnKullanıcıBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFilmİsleri
            // 
            this.BtnFilmİsleri.Location = new System.Drawing.Point(35, 29);
            this.BtnFilmİsleri.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFilmİsleri.Name = "BtnFilmİsleri";
            this.BtnFilmİsleri.Size = new System.Drawing.Size(149, 59);
            this.BtnFilmİsleri.TabIndex = 0;
            this.BtnFilmİsleri.Text = "Film İşlemleri";
            this.BtnFilmİsleri.UseVisualStyleBackColor = true;
            this.BtnFilmİsleri.Click += new System.EventHandler(this.BtnFilmİsleri_Click);
            // 
            // BtnDiziİSleri
            // 
            this.BtnDiziİSleri.Location = new System.Drawing.Point(35, 118);
            this.BtnDiziİSleri.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDiziİSleri.Name = "BtnDiziİSleri";
            this.BtnDiziİSleri.Size = new System.Drawing.Size(149, 59);
            this.BtnDiziİSleri.TabIndex = 1;
            this.BtnDiziİSleri.Text = "Dizi İşlemleri";
            this.BtnDiziİSleri.UseVisualStyleBackColor = true;
            // 
            // BtnKullanıcıBan
            // 
            this.BtnKullanıcıBan.Location = new System.Drawing.Point(35, 210);
            this.BtnKullanıcıBan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKullanıcıBan.Name = "BtnKullanıcıBan";
            this.BtnKullanıcıBan.Size = new System.Drawing.Size(149, 59);
            this.BtnKullanıcıBan.TabIndex = 2;
            this.BtnKullanıcıBan.Text = "Kullanıcı İşlemleri";
            this.BtnKullanıcıBan.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 293);
            this.Controls.Add(this.BtnKullanıcıBan);
            this.Controls.Add(this.BtnDiziİSleri);
            this.Controls.Add(this.BtnFilmİsleri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFilmİsleri;
        private System.Windows.Forms.Button BtnDiziİSleri;
        private System.Windows.Forms.Button BtnKullanıcıBan;
    }
}