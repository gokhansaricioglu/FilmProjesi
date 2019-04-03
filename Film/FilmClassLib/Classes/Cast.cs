    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmClassLib.Interfaces;
using FilmClassLib.Enums;

namespace FilmClassLib.Classes
{
    public class Cast : DbObject
    {
        public Cast(string adi, string soyAdi, Cinsiyet cinsiyet, DateTime dogumTarihi, string ozGecmis, Mensei uyruk)
        {
            Adi = adi;
            SoyAdi = soyAdi;
            Cinsiyet = cinsiyet;
            DogumTarihi = dogumTarihi;
            OzGecmis = ozGecmis;
            Uyruk = uyruk;
        }

        public string Adi{get; set;}
        public string SoyAdi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string OzGecmis { get; set; }
        public Mensei Uyruk { get; set; }
    }
}
