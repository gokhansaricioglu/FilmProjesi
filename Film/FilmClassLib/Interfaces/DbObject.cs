using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FilmClassLib.Interfaces
{
    public abstract class DbObject
    {
        public string Id { get; set; }
        public string OlusturanKisi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime Guncellemetarihi { get; set; }
        public string GuncelleyenKisi { get; set; }
        public bool GecerliMi { get; set; }
        public DbObject()
        {
            Id = Guid.NewGuid().ToString();
            OlusturmaTarihi = DateTime.Now;
            GecerliMi = true;
        }
      
        public override string ToString()
        {
            var currentType = typeof(DbObject);
            PropertyInfo[] currentProperties = currentType.GetProperties();
            string returnString = string.Empty;
            foreach (PropertyInfo property in currentProperties)
            {
                returnString += property.Name + " " + property.GetValue(this) + Environment.NewLine;
            }
            return returnString;
        }
    }
}
