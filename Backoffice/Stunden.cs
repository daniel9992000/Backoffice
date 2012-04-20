using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Stunden
    {
        string projektname;
        string mitarbeiter;
        int stundenanz;
        DateTime datum;

        public Stunden()
        {

        }
        public Stunden(string projektname, string mitarbeiter, int stunden, DateTime datum)
        {
            this.projektname = projektname;
            this.mitarbeiter = mitarbeiter;
            this.stundenanz = stunden;
            this.datum = datum;
        }

        public string Projektname
        {
            get { return projektname; }
            set { projektname = value; }
        }

        public string Mitarbeiter
        {
            get { return mitarbeiter; }
            set { mitarbeiter = value; }
        }

        public int Stundenanz
        {
            get { return stundenanz; }
            set { stundenanz = value; }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
    }
}
