using FilmClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Classes
{
    public class Satis : DbObject
    {
        public Satis(Kullanıcı alanKullanıcı, FilmBilgisi filmAdi)
        {
            AlanKullanıcı = alanKullanıcı;
            FilmAdi = filmAdi;
        }
        public Satis()
        {

        }
        public Kullanıcı AlanKullanıcı { get; set; }
        public FilmBilgisi FilmAdi { get; set; }

    }
}
