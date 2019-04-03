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
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
            LblSepet.DataSource = FilmAl.FilmSepeti.Keys;
            int toplam = FilmAl.FilmSepeti.Values.Sum();
            double fiyatToplam = FilmAl.FilmSepeti.Sum(x => x.Key.SatisFiyati * x.Value);
            LblSepetBilgi.Text = $"Sepette {toplam} ürün var Fiyatı {fiyatToplam} ₺";
        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSatınAl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LblSepet.Items.Count; i++)
            {
                FilmBilgisi filmBigisi = (FilmBilgisi)LblSepet.Items[i];
                Satis satis = new Satis(Giris.Giris.GirisYapanKullanici, filmBigisi);
                FakeDatabase.Satislar.Add(satis);
            }
        }
    }
}
