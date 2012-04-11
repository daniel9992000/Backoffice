using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Kontakt
    {
        int kontaktid;
        string firmenname;
        string vorname;
        string nachname;
        string email;
        string adresse;
        string hausnummer;
        string plz;
        string ort;
        string telefon;
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
                if (!firmenname.Equals(value))
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
                    if (!vorname.Equals(value))
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
                if (nachname.Equals(value))
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
                if (!email.Equals(value))
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
                if (!adresse.Equals(value))
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
                if (!hausnummer.Equals(value))
                {
                    hausnummer = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Plz
        {
            get { return plz; }
            set
            {
                if (!plz.Equals(value))
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
                if (!ort.Equals(value))
                {
                    ort = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (!telefon.Equals(value))
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
                if (!bemerkungen.Equals(value))
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
