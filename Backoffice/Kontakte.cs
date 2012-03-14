using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    class Kontakte
    {
        int kontaktid;

        public int Kontaktid
        {
            get { return kontaktid; }
            set { kontaktid = value; }
        }
        string firmenname;

        public string Firmenname
        {
            get { return firmenname; }
            set { firmenname = value; }
        }
        string vorname;

        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }
        string nachname;

        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

    }
}
