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
        int plz;
        string ort;
        decimal telefon;
        string bemerkungen;
        ObjectStates status;

        public Kunde()
        {
        }

        public Kunde(int kundenid, string vorname, string nachname, string email)
        {
            this.kundenid = kundenid;
            this.vorname = vorname;
            this.nachname = nachname;
            this.email = email;
        }

        public Kunde(int kundenid, string vorname, string nachname, string email, ObjectStates status)
        {
            this.kundenid = kundenid;
            this.vorname = vorname;
            this.nachname = nachname;
            this.email = email;
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
                if (kundenid != value)
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
