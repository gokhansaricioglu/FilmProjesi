namespace FilmProjesi.Formlar
{
    partial class BenimSayfam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenimSayfam));
            this.LbFilmlerim = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIzle = new System.Windows.Forms.Button();
            this.WmpFilm = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnFilmAl = new System.Windows.Forms.Button();
            this.BtnBegendim = new System.Windows.Forms.Button();
            this.BtnBegenmedim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WmpFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // LbFilmlerim
            // 
            this.LbFilmlerim.FormattingEnabled = true;
            this.LbFilmlerim.ItemHeight = 16;
            this.LbFilmlerim.Location = new System.Drawing.Point(17, 38);
            this.LbFilmlerim.Margin = new System.Windows.Forms.Padding(4);
            this.LbFilmlerim.Name = "LbFilmlerim";
            this.LbFilmlerim.Size = new System.Drawing.Size(184, 388);
            this.LbFilmlerim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filmlerim";
            // 
            // BtnIzle
            // 
            this.BtnIzle.Location = new System.Drawing.Point(21, 434);
            this.BtnIzle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIzle.Name = "BtnIzle";
            this.BtnIzle.Size = new System.Drawing.Size(181, 28);
            this.BtnIzle.TabIndex = 2;
            this.BtnIzle.Text = "İzle";
            this.BtnIzle.UseVisualStyleBackColor = true;
            // 
            // WmpFilm
            // 
            this.WmpFilm.Enabled = true;
            this.WmpFilm.Location = new System.Drawing.Point(257, 38);
            this.WmpFilm.Margin = new System.Windows.Forms.Padding(4);
            this.WmpFilm.Name = "WmpFilm";
            this.WmpFilm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WmpFilm.OcxState")));
            this.WmpFilm.Size = new System.Drawing.Size(616, 316);
            this.WmpFilm.TabIndex = 3;
            // 
            // BtnFilmAl
            // 
            this.BtnFilmAl.Location = new System.Drawing.Point(869, 2);
            this.BtnFilmAl.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFilmAl.Name = "BtnFilmAl";
            this.BtnFilmAl.Size = new System.Drawing.Size(181, 28);
            this.BtnFilmAl.TabIndex = 2;
            this.BtnFilmAl.Text = "Film Satın Al";
            this.BtnFilmAl.UseVisualStyleBackColor = true;
            this.BtnFilmAl.Click += new System.EventHandler(this.BtnFilmAl_Click);
            // 
            // BtnBegendim
            // 
            this.BtnBegendim.Location = new System.Drawing.Point(812, 434);
            this.BtnBegendim.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBegendim.Name = "BtnBegendim";
            this.BtnBegendim.Size = new System.Drawing.Size(113, 28);
            this.BtnBegendim.TabIndex = 4;
            this.BtnBegendim.Text = "Begendim";
            this.BtnBegendim.UseVisualStyleBackColor = true;
            // 
            // BtnBegenmedim
            // 
            this.BtnBegenmedim.Location = new System.Drawing.Point(933, 434);
            this.BtnBegenmedim.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBegenmedim.Name = "BtnBegenmedim";
            this.BtnBegenmedim.Size = new System.Drawing.Size(117, 28);
            this.BtnBegenmedim.TabIndex = 4;
            this.BtnBegenmedim.Text = "Begenmedim";
            this.BtnBegenmedim.UseVisualStyleBackColor = true;
            // 
            // BenimSayfam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 497);
            this.Controls.Add(this.BtnBegenmedim);
            this.Controls.Add(this.BtnBegendim);
            this.Controls.Add(this.WmpFilm);
            this.Controls.Add(this.BtnFilmAl);
            this.Controls.Add(this.BtnIzle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbFilmlerim);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BenimSayfam";
            this.Text = "BenimSayfam";
            ((System.ComponentModel.ISupportInitialize)(this.WmpFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbFilmlerim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIzle;
        private AxWMPLib.AxWindowsMediaPlayer WmpFilm;
        private System.Windows.Forms.Button BtnFilmAl;
        private System.Windows.Forms.Button BtnBegendim;
        private System.Windows.Forms.Button BtnBegenmedim;
    }
}