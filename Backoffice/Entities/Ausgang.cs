using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Ausgang : Rechnung
    {
        int kundenid;
        int projektid;


        public Ausgang()
            : base()
        {
            this.kundenid = 0;
            this.projektid = 0;
        }

        public Ausgang(int rechnungid, string bezeichnung, DateTime datum, int kundenid, int projektid, ObjectStates status)
        {
            this.rechnungid = rechnungid;
            this.bezeichnung = bezeichnung;
            this.datum = datum;
            this.kundenid = kundenid;
            this.projektid = projektid;
            this.status = status;
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

        

        public int Projektid
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
    }
}
