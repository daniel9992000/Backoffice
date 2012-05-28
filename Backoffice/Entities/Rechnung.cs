using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public class Rechnung
    {
        protected int rechnungid;
        protected string bezeichnung;
        protected DateTime? datum;
        protected ObjectStates status;

        public Rechnung()
        {
            this.datum = DateTime.Today;
            this.rechnungid = 0;
            this.bezeichnung = string.Empty;
        }

        public override string ToString()
        {
            return this.bezeichnung;
        }

        public int Rechnungid
        {
            get { return rechnungid; }
            set
            {
                if (rechnungid != value)
                {
                    rechnungid = value;
                    status = ObjectStates.Modified;
                }
            }
        }

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set
            {
                if (!string.IsNullOrWhiteSpace(bezeichnung))
                {
                    if (!bezeichnung.Equals(value))
                    {
                        bezeichnung = value;
                        Status = ObjectStates.Modified;
                    }
                }
                else
                {
                    bezeichnung = value;
                    Status = ObjectStates.Modified;
                }
            }
        }

        public DateTime? Datum
        {
            get { return datum; }
            set 
            { 
                if (datum.Equals(value))
                { 
                    datum = value;
                    status = ObjectStates.Modified;
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
