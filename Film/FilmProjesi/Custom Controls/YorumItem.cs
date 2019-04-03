using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmClassLib.Classes;

namespace FilmProjesi.Custom_Controls
{
    public partial class YorumItem : UserControl
    {
        public YorumItem(Yorum yorum)
        {
            InitializeComponent();
            LblUserName.Text = yorum.YorumuYapanKisi.KullaniciAdi;
            LblYorumTarih.Text = yorum.OlusturmaTarihi.ToString();
            LblYorumMetni.Text= yorum.Baslik+" " + yorum.Metin;
            

        }
    }
}
