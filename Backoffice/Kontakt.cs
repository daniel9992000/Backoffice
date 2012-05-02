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
            this.firmenname = string.Empty;
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

        public Kontakt(int kontaktid, string vorname, string nachname, string firmenname, string email, ObjectStates status)
        {
            this.kontaktid = kontaktid;
            this.vorname = vorname;
            this.nachname = nachname;
            this.firmenname = firmenname;
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
                if (!string.IsNullOrWhiteSpace(value))
                {   
                    if (!value.Equals(firmenname))
                    {
                        firmenname = value;
                        Status = ObjectStates.Modified;
                    }     
                }
            }
        }
     

        public string Vorname
        {
            get { return vorname; }
            set {
                    if (!string.IsNullOrWhiteSpace(value))
                    {   
                        if (!value.Equals(vorname))
                        {
                            vorname = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                 }
        }
        
        public string Nachname
        {
            get { return nachname; }
            set
            {
                 if (!string.IsNullOrWhiteSpace(value))
                    {   
                        if (!value.Equals(nachname))
                        {
                            nachname = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    {   
                        if (!value.Equals(email))
                        {
                            email = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
            }
        }

        public string Adresse
        {
            get { return adresse; }
            set
            {   
                if (!value.Equals(adresse))
                {
                    adresse = value;
                    Status = ObjectStates.Modified;
                }              
            }
        }

        public string Hausnummer
        {
            get { return hausnummer; }
            set
            {
            
                if (!value.Equals(hausnummer))
                {
                    hausnummer = value;
                    Status = ObjectStates.Modified;
                }     
            }
        }

        public string Plz
        {
            get { return plz; }
            set
            {  
                if (!value.Equals(plz))
                {
                    plz = value;
                    Status = ObjectStates.Modified;
                }     
            }
        }

        public string Ort
        {
            get { return ort; }
            set
            {
                if (!value.Equals(ort))
                {
                    ort = value;
                    Status = ObjectStates.Modified;
                }     
            }
        }

        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (!value.Equals(telefon))
                {
                    telefon = value;
                    Status = ObjectStates.Modified;
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
                    Status = ObjectStates.Modified;
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
