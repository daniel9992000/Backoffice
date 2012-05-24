using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Buchung
    {
        int buchungid;
        double betrag;
        int kategorie;
        DateTime datum;
        int rechnungid;
        ObjectStates status;
        
        public Buchung()
        {
            this.buchungid = 0;
            this.betrag = 0;
            this.kategorie = 0;
            this.datum = DateTime.Today;
            this.rechnungid = 0;           
        }

        public Buchung(int buchungid, double betrag, int kategorie, DateTime datum, int rechnungid, ObjectStates status)
        {
            this.buchungid = buchungid;
            this.betrag = betrag;
            this.kategorie = kategorie;
            this.datum = datum;
            this.rechnungid = rechnungid;
            this.status = status;
        }

        #region Properties
        public int Buchungid
        {
            get { return buchungid; }
            set { buchungid = value; }
        }

        public double Betrag
        {
            get { return betrag; }
            set {
                if (betrag != value)
                {
                    betrag = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int Kategorie
        {
            get { return kategorie; }
            set
            {
                if (kategorie != value)
                {
                    kategorie = value;
                    Status = ObjectStates.Modified;
                }
            }
                
        }

        public DateTime Datum
        {
            get { return datum; }
            set {
                if (datum != value)
                {
                    datum = value;
                    status = ObjectStates.Modified;
                }
            }
        }
        public int Rechnungid
        {
            get { return rechnungid; }
            set {
                if (rechnungid != value)
                {
                    rechnungid = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public ObjectStates Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion
    }
}
