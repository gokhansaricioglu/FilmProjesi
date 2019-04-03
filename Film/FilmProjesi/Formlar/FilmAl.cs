using FilmClassLib.Classes;
using FilmClassLib.Enums;
using System;
using System.Collections.Concurrent;
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
    public partial class FilmAl : Form
    {
        public FilmAl()
        {
            InitializeComponent();
            CbFilmTuru.DataSource = Enum.GetNames(typeof(FilmTuru));

        }

        private void FilmAl_Load(object sender, EventArgs e)
        {
            LbFilmler.DataSource = FakeDatabase.FilmBilgileri;
        }

        private void BtnSatinAl_Click(object sender, EventArgs e)
        {
            FilmBilgisi currentFılm = (FilmBilgisi) LbFilmler.SelectedItem;
            Satis satis = new Satis(Giris.Giris.GirisYapanKullanici, currentFılm);
            FakeDatabase.Satislar.Add(satis);
            MessageBox.Show("Film satın alındı.");
        }

        private void TbFilmAra_TextChanged(object sender, EventArgs e)
        {
            foreach (var suankifilm in FakeDatabase.FilmBilgileri)
            {
                if (suankifilm.FilmAd.IndexOf(TbFilmAra.Text) != -1)
                {
                    LbFilmler.Items.Add(suankifilm);
                 }
            }
           
        }

        private void CbFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var suankifilm in FakeDatabase.FilmBilgileri)
            {
                if (suankifilm.FilmTurleri.Contains((FilmTuru)CbFilmTuru.SelectedIndex))
                {
                    LbFilmler.Items.Add(suankifilm);
                }
            }
        }
        public static ConcurrentDictionary<FilmBilgisi, int> FilmSepeti = new ConcurrentDictionary<FilmBilgisi, int>();

            
        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {
            FilmSepeti.AddOrUpdate((FilmBilgisi)LbFilmler.SelectedItem, 1,(key,value)=> { return value += 1; });
            int toplam =FilmSepeti.Values.Sum();
            LblSepet.Text = $"{toplam} ürün var";
        }

        private void BtnSepeteGit_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.ShowDialog();

        }
        public static FilmBilgisi seciliFilm = null;
        private void BtnYorumlarıGör_Click(object sender, EventArgs e)
        {
            seciliFilm= (FilmBilgisi)LbFilmler.SelectedItem;
            Yorum yorum = new Yorum();
            yorum.ShowDialog();
            
        }
    }
}
