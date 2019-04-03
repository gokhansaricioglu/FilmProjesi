using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmClassLib.Interfaces;

namespace FilmClassLib.Classes
{
    [Obsolete]
    public class Bolum: DbObject
    {
        public string Ad{ get; set; }
        public string Url { get; set; }
        public Int16 Sure { get; set; }
        public Int16 SezonNo { get; set; }
        public Int16 BolumNo { get; set; }        
    }
}
