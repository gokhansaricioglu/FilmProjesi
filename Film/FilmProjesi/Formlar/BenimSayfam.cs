using FilmClassLib.Classes;
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
    public partial class BenimSayfam : Form
    {
        public BenimSayfam()
        {
            InitializeComponent();
            
            foreach (var item in FakeDatabase.Satislar)
            {
                if (item.AlanKullanıcı==Giris.Giris.GirisYapanKullanici)
                {
                    LbFilmlerim.Items.Add(item.FilmAdi);
                }
            }
        }

        private void BtnFilmAl_Click(object sender, EventArgs e)
        {
            FilmAl filmAl = new FilmAl();
            filmAl.Show();
            this.Hide();
        }
    }
}
