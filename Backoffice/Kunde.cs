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
        ObjectStates status;

       
        public int Kundenid
        {
            get { return kundenid; }
            set { kundenid = value; }
        }
        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        public ObjectStates Status
        {
            get { return status; }
            set { status = value; }
        }


    }
}
