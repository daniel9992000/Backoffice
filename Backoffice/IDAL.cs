using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Backoffice
{
    public interface IDAL
    {
        void buildconnection();

        void saveKunde(Kunde k);
        void deleteKunde(Kunde k);
        List<Kunde> getKundeViewList();

        void saveProjekt(Projekte p);
        void deleteProjekt(Projekte p);
        List<Projekte> getProjektViewList();


    }
}
