using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fehlzeiten
{
    public class Schüler : Person
    {

        public bool Buskarte { get; set; }
        public double Anfahrt { get; set; }
        public int Fehlstunden { get; set; }

        // Komposition: Schüler hat eine Liste von Fehlzeiten
        public List<Fehlzeiten> FehlzeitenListe { get; set; }

        public Schüler (string Name, string Vorname, DateTime Geburtsdatum, double Anfahrt, bool Buskarte) : base(Name, Vorname, Geburtsdatum)
        {
            this.Name = Name;
            this.Vorname = Vorname;
            this.Geburtsdatum = Geburtsdatum;
            this.Anfahrt = Anfahrt;
            this.Buskarte = Buskarte;
        }
       
    }
}
