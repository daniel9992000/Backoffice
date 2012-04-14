using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Kunde
    {
        int kundenid;
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

        public Kunde()
        {
            this.vorname = string.Empty;
            this.nachname = string.Empty;
            this.email = string.Empty;
            this.adresse = string.Empty;
            this.hausnummer = string.Empty;
            this.plz = string.Empty;
            this.ort = string.Empty;
            this.telefon = string.Empty;
            this.bemerkungen = string.Empty;
        }

        public Kunde(int kundenid, string vorname, string nachname, string email)
        {
            this.kundenid = kundenid;
            this.vorname = vorname;
            this.nachname = nachname;
            this.email = email;
            this.adresse = string.Empty;
            this.hausnummer = string.Empty;
            this.plz = string.Empty;
            this.ort = string.Empty;
            this.telefon = string.Empty;
            this.bemerkungen = string.Empty;
        }

        public Kunde(int kundenid, string vorname, string nachname, string email, ObjectStates status)
        {
            this.kundenid = kundenid;
            this.vorname = vorname;
            this.nachname = nachname;
            this.email = email;
            this.adresse = string.Empty;
            this.hausnummer = string.Empty;
            this.plz = string.Empty;
            this.ort = string.Empty;
            this.telefon = string.Empty;
            this.bemerkungen = string.Empty;
            this.status = status;
        }

        public override string ToString()
        {
            return this.vorname + " " + this.nachname;
        }

        #region Properties 
        public int Kundenid
        {
            get { return kundenid; }
            set 
            {
                if (!kundenid.Equals(value))
                {
                    kundenid = value;
                    status = ObjectStates.Modified;
                }

            }
        }
        public string Vorname
        {
            get { return vorname; }
            set 
            {
                
                    if (!vorname.Equals(value))
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
                
                    if (!nachname.Equals(value))
                    {
                        nachname = value;
                        status = ObjectStates.Modified;
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
