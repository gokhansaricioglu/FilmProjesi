using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Enums
{
    public enum GuvenlikSorusu
    {
        [Description("En Sevdiğiniz Kitap ?")]
        EnSevdiginizKitap,
        [Description("Çocukluk yıllarınızdaki Lakabınız ?")]
        Lakab,
        [Description("En Sevdiğiniz Renk ?")]
        EnSevdiginizRenk
    }
}
