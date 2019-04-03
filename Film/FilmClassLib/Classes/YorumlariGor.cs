using FilmClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Classes
{
    public class Yorum: DbObject
    {
        public Yorum(Kullanıcı yorumuYapanKisi, string baslik, string metin)
        {
            YorumuYapanKisi = yorumuYapanKisi;
            Baslik = baslik;
            Metin = metin;
            Puan = new Puan();
        }

        public Kullanıcı YorumuYapanKisi { get; set; }
        public string Baslik { get; set; }
        public string Metin { get; set; }
        public Puan Puan { get; set; }
    }
}
