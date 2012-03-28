using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Projekt
    {
        int projektid;
        string name;
        ObjectStates status;

        public Projekt()
        {
        }

        public Projekt(int projektid, string name)
        {
            this.projektid = projektid;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public Projekt(int projektid, string name, ObjectStates status)
        {
            this.projektid = projektid;
            this.name = name;
            this.status = status;
        }

        public string Name
        {
            get { return name; }
            set {
                    if (name != value)
                    { 
                        name = value;
                        status = ObjectStates.Modified;
                    }
                }
        }

        public int Projektid
        {
            get { return projektid; }
            set { projektid = value; }
        }

        public ObjectStates Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
