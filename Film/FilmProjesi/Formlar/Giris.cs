using FilmClassLib.Classes;
using FilmProjesi.Formlar;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Giris
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            FakeDatabase.FakeDataOlustur();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static Kullanıcı GirisYapanKullanici;
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            string ka = TbKullaniciAdi.Text;
            string sifre = TbSifre.Text;
            if (ValidationCheck.TextBosMu(ka) == true)
            {
                MessageBox.Show("Kullanıcı adi boş olamaz");
            }
            else if (ValidationCheck.TextBosMu(sifre) == true)
            {
                MessageBox.Show("Şifre boş olamaz");
            }
            else if (ValidationCheck.SifreGecerliMi(sifre) == false)
            {
                MessageBox.Show("Şifre Altı haneden küçük olamaz");
            }
            else if (FakeDatabase.Kullanicilar.Exists(x => x.Sifre == sifre && x.KullaniciAdi == ka) == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre geçersiz");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
                 GirisYapanKullanici = FakeDatabase.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == ka);
                if (GirisYapanKullanici.KullanıcıTuru == FilmClassLib.Enums.KullanıcıTuru.Admin)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                else
                {
                    BenimSayfam benimSayfam = new BenimSayfam();
                    benimSayfam.Show();
                    this.Hide();
                }
            }
        }

        private void LinklLblSfremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifremiUnuttum = new SifremiUnuttum();
            sifremiUnuttum.ShowDialog();
            
        }

        private void LinkLblKAyitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.ShowDialog();
            
        }
    }
}
