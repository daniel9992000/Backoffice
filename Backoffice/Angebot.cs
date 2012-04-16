using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Angebot
    {
        int angebotid;
        string titel;
        double summe;
        DateTime datum;
        int dauer;
        int chance;
        int kundenid;
        int? projektid;
        ObjectStates status;

        public Angebot()
        {
            this.angebotid = 0;
            this.titel = string.Empty;
            this.summe = 0;
            this.datum = DateTime.Today;
            this.dauer = 0;
            this.chance = 0;
            this.kundenid = 0;
            this.projektid = 0;            
        }

        public Angebot(int angebotid, string titel, double summe, DateTime datum, int dauer, int chance, int kundenid, int projektid, ObjectStates status)
        {
            this.angebotid = angebotid;
            this.titel = titel;
            this.summe = summe;
            this.datum = datum;
            this.dauer = dauer;
            this.chance = chance;
            this.kundenid = kundenid;
            this.projektid = projektid;
            this.status = status;
        }

        #region Properties
        public int Angebotid
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


        public string Titel
        {
            get { return titel; }
            set
            {
                if (!string.IsNullOrWhiteSpace(titel))
                {
                    if (titel.Equals(value))
                    {
                        titel = value;
                        Status = ObjectStates.Modified;
                    }
                }
                else
                {
                    titel = value;
                    Status = ObjectStates.Modified;
                }
            }
        }

        public double Summe
        {
            get { return summe; }
            set
            {
                if (summe != value)
                {
                    summe = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public DateTime Datum
        {
            get { return datum; }
            set
            {
                if (datum != value)
                {
                    datum = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int Dauer
        {
            get { return dauer; }
            set
            {
                if (dauer != value)
                {
                    dauer = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public int Chance
        {
            get { return chance; }
            set
            {
                if (chance != value)
                {
                    chance = value;
                    status = ObjectStates.Modified;
                }
            }
        }

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

        public int? Projektid
        {
            get { return projektid; }
            set
            {
                if (projektid != value)
                {
                    projektid = value;
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
