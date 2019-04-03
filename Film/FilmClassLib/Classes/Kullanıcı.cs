using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmClassLib.Enums;
using FilmClassLib.Interfaces;

namespace FilmClassLib.Classes
{
    public class Kullanıcı:DbObject
    {
        public Kullanıcı(string adi, string soyadi, Cinsiyet cinsiyet, DateTime dogumTarihi,
            string kullaniciAdi, string sifre, string telNo, string email, SifreGuncelle sifreGuncelle,KullanıcıTuru kullanıcıTuru)
        {
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
            DogumTarihi = dogumTarihi;
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            TelNo = telNo;
            Email = email;
            SifreGuncelle = sifreGuncelle;
            KullanıcıTuru = kullanıcıTuru;
        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public SifreGuncelle SifreGuncelle { get; set; }
        public KullanıcıTuru KullanıcıTuru { get; set; }
    }
}
