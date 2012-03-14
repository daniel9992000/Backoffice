using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Windows.Forms;

namespace Backoffice
{
    public class LocalDB:IDAL
    {   
        NpgsqlConnection conn;
        public void buildconnection()
        {
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", 5432, "swe",
                    "swe", "EPU_SWE2");
                // Making connection with Npgsql provider
                conn = new NpgsqlConnection(connstring);
                conn.Open();
            }catch (Exception exp)
            {
                MessageBox .Show(exp.Message.ToString());
            }
        }

        public string testabfrage ()
        {   
            string ergebnis = "";  
            try 
            {
                buildconnection();
                string sql = "SELECT * FROM Kunden;";
                // data adapter making request from our connection
                NpgsqlCommand allausrg = new NpgsqlCommand(sql,conn);
                allausrg.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader readausgrg;
                readausgrg = allausrg.ExecuteReader();
                while (readausgrg.Read())
                {
                    ergebnis = readausgrg["nachname"].ToString();
                   
                }
                conn.Close();
            }  
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message.ToString());  
               
            }
            return ergebnis;
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
            buildconnection();
            List<Kunde> klist = new List<Kunde>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select * from Kunde;";
                comm = new NpgsqlCommand(sql, conn);             
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Kunde k = new Kunde();
                    k.Kundenid = reader.GetInt32(0);
                    k.Vorname = reader["vorname"].ToString();
                    k.Nachname = reader["nachname"].ToString();
                    klist.Add(k);
                }
               
            }
            catch (NpgsqlException exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            finally
            {
                reader.Close();
                comm.Dispose() ;
                conn.Close();
            }

            return klist;
 
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
