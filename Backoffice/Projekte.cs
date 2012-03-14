using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Projekte
    {
        int projektid;
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Projektid
        {
            get { return projektid; }
            set { projektid = value; }
        }

    }
}
