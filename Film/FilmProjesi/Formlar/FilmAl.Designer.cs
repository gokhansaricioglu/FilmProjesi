namespace FilmProjesi.Formlar
{
    partial class FilmAl
    { /// <summary>
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
            this.LbFilmler = new System.Windows.Forms.ListBox();
            this.BtnYorumlarıGör = new System.Windows.Forms.Button();
            this.BtnSatinAl = new System.Windows.Forms.Button();
            this.CbFilmTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbFilmAra = new System.Windows.Forms.TextBox();
            this.BtnSepeteEkle = new System.Windows.Forms.Button();
            this.LblSepet = new System.Windows.Forms.Label();
            this.BtnSepeteGit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbFilmler
            // 
            this.LbFilmler.FormattingEnabled = true;
            this.LbFilmler.ItemHeight = 16;
            this.LbFilmler.Location = new System.Drawing.Point(15, 95);
            this.LbFilmler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LbFilmler.Name = "LbFilmler";
            this.LbFilmler.Size = new System.Drawing.Size(769, 356);
            this.LbFilmler.TabIndex = 4;
            // 
            // BtnYorumlarıGör
            // 
            this.BtnYorumlarıGör.Location = new System.Drawing.Point(437, 14);
            this.BtnYorumlarıGör.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnYorumlarıGör.Name = "BtnYorumlarıGör";
            this.BtnYorumlarıGör.Size = new System.Drawing.Size(165, 68);
            this.BtnYorumlarıGör.TabIndex = 5;
            this.BtnYorumlarıGör.Text = "Yorumları Gör";
            this.BtnYorumlarıGör.UseVisualStyleBackColor = true;
            this.BtnYorumlarıGör.Click += new System.EventHandler(this.BtnYorumlarıGör_Click);
            // 
            // BtnSatinAl
            // 
            this.BtnSatinAl.Location = new System.Drawing.Point(659, 470);
            this.BtnSatinAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSatinAl.Name = "BtnSatinAl";
            this.BtnSatinAl.Size = new System.Drawing.Size(127, 44);
            this.BtnSatinAl.TabIndex = 6;
            this.BtnSatinAl.Text = "Satın Al";
            this.BtnSatinAl.UseVisualStyleBackColor = true;
            this.BtnSatinAl.Click += new System.EventHandler(this.BtnSatinAl_Click);
            // 
            // CbFilmTuru
            // 
            this.CbFilmTuru.FormattingEnabled = true;
            this.CbFilmTuru.Location = new System.Drawing.Point(175, 18);
            this.CbFilmTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbFilmTuru.Name = "CbFilmTuru";
            this.CbFilmTuru.Size = new System.Drawing.Size(256, 24);
            this.CbFilmTuru.TabIndex = 3;
            this.CbFilmTuru.SelectedIndexChanged += new System.EventHandler(this.CbFilmTuru_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Türleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film ya da Oyuncu Ara";
            // 
            // TbFilmAra
            // 
            this.TbFilmAra.Location = new System.Drawing.Point(175, 57);
            this.TbFilmAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbFilmAra.Name = "TbFilmAra";
            this.TbFilmAra.Size = new System.Drawing.Size(256, 22);
            this.TbFilmAra.TabIndex = 0;
            this.TbFilmAra.TextChanged += new System.EventHandler(this.TbFilmAra_TextChanged);
            // 
            // BtnSepeteEkle
            // 
            this.BtnSepeteEkle.Location = new System.Drawing.Point(512, 470);
            this.BtnSepeteEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSepeteEkle.Name = "BtnSepeteEkle";
            this.BtnSepeteEkle.Size = new System.Drawing.Size(139, 44);
            this.BtnSepeteEkle.TabIndex = 7;
            this.BtnSepeteEkle.Text = "Sepete Ekle";
            this.BtnSepeteEkle.UseVisualStyleBackColor = true;
            this.BtnSepeteEkle.Click += new System.EventHandler(this.BtnSepeteEkle_Click);
            // 
            // LblSepet
            // 
            this.LblSepet.AutoSize = true;
            this.LblSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSepet.Location = new System.Drawing.Point(625, 37);
            this.LblSepet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSepet.Name = "LblSepet";
            this.LblSepet.Size = new System.Drawing.Size(152, 20);
            this.LblSepet.TabIndex = 8;
            this.LblSepet.Text = "Sepette 0 Ürün Var";
            // 
            // BtnSepeteGit
            // 
            this.BtnSepeteGit.Location = new System.Drawing.Point(347, 472);
            this.BtnSepeteGit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSepeteGit.Name = "BtnSepeteGit";
            this.BtnSepeteGit.Size = new System.Drawing.Size(139, 44);
            this.BtnSepeteGit.TabIndex = 9;
            this.BtnSepeteGit.Text = "Sepete Git";
            this.BtnSepeteGit.UseVisualStyleBackColor = true;
            this.BtnSepeteGit.Click += new System.EventHandler(this.BtnSepeteGit_Click);
            // 
            // FilmAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 529);
            this.Controls.Add(this.BtnSepeteGit);
            this.Controls.Add(this.LblSepet);
            this.Controls.Add(this.BtnSepeteEkle);
            this.Controls.Add(this.BtnSatinAl);
            this.Controls.Add(this.BtnYorumlarıGör);
            this.Controls.Add(this.LbFilmler);
            this.Controls.Add(this.CbFilmTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbFilmAra);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilmAl";
            this.Text = "Film Al";
            this.Load += new System.EventHandler(this.FilmAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LbFilmler;
        private System.Windows.Forms.Button BtnYorumlarıGör;
        private System.Windows.Forms.Button BtnSatinAl;
        private System.Windows.Forms.ComboBox CbFilmTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbFilmAra;
        private System.Windows.Forms.Button BtnSepeteEkle;
        private System.Windows.Forms.Label LblSepet;
        private System.Windows.Forms.Button BtnSepeteGit;
    }
}