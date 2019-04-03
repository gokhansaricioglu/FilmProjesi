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
    public partial class CastEkle : Form
    {
        public CastEkle()
        {
            InitializeComponent();
            CbUyruk.DataSource = Enum.GetNames(typeof(Mensei));
        }

        private void CastEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string adi = TbAd.Text;
            string soyadi = TbSoyad.Text;
            DateTime dogumTarihi = DtpDogumTarihi.Value;
            string hayati = TbHayat.Text;
            if (ValidationCheck.TextBosMu(adi) == true)
            {
                MessageBox.Show("Adı boş olmaz.");
            }
            else if (ValidationCheck.TextBosMu(soyadi) == true)
            {
                MessageBox.Show("Soyadı boş olamaz.");
            }
            else if (ValidationCheck.TextBosMu(hayati))
            {
                MessageBox.Show("Uyruğu boş olamaz.");
            }
            else if (ValidationCheck.DoğumTarihiGelecekteMi(dogumTarihi) == false)
            {
                MessageBox.Show("Doğum tarihi gelecekte bir gün olamaz.");
            }
            else
            {
                Mensei mensei = (Mensei)CbUyruk.SelectedIndex;
                Cinsiyet seciliCinsiyet;
                if (BtnErkek.Checked == true)
                {
                    seciliCinsiyet = Cinsiyet.Erkek;
                }
                else
                {
                    seciliCinsiyet = Cinsiyet.Kadın;
                }
                Cast cast = new Cast(adi, soyadi, seciliCinsiyet, dogumTarihi, hayati, mensei);
                MessageBox.Show("Yeni cast eklendi.");

                FakeDatabase.Castlar.Add(cast);
            }
        }
    }
}
