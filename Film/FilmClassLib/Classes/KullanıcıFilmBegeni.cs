using FilmClassLib.Enums;
using FilmClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Classes
{
    public class KullanıcıFilmBegeni : DbObject
    {
        public KullanıcıFilmBegeni(Kullanıcı kullanıcı, FilmBilgisi filmBigisi, OyTuru oyTuru)
        {
            Kullanıcı = kullanıcı;
            FilmBigisi = filmBigisi;
            OyTuru = oyTuru;
    
        }

        public Kullanıcı Kullanıcı { get; set; }
        public FilmBilgisi FilmBigisi { get; set; }
        public OyTuru OyTuru { get; set; }
    }
}
