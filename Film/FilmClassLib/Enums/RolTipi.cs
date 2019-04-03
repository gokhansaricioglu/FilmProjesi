using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Enums
{
    public enum RolTipi
    {
        [Description("Başrol")]
        Basrol,
        [Description("Yardımcı Erkek Oyuncu")]
        YardımcıErkek,
        [Description("Yardımcı Kadın Oyuncu")]
        YardımcıKadın,
        [Description("Figuran Oyuncu")]
        Figuran
    }
}
