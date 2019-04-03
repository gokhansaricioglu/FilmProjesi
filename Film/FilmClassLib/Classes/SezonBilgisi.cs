using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmClassLib.Interfaces;

namespace FilmClassLib.Classes
{
    [Obsolete]
    public class SezonBilgisi:DbObject
    {
        public SezonBilgisi(short sezonNo, short bolumNo)
        {
            SezonNo = sezonNo;
            BolumNo = bolumNo;
        }

        public Int16 SezonNo { get; set; }
        public Int16 BolumNo { get; set; }
    }
}
