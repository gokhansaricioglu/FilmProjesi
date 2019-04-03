using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Classes
{
    public class KrediKartBilgisi
    {
        public KrediKartBilgisi(string kartSahibiAdi, string kartNumarası, int gecerlilikYili, int gecerlilikAyi, int guvenlikKodu)
        {
            KartSahibiAdi = kartSahibiAdi;
            KartNumarası = kartNumarası;
            GecerlilikYili = gecerlilikYili;
            GecerlilikAyi = gecerlilikAyi;
            GuvenlikKodu = guvenlikKodu;
        }

        public string  KartSahibiAdi { get; set; }
        public string KartNumarası { get; set; }
        public int GecerlilikYili { get; set; }
        public int GecerlilikAyi { get; set; }
        public int GuvenlikKodu { get; set; }
    }
}
