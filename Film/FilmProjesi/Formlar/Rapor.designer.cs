namespace Giris
{
    partial class Rapor
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
            this.TbBaslangicTarihi = new System.Windows.Forms.TextBox();
            this.TbBitisTarihi = new System.Windows.Forms.TextBox();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // TbBaslangicTarihi
            // 
            this.TbBaslangicTarihi.Location = new System.Drawing.Point(193, 52);
            this.TbBaslangicTarihi.Name = "TbBaslangicTarihi";
            this.TbBaslangicTarihi.Size = new System.Drawing.Size(100, 20);
            this.TbBaslangicTarihi.TabIndex = 2;
            // 
            // TbBitisTarihi
            // 
            this.TbBitisTarihi.Location = new System.Drawing.Point(193, 85);
            this.TbBitisTarihi.Name = "TbBitisTarihi";
            this.TbBitisTarihi.Size = new System.Drawing.Size(100, 20);
            this.TbBitisTarihi.TabIndex = 3;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(88, 143);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(75, 23);
            this.BtnHesapla.TabIndex = 4;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kazanç";
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.TbBitisTarihi);
            this.Controls.Add(this.TbBaslangicTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbBaslangicTarihi;
        private System.Windows.Forms.TextBox TbBitisTarihi;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label label3;
    }
}