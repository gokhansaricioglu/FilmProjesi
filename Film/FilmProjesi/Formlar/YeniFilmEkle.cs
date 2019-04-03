using FilmClassLib.Classes;
using FilmClassLib.Enums;
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
    public partial class YeniFilmEkle : Form
    {
        public YeniFilmEkle()
        {
            InitializeComponent();
            CbFilmTuru.DataSource = Enum.GetNames(typeof(FilmTuru));
            CbMensei.DataSource = Enum.GetNames(typeof(Mensei));
        }

        private void FilmBilgisi_Load(object sender, EventArgs e)
        {

        }

        private void BtnFilmEkle_Click(object sender, EventArgs e)
        {
            string filmAdi = TbAdi.Text;
            int süre = Convert.ToInt32(TbSure.Text);
            DateTime cikisTarihi = DtpCıkısTarih.Value;
            Cast yonetmen = (Cast)CbYonetmen.SelectedItem;
            FilmTuru filmTurü = (FilmTuru)CbFilmTuru.SelectedItem;
            Mensei mensei = (Mensei)CbMensei.SelectedItem;
            double satisFiyat = Convert.ToDouble(TbSatisFiyati.Text);
            double kiralamaFiyat = Convert.ToDouble(TbKiralamaFiyatı.Text);
            FilmBilgisi yeniFilim = new FilmBilgisi(filmAdi, süre, cikisTarihi, yonetmen, mensei, satisFiyat, kiralamaFiyat, new FilmURL());
            yeniFilim.FilmTurleri.Add(filmTurü);
            FakeDatabase.FilmBilgileri.Add(yeniFilim);

        }
    }
}
