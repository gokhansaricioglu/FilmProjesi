using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Classes
{
    public static class FakeDatabase
    {
        public static List<Kullanıcı> Kullanicilar = new List<Kullanıcı>();
        public static List<Satis> Satislar = new List<Satis>();
        public static List<FilmBilgisi> FilmBilgileri = new List<FilmBilgisi>();
        public static List<FilmOyuncu> FilmeOyunculari = new List<FilmOyuncu>();
        public static List<Cast> Castlar = new List<Cast>();

        public static void FakeDataOlustur()
        {
            var kullanici = new Kullanıcı("Mahmut", "Tuncer", Enums.Cinsiyet.Erkek, DateTime.Parse("02.03.1985"), "Halay", "mTuncer123", "5489634578", "mtuncer@hotmail.com", new SifreGuncelle(Enums.GuvenlikSorusu.Lakab, "Halaycı Başı"), Enums.KullanıcıTuru.Normal);
            Kullanicilar.AddRange(new[] {
                kullanici,
                new Kullanıcı("Muhsin","Ağaçlı", Enums.Cinsiyet.Erkek, DateTime.Parse("1992-02-02"),"Mah","password","54685245790","magacli@mynet.com", new SifreGuncelle(Enums.GuvenlikSorusu.EnSevdiginizKitap,"Metro 2033"),Enums.KullanıcıTuru.Admin),
                new Kullanıcı("Demet","Gürsoy",Enums.Cinsiyet.Kadın,DateTime.Parse("1992-02-02"),"demet01","12345678","5325691483","gursoydmt@gmail.com", new SifreGuncelle(Enums.GuvenlikSorusu.Lakab,"Yollu"),Enums.KullanıcıTuru.Normal)
            });
            var cast = new Cast("Lucy", "Lu", Enums.Cinsiyet.Kadın, DateTime.Parse("1992-02-02"), "Futurama", Enums.Mensei.Çin);
            Castlar.AddRange(new[] {
                new Cast("Robert","Downey Jr.",Enums.Cinsiyet.Erkek,DateTime.Parse("1992-02-02"),"Iron Man",Enums.Mensei.Afganistan),
                new Cast("Bruce","Willis",Enums.Cinsiyet.Erkek, DateTime.Parse("1992-02-02"),"Bruce Willis ölüymüş", Enums.Mensei.Anguilla),
                cast
            });
            var filmBigisi = new FilmBilgisi("Revenge of the Cows", 125, DateTime.Parse("1992-02-02"), cast, Enums.Mensei.Çin, 50, 10, new FilmURL { Url = "Revenge of the Cows URL" });
            filmBigisi.Yorums.Add(new Yorum (kullanici,"Çok güzel film","efsane"));
            filmBigisi.Yorums.Add(new Yorum(kullanici, "İdare eder", "yanii"));
            filmBigisi.Yorums.Add(new Yorum(kullanici, "İzlemeye değmez", "Zaman kaybı"));
            FilmBilgileri.AddRange(new[] {
                filmBigisi,
                new FilmBilgisi("Revenge of the Cows 2", 125, DateTime.Parse("1992-02-02"),cast,Enums.Mensei.Çin,120,50,new FilmURL{ Url = "Revenge of the Cows 2 URL"}),
            });
            Satislar.AddRange(new[] {
                new Satis(kullanici,filmBigisi)
            });
            FilmeOyunculari.AddRange(new[]
            {
                new FilmOyuncu(filmBigisi,cast,"Natasha",Enums.RolTipi.YardımcıKadın)
            });
         }
    }
}
