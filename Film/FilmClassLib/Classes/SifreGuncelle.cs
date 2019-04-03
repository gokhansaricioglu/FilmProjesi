using FilmClassLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmClassLib.Interfaces;

namespace FilmClassLib.Classes
{
    public class SifreGuncelle : DbObject
    {
        public SifreGuncelle(GuvenlikSorusu guvenlikSorusu, string guvenlikSorusuCevabi)
        {
            GuvenlikSorusu = guvenlikSorusu;
            GuvenlikSorusuCevabi = guvenlikSorusuCevabi;
        }

        public GuvenlikSorusu GuvenlikSorusu { get; set; }
        public string GuvenlikSorusuCevabi { get; set; }

    }
}
