using FilmClassLib.Enums;
using FilmClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Classes
{

    public class FilmBilgisi : DbObject
    {
        public FilmBilgisi()
        {
            FilmTurleri = new List<FilmTuru>();
            FilmPuani = new Puan();
            Yorums = new List<Yorum>();
        }
        public FilmBilgisi(string filmAd, int filmSuresi, DateTime cikisTarihi,
            Cast yonetmen, Mensei mensei, double satisFiyati, double kiralamaFiyati, FilmURL filmBilgisi)
        {
            FilmAd = filmAd;
            FilmSuresi = filmSuresi;
            CikisTarihi = cikisTarihi;
            Yonetmen = yonetmen;
            Mensei = mensei;
            SatisFiyati = satisFiyati;
            KiralamaFiyati = kiralamaFiyati;
            FilmPuani = new Puan();
            FilmUrl = filmBilgisi;
            FilmTurleri = new List<FilmTuru>();
            Yorums = new List<Yorum>();
        }

        public string FilmAd { get; set; }
        public int FilmSuresi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public Cast Yonetmen { get; set; }
        public Mensei Mensei { get; set; }
        public double SatisFiyati { get; set; }
        public double KiralamaFiyati { get; set; }
        public Puan FilmPuani { get; set; }
        public FilmURL FilmUrl{ get; set; }
        public List<FilmTuru> FilmTurleri { get; set; }
        public List<Yorum> Yorums { get; set; }
        public override string ToString()
        {
            return FilmAd + ":" + SatisFiyati;
        }

    }
}
