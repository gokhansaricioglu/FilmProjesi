using FilmClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilmClassLib.Classes
{
    [Obsolete]
    public class Dizi : FilmBilgisi
    {
        public Dizi()
        {
            SezonBilgisi = new List<SezonBilgisi>();
            Bolum = new List<Bolum>();
        }
        public List<SezonBilgisi> SezonBilgisi {get;set;} 
        public List<Bolum> Bolum { get; set; }
    }
}
