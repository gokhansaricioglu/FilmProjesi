using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmClassLib.Interfaces;
using FilmClassLib.Enums;
namespace FilmClassLib.Classes
{
    public class FilmOyuncu:DbObject
    {
        public FilmOyuncu(FilmBilgisi filmBilgisi, Cast oyuncu, string filmdekiAdi, RolTipi rolTipi)
        {
            FilmBilgisi = filmBilgisi;
            Oyuncu = oyuncu;
            FilmdekiAdi = filmdekiAdi;
            RolTipi = rolTipi;
        }
        public FilmBilgisi FilmBilgisi { get; set; }
        public Cast Oyuncu { get; set; }
        public string FilmdekiAdi { get; set; }
        public RolTipi RolTipi { get; set; }
    }
}
