using FilmProjesi.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmProjesi.Formlar
{
    public partial class Yorum : Form
    {
        public Yorum()
        {
            InitializeComponent();
            foreach (var item in FilmAl.seciliFilm.Yorums)
            {
                YorumItem yorumItem = new YorumItem(item);
                FlwYorumlar.Controls.Add(yorumItem);

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
