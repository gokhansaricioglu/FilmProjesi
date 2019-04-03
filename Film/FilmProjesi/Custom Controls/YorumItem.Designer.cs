namespace FilmProjesi.Custom_Controls
{
    partial class YorumItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblYorumMetni = new System.Windows.Forms.Label();
            this.LblYorumTarih = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(4, 14);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(180, 17);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Buraya UserName Gelecek";
            // 
            // LblYorumMetni
            // 
            this.LblYorumMetni.Location = new System.Drawing.Point(4, 49);
            this.LblYorumMetni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblYorumMetni.Name = "LblYorumMetni";
            this.LblYorumMetni.Size = new System.Drawing.Size(477, 133);
            this.LblYorumMetni.TabIndex = 0;
            this.LblYorumMetni.Text = "Yorum Text Buraya Gelecek";
            // 
            // LblYorumTarih
            // 
            this.LblYorumTarih.AutoSize = true;
            this.LblYorumTarih.Location = new System.Drawing.Point(333, 14);
            this.LblYorumTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblYorumTarih.Name = "LblYorumTarih";
            this.LblYorumTarih.Size = new System.Drawing.Size(147, 17);
            this.LblYorumTarih.TabIndex = 0;
            this.LblYorumTarih.Text = "Buraha Tarih Gelecek";
            // 
            // Yorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblYorumTarih);
            this.Controls.Add(this.LblYorumMetni);
            this.Controls.Add(this.LblUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Yorum";
            this.Size = new System.Drawing.Size(499, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblYorumMetni;
        private System.Windows.Forms.Label LblYorumTarih;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
