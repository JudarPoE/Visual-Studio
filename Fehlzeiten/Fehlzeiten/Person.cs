using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeiten
{
    public class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Geburtsdatum { get; set; }

        public Person (string Name, string Vorname, DateTime Geburtsdatum)
        {
            this.Name = Name;
            this.Vorname = Vorname;
            this.Geburtsdatum = Geburtsdatum;
        }      
    }
}
