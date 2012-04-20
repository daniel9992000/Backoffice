using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Backoffice
{
    public class StundenEinlesen
    {  

        public void readcsv(string path)
        {
            OdbcConnection connection = null;
            OdbcDataReader reader = null;
            try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException();

                FileInfo fileInfo = new FileInfo(path);
                string connectionString = String.Format("Driver={{Microsoft Text Driver (*.txt; *.csv)}};Dbq={0};", fileInfo.DirectoryName);
                connection = new OdbcConnection(connectionString);
                connection.Open();
                OdbcCommand comm = new OdbcCommand(String.Format("select * from [{0}]", fileInfo.Name), connection);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Stunden s = new Stunden();
                    string zeile = reader.GetString(0);
                    string[] werte = zeile.Split(';');
                    s.Projektname = werte[0];
                    s.Mitarbeiter = werte[1];
                    s.Stundenanz = Int32.Parse(werte[2]);
                    s.Datum = DateTime.Parse(werte[3]);
                    BL.saveStunde(s);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
            
           
        }
    }
}
