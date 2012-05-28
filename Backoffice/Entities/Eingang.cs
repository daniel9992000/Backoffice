using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Eingang : Rechnung
    {
        string path;
        int kontaktid;
        double betrag;

        public Eingang()
            : base()
        {
            this.path = string.Empty;
        }

        public Eingang(int rechnungid, string bezeichnung, DateTime datum, double betrag, string path, int kontaktid, ObjectStates status)
        {
            this.rechnungid = rechnungid;
            this.bezeichnung = bezeichnung;
            this.datum = datum;
            this.betrag = betrag;
            this.path = path;
            this.kontaktid = kontaktid;
            this.status = status;
        }

        public string Path
        {
            get { return path; }
            set
            {
                if (!path.Equals(value))
                {
                    path = value;
                    status = ObjectStates.Modified;
                }
            
            }
        }

        public double Betrag
        {
            get { return betrag; }
            set
            {
                if (betrag != value)
                {
                    betrag = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int Kontaktid
        {
            get { return kontaktid; }
            set
            {
                if (kontaktid != value)
                {
                    kontaktid = value;
                    status = ObjectStates.Modified;
                }
            }
        }
    }
}
