namespace FilmProjesi.Formlar
{
    partial class Yorum
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
            this.FlwYorumlar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlwYorumlar
            // 
            this.FlwYorumlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwYorumlar.Location = new System.Drawing.Point(0, 0);
            this.FlwYorumlar.Name = "FlwYorumlar";
            this.FlwYorumlar.Size = new System.Drawing.Size(371, 450);
            this.FlwYorumlar.TabIndex = 0;
            this.FlwYorumlar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Yorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.FlwYorumlar);
            this.Name = "Yorum";
            this.Text = "Yorum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlwYorumlar;
    }
}