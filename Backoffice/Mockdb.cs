using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    class Mockdb:IDAL
    {
        public void buildconnection()
        {
            throw new NotImplementedException();
        }

        public void saveKunde(Kunde k)
        {
            throw new NotImplementedException();
        }

        public void deleteKunde(Kunde k)
        {
            throw new NotImplementedException();
        }

        public List<Kunde> getKundeViewList()
        {
            throw new NotImplementedException();
        }

        public void saveProjekt(Projekte p)
        {
            throw new NotImplementedException();
        }

        public void deleteProjekt(Projekte p)
        {
            throw new NotImplementedException();
        }

        public List<Projekte> getProjektViewList()
        {
            throw new NotImplementedException();
        }
    }
}
