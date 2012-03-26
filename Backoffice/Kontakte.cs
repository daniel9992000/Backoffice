using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    class Kontakte
    {
        int kontaktid;
        string vorname;
        string nachname;
        string firmenname;
        ObjectStates status;

        public Kontakte()
        {
        }

        public Kontakte(int kontaktid, string vorname, string nachname, string firmenname, ObjectStates status)
        {
            this.kontaktid = kontaktid;
            this.vorname = vorname;
            this.nachname = nachname;
            this.firmenname = firmenname;
            this.status = status;
        }

        #region Properties
        public int Kontaktid
        {
            get { return kontaktid; }
            set { kontaktid = value; }
        }
        
        public string Firmenname
        {
            get { return firmenname; }
            set
            {
                if (firmenname != value)
                {
                    firmenname = value;
                    status = ObjectStates.Modified;
                }
            }
        }
     

        public string Vorname
        {
            get { return vorname; }
            set {
                    if (vorname != value)
                    {
                        vorname = value;
                        status = ObjectStates.Modified;
                    }
                 }
        }
        
        public string Nachname
        {
            get { return nachname; }
            set
            {
                if (nachname != value)
                {
                    nachname = value;
                    status = ObjectStates.Modified;
                }
            }
        }
        #endregion 

    }
}
