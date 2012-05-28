using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Buchungskategorie
    {
        int bkatid;
        string bezeichung;

        public Buchungskategorie()
        {
            this.bkatid = 0;
            this.bezeichung = string.Empty;
        }

        public Buchungskategorie(int id, string bezeichung)
        {
            this.bkatid = id;
            this.bezeichung = bezeichung;
        }

        public override string ToString()
        {
            return bezeichung;
        }

        public int Bkatid
        {
            get { return bkatid; }
            set { bkatid = value; }
        }

        public string Bezeichung
        {
            get { return bezeichung; }
            set { bezeichung = value; }
        }
    }
}
