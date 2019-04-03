using FilmClassLib.Interfaces;

namespace FilmClassLib.Classes
{
    public class Puan : DbObject
    {
        public int BegenenKisiSayisi { get; set; }
        public int BegenmeyenKisiSayisi { get; set; }
        public double OrtalamaPuan { get { return (BegenenKisiSayisi / (BegenenKisiSayisi + BegenmeyenKisiSayisi)) * 100; } }
    }
}