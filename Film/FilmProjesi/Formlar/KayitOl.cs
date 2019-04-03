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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
            CbGuvrnlikSorusu.DataSource = Enum.GetNames(typeof(GuvenlikSorusu));
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            string adi = TbAdi.Text;
            string soyadi = TbSoyad.Text;
            DateTime dogumtatihi = DtpDate.Value;
            string kullaniciadi = TbKullaniciAdi.Text;
            string sifre = TbSifre.Text;
            string sifretekrar = TbSifreTekrar.Text;
            string telno = TbTelNo.Text;
            string mail = TbMail.Text;
            GuvenlikSorusu guvenliksorosu = (GuvenlikSorusu)CbGuvrnlikSorusu.SelectedIndex ;
            string guvenliksorusucevabi = TbGuvrnlikSorusuCevap.Text;

            if (ValidationCheck.TextBosMu(adi) == true)
            {
                MessageBox.Show("Adi boş olamaz");
            }
            else if (ValidationCheck.TextBosMu(soyadi) == true)
            {
                MessageBox.Show("Soyadi boş olamaz");
            }
            else if (ValidationCheck.DoğumTarihiGecerliMi(dogumtatihi) == false)
            {

                MessageBox.Show("Dogum Tarihi Gelecekte Olamaz");
            }
            else if (ValidationCheck.TextBosMu(kullaniciadi) == true)
            {
                MessageBox.Show("Kullanıcı Adi Boş Bırakılamaz");
            }

            else if (ValidationCheck.TextBosMu(sifre) == true)
            {
                MessageBox.Show("Şifre Altı haneden küçük olamaz");
            }
            else if (ValidationCheck.TextBosMu(sifretekrar) == true)
            {
                MessageBox.Show("Şifre Tekrar Boş Olamaz");
            }
            else if (ValidationCheck.TextBosMu(telno) == true)
            {
                MessageBox.Show("Telefon Boş Olamaz");
            }
            else if (ValidationCheck.TextBosMu(mail) == true)
            {
                MessageBox.Show("Mail Boş Birakilamaz");

            }
            else if(ValidationCheck.SifreTekrarGecerliMi(TbSifreTekrar.Text,sifre) == false)
            {
                MessageBox.Show("Şifreler aynı olmalıdır");
            }
            else if (FakeDatabase.Kullanicilar.Exists
                (x => x.Sifre == sifre && x.KullaniciAdi == TbKullaniciAdi.Text) == true)
            {
                MessageBox.Show("Kullanıcı adı veya şifre geçersiz");
            }
            else
            {
                Cinsiyet cinsiyet;
                if (RbKadin.Checked == true)
                {
                    cinsiyet = Cinsiyet.Kadın;
                }
                else 
                {
                    cinsiyet = Cinsiyet.Erkek;
                }

                Kullanıcı kullanıcı = new Kullanıcı(adi, soyadi, cinsiyet, dogumtatihi, kullaniciadi, sifre, telno, mail, new SifreGuncelle(guvenliksorosu, guvenliksorusucevabi), KullanıcıTuru.Normal);
                FakeDatabase.Kullanicilar.Add(kullanıcı);
                MessageBox.Show("Kayıt olundu");
            }
        }
    }
}
