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
                if (!string.IsNullOrWhiteSpace(firmenname))
                {   
                    if (!firmenname.Equals(value))
                    {
                        firmenname = value;
                        Status = ObjectStates.Modified;
                    }     
                }
                else
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
                    if (!string.IsNullOrWhiteSpace(vorname))
                    {   
                        if (!vorname.Equals(value))
                        {
                            vorname = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
                 if (!string.IsNullOrWhiteSpace(nachname))
                    {   
                        if (!nachname.Equals(value))
                        {
                            nachname = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
                if (!string.IsNullOrWhiteSpace(email))
                    {   
                        if (!email.Equals(value))
                        {
                            email = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
                    {
                        email = value;
                        Status = ObjectStates.Modified;
                    }
            }
        }

        public string Adresse
        {
            get { return adresse; }
            set
            {
                 if (!string.IsNullOrWhiteSpace(adresse))
                    {   
                        if (!adresse.Equals(value))
                        {
                            adresse = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
                 if (!string.IsNullOrWhiteSpace(hausnummer))
                    {   
                        if (!hausnummer.Equals(value))
                        {
                            hausnummer = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
                 if (!string.IsNullOrWhiteSpace(plz))
                    {   
                        if (!plz.Equals(value))
                        {
                            plz = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
                if (!string.IsNullOrWhiteSpace(ort))
                    {   
                        if (!ort.Equals(value))
                        {
                            ort = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
                if (!string.IsNullOrWhiteSpace(telefon))
                    {   
                        if (!telefon.Equals(value))
                        {
                            telefon = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
                if (!string.IsNullOrWhiteSpace(bemerkungen))
                    {   
                        if (!bemerkungen.Equals(value))
                        {
                            bemerkungen = value;
                            Status = ObjectStates.Modified;
                        }     
                    }
                    else
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
