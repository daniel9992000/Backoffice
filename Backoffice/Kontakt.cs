using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Kontakt
    {
        int kontaktid;
        string vorname;
        string nachname;
        string firmenname;
        string adresse;
        string hausnummer;
        int plz;
        string email;
        string ort;
        decimal telefon;
        string bemerkungen;
        ObjectStates status;

      
        public Kontakt()
        {
        }

        public Kontakt(int kontaktid, string vorname, string nachname, string firmenname, string email, ObjectStates status)
        {
            this.kontaktid = kontaktid;
            this.vorname = vorname;
            this.nachname = nachname;
            this.firmenname = firmenname;
            this.email = email;
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
                    Status = ObjectStates.Modified;
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
                        Status = ObjectStates.Modified;
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
                    Status = ObjectStates.Modified;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Adresse
        {
            get { return adresse; }
            set
            {
                if (adresse != value)
                {
                    adresse = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Hausnummer
        {
            get { return hausnummer; }
            set
            {
                if (hausnummer != value)
                {
                    hausnummer = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int Plz
        {
            get { return plz; }
            set
            {
                if (plz != value)
                {
                    plz = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Ort
        {
            get { return ort; }
            set
            {
                if (ort != value)
                {
                    ort = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public decimal Telefon
        {
            get { return telefon; }
            set
            {
                if (telefon != value)
                {
                    telefon = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Bemerkungen
        {
            get { return bemerkungen; }
            set
            {
                if (bemerkungen != value)
                {
                    bemerkungen = value;
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
