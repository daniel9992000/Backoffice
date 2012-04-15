using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Rechnungszeile
    {
        int reid;
        string bezeichnung;
        double betrag;
        int? angebotid;
        int? rechnungid;
        ObjectStates status;

        public Rechnungszeile()
        {
            this.reid = 0;
            this.bezeichnung = string.Empty;
            this.betrag = 0;
            this.angebotid = 0;
            this.rechnungid = 0;
        }

        public Rechnungszeile(int reid, string bezeichnung, double betrag, int angebotid, int rechnungid, ObjectStates status)
        {
            this.reid = reid;
            this.rechnungid = rechnungid;
            this.betrag = betrag;
            this.bezeichnung = bezeichnung;
            this.angebotid = angebotid;
            this.status = status;
        }

        #region Properties
        public int Reid
        {
            get { return reid; }
            set 
            { 
                if (reid != value) 
                { 
                    reid = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set
            {
                if (!bezeichnung.Equals(value))
                {
                    bezeichnung = value;
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

        public int? Angebotid
        {
            get { return angebotid; }
            set
            {
                if (angebotid != value)
                {
                    angebotid = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int? Rechnungid
        {
            get { return rechnungid; }
            set
            {
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
