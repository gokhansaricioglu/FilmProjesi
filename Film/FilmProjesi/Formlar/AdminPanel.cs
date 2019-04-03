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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void BtnFilmİsleri_Click(object sender, EventArgs e)
        {
            YeniFilmEkle yeniFilmEkle = new YeniFilmEkle();
            yeniFilmEkle.ShowDialog();
        }
    }
}
