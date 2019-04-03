using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmClassLib.Enums;
using FilmClassLib.Interfaces;

namespace FilmClassLib.Classes
{
     public class Email: DbObject
    {
        public Email(string name, string provider)
        {
            Name = name;
            Provider = provider;
        }
        public string Name { get; set; }
        public string Provider { get; set; }
      
    }
}
