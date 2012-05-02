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
        int stunden;
        ObjectStates status;

        public Projekt()
        {
            this.name = string.Empty;
            this.stunden = 0;
            this.projektid = 0;
        }

        public Projekt(int projektid, string name)
        {
            this.projektid = projektid;
            this.name = name;
            this.stunden = 0;
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
            this.stunden = 0;
        }

        public string Name
        {
            get { return name; }
            set {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        if (!value.Equals(name))
                        {
                            name = value;
                            Status = ObjectStates.Modified;
                        }
                    }
                }
        }

        public int Projektid
        {
            get { return projektid; }
            set { projektid = value; }
        }

        public int Stunden
        {
            get { return stunden; }
            set
            {
                if (stunden != value)
                {
                    stunden = value;
                    Status = ObjectStates.Modified;
                }
            }
        }

        public ObjectStates Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
