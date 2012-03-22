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
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        public void saveKunde(Kunde k)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                if (k.Status == ObjectStates.New)
                {
                    sql = "Insert into kunden values (nextval('kunden_seq'),@nachname,@vorname,@email,@adresse,@hausnummer,@plz,@ort,@telefon,@bemerkungen)"; 
                    comm = new NpgsqlCommand(sql, conn);
                }
                else if (k.Status == ObjectStates.Modified)
                {
                    sql = @"Update kunden set nachname = @nachname, vorname = @vorname, email=@email, adresse = @adresse, hausnummer = @hausnummer, 
                            plz = @plz, ort = @ort, telefon = @telefon, bemerkungen = @bemerkungen where kundenid = @kundenid";
                    comm = new NpgsqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@kundenid", k.Kundenid);  
                }   
                comm.Parameters.AddWithValue("@nachname", k.Nachname);
                comm.Parameters.AddWithValue("@vorname", k.Vorname);
                comm.Parameters.AddWithValue("@email", k.Email);
                comm.Parameters.AddWithValue("@adresse", k.Adresse);
                comm.Parameters.AddWithValue("@hausnummer", k.Hausnummer);
                comm.Parameters.AddWithValue("@plz", k.Plz);
                comm.Parameters.AddWithValue("@ort", k.Ort);
                comm.Parameters.AddWithValue("@telefon", k.Telefon);
                comm.Parameters.AddWithValue("@bemerkungen", k.Bemerkungen);
                comm.Prepare();
                comm.ExecuteNonQuery();
                k.Status = ObjectStates.Unmodified;
            }
            catch (NpgsqlException exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public void deleteKunde(Kunde k)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "Delete from kunden where kundenid = @kundenid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@kundenid", k.Kundenid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                k.Status = ObjectStates.Deleted;
            }
            catch (NpgsqlException exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public List<Kunde> getKundeViewList()
        {
            buildconnection();
            List<Kunde> klist = new List<Kunde>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select * from kunden;";
                comm = new NpgsqlCommand(sql, conn);             
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Kunde k = new Kunde();
                    k.Kundenid = reader.GetInt32(0);
                    k.Vorname = reader["vorname"].ToString().Trim();
                    k.Nachname = reader["nachname"].ToString().Trim();
                    k.Email = reader["email"].ToString().Trim(); ;
                    k.Adresse = reader["adresse"].ToString().Trim();
                    k.Hausnummer = reader["hausnummer"].ToString().Trim();
                    k.Plz = reader.GetInt32(6);
                    k.Ort = reader["ort"].ToString().Trim();
                    k.Telefon = reader.GetInt64(8);
                    k.Bemerkungen = reader["bemerkungen"].ToString().Trim();
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

        public void saveProjekt(Projekt p)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                if (p.Status == ObjectStates.New)
                {
                    sql = "Insert into projekte values (nextval('projekt_seq'),@name)";
                    comm = new NpgsqlCommand(sql, conn);
                }
                else if (p.Status == ObjectStates.Modified)
                {
                    sql = @"Update projekt set name = @name where projektid = @projektid";
                    comm = new NpgsqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@projektid", p.Projektid);
                }
                comm.Parameters.AddWithValue("@name", p.Name);
                comm.Prepare();
                comm.ExecuteNonQuery();
                p.Status = ObjectStates.Unmodified;
            }
            catch (NpgsqlException exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public void deleteProjekt(Projekt p)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "Delete from projekte where projektid = @projektid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@projektid", p.Projektid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                p.Status = ObjectStates.Deleted;
            }
            catch (NpgsqlException exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public List<Projekt> getProjektViewList()
        {
            buildconnection();
            List<Projekt> plist = new List<Projekt>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select * from projekte;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Projekt p = new Projekt();
                    p.Projektid = reader.GetInt32(0);
                    p.Name = reader["name"].ToString().Trim();
                    plist.Add(p);
                }

            }
            catch (NpgsqlException exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return plist;
        }
    }
}
