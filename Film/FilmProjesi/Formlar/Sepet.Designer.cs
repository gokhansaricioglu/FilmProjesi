namespace FilmProjesi.Formlar
{
    partial class Sepet
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
            this.LblSepet = new System.Windows.Forms.ListBox();
            this.BtnSatınAl = new System.Windows.Forms.Button();
            this.LblSepetBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSepet
            // 
            this.LblSepet.FormattingEnabled = true;
            this.LblSepet.ItemHeight = 16;
            this.LblSepet.Location = new System.Drawing.Point(16, 15);
            this.LblSepet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LblSepet.Name = "LblSepet";
            this.LblSepet.Size = new System.Drawing.Size(800, 260);
            this.LblSepet.TabIndex = 0;
            // 
            // BtnSatınAl
            // 
            this.BtnSatınAl.Location = new System.Drawing.Point(608, 331);
            this.BtnSatınAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSatınAl.Name = "BtnSatınAl";
            this.BtnSatınAl.Size = new System.Drawing.Size(175, 70);
            this.BtnSatınAl.TabIndex = 1;
            this.BtnSatınAl.Text = "Satın Al";
            this.BtnSatınAl.UseVisualStyleBackColor = true;
            this.BtnSatınAl.Click += new System.EventHandler(this.BtnSatınAl_Click);
            // 
            // LblSepetBilgi
            // 
            this.LblSepetBilgi.AutoSize = true;
            this.LblSepetBilgi.Location = new System.Drawing.Point(575, 294);
            this.LblSepetBilgi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSepetBilgi.Name = "LblSepetBilgi";
            this.LblSepetBilgi.Size = new System.Drawing.Size(239, 17);
            this.LblSepetBilgi.TabIndex = 2;
            this.LblSepetBilgi.Text = "Sepette X Ürün var Toplam Fiyat Y ₺";
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 425);
            this.Controls.Add(this.LblSepetBilgi);
            this.Controls.Add(this.BtnSatınAl);
            this.Controls.Add(this.LblSepet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LblSepet;
        private System.Windows.Forms.Button BtnSatınAl;
        private System.Windows.Forms.Label LblSepetBilgi;
    }
}