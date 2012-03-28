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
                    Properties.Settings.Default.DatabaseServer, 
                    Properties.Settings.Default.DatabasePort,
                    Properties.Settings.Default.DatabaseUser,
                    Properties.Settings.Default.DatabasePassword,
                    Properties.Settings.Default.Database);
                // Making connection with Npgsql provider
                conn = new NpgsqlConnection(connstring);
                conn.Open();
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Datenbankverbindung konnten nicht geöffent werden!", exp);
            }
        }

        #region Kunde
        public void saveKunde(Kunde k)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                if (k.Status == ObjectStates.New)
                {
                    sql = @"Insert into kunden (nachname,vorname,email,adresse,hausnummer,plz,ort,telefon,bemerkungen) 
                            values (@nachname,@vorname,@email,@adresse,@hausnummer,@plz,@ort,@telefon,@bemerkungen)"; 
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
                throw new DALException("DAL: Kunde konnte nicht gespeichert werden!", exp);
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
                throw new DALException("DAL: Kunde konnte nicht gelöscht werden!", exp);
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
                    k.Status = ObjectStates.Unmodified;
                    klist.Add(k);
                }
               
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Kundeliste konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose() ;
                conn.Close();
            }

            return klist;
 
        }

        public Kunde getKunde(int id)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            Kunde k = new Kunde();
            try
            {
                string sql = "";

                sql = "Select * from kunde where kundenid = @kundenid;";
                comm = new NpgsqlCommand(sql, conn);
             
                comm.Parameters.AddWithValue("@kundenid",id);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
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
                    k.Status = ObjectStates.Unmodified;
                }
                return k;
              
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Kunde konnte nicht gefunden werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
                reader.Close();
            }
        }
        #endregion

        #region Projekt
        public void saveProjekt(Projekt p)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                if (p.Status == ObjectStates.New)
                {
                    sql = "Insert into projekte (name) values (@name)";
                    comm = new NpgsqlCommand(sql, conn);
                }
                else if (p.Status == ObjectStates.Modified)
                {
                    sql = @"Update projekte set name = @name where projektid = @projektid";
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
                throw new DALException("DAL: Projekt konnte nicht gepspeichert werden!", exp);
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
                throw new DALException("DAL: Projekt konnte nicht gelöscht werden!", exp);
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
                    p.Status = ObjectStates.Unmodified;
                    plist.Add(p);
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Projekteliste konnte aus der Datenbank nicht geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return plist;
        }

        public Projekt getProjekt(int id)
        {
            buildconnection();
            Projekt p = new Projekt();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select * from projekte where projektid = @projektid;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@projektid",id);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    p.Projektid = reader.GetInt32(0);
                    p.Name = reader["name"].ToString().Trim();
                    p.Status = ObjectStates.Unmodified;
                 
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Projekt konnte aus der Datenbank nicht geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return p;
        }

        #endregion

        #region Angebot
        public void saveAngebot(Angebot a)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                if (a.Status == ObjectStates.New)
                {
                    sql = @"Insert into angebote (titel,summe,datum,dauer,chance,kundenid)
                        values (@titel,@summe,@datum,@dauer,@chance,@kundenid)";
                    comm = new NpgsqlCommand(sql, conn);
                }
                else if (a.Status == ObjectStates.Modified)
                {
                    sql = @"Update angebote set titel = @titel, summe = @summe, datum = @datum, chance = @chance,
                           kundenid = @kundenid, projektid = @projektid where angebotid = @angebotid";
                    comm = new NpgsqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@angebotid", a.Angebotid);
                }
                comm.Parameters.AddWithValue("@titel", a.Titel);
                comm.Parameters.AddWithValue("@summe", a.Summe);
                comm.Parameters.AddWithValue("@datum", a.Datum);
                comm.Parameters.AddWithValue("@dauer", a.Dauer);
                comm.Parameters.AddWithValue("@chance", a.Chance);
                comm.Parameters.AddWithValue("@kundenid", a.Kundenid);
                //comm.Parameters.AddWithValue("@projektid", 1);
                comm.Prepare();
                comm.ExecuteNonQuery();
                a.Status = ObjectStates.Unmodified;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Angebot konnte nicht gepspeichert werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public void deleteAngebot(Angebot a)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "Delete from angebote where angebotid = @angebotid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@angebotid", a.Angebotid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                a.Status = ObjectStates.Deleted;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Angebot konnte nicht gelöscht werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public List<Angebot> getAngebotViewList()
        {
            buildconnection();
            List<Angebot> alist = new List<Angebot>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select * from angebote;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Angebot a = new Angebot();
                    a.Angebotid = reader.GetInt32(0);
                    a.Summe = reader.GetDouble(1);
                    a.Datum = reader.GetDateTime(2);
                    a.Dauer = reader.GetInt32(3);
                    a.Chance = reader.GetInt32(4);
                    a.Kundenid = reader.GetInt32(5);
                    //a.Projektid = reader.GetInt32(6);
                    a.Titel = reader["titel"].ToString().Trim();
                    a.Status = ObjectStates.Unmodified;
                    alist.Add(a);
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Angebotliste konnte aus der Datenbank nicht geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return alist;
        }


        public List<Angebot> getKundenAngebote(int kundenid)
        {
            buildconnection();
            List<Angebot> alist = new List<Angebot>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select * from angebote where kundenid = @kundenid;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@kundenid", kundenid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Angebot a = new Angebot();
                    a.Angebotid = reader.GetInt32(0);
                    a.Summe = reader.GetDouble(1);
                    a.Datum = reader.GetDateTime(2);
                    a.Dauer = reader.GetInt32(3);
                    a.Chance = reader.GetInt32(4);
                    a.Kundenid = reader.GetInt32(5);
                    a.Projektid = reader.GetInt32(6);
                    a.Titel = reader.GetString(7);
                    a.Status = ObjectStates.Unmodified;
                    alist.Add(a);

                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Angebote konnten aus der Datenbank nicht geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return alist;
        }

        #endregion

        #region Kontakt
        public void saveKontakt(Kontakt k)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                if (k.Status == ObjectStates.New)
                {
                    sql = @"Insert into kontakte (firmenname, nachname,vorname,email,adresse,hausnummer,plz,ort,telefon,bemerkungen) 
                            values (@firmenname, @nachname,@vorname,@email,@adresse,@hausnummer,@plz,@ort,@telefon,@bemerkungen)";
                    comm = new NpgsqlCommand(sql, conn);
                }
                else if (k.Status == ObjectStates.Modified)
                {
                    sql = @"Update kontakte set firmenname = @firmenname, nachname = @nachname, vorname = @vorname, email=@email, adresse = @adresse, hausnummer = @hausnummer, 
                            plz = @plz, ort = @ort, telefon = @telefon, bemerkungen = @bemerkungen where kontaktid = @kontaktid";
                    comm = new NpgsqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@kontaktid", k.Kontaktid);
                }
                comm.Parameters.AddWithValue("@firmenname", k.Firmenname);
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
                throw new DALException("DAL: Kontakt konnte nicht gespeichert werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public void deleteKontakt(Kontakt k)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "Delete from kontakte where kontaktid = @kontaktid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@kontaktid", k.Kontaktid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                k.Status = ObjectStates.Deleted;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Kontakt konnte nicht gelöscht werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public List<Kontakt> getKontaktViewList()
        {
            buildconnection();
            List<Kontakt> klist = new List<Kontakt>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select * from kontakte;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Kontakt k = new Kontakt();
                    k.Kontaktid = reader.GetInt32(0);
                    k.Firmenname = reader["firmenname"].ToString().Trim();
                    k.Vorname = reader["vorname"].ToString().Trim();
                    k.Nachname = reader["nachname"].ToString().Trim();
                    k.Email = reader["email"].ToString().Trim(); ;
                    k.Adresse = reader["adresse"].ToString().Trim();
                    k.Hausnummer = reader["hausnummer"].ToString().Trim();
                    k.Plz = reader.GetInt32(6);
                    k.Ort = reader["ort"].ToString().Trim();
                    k.Telefon = reader.GetInt64(8);
                    k.Bemerkungen = reader["bemerkungen"].ToString().Trim();
                    k.Status = ObjectStates.Unmodified;
                    klist.Add(k);
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Kundeliste konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return klist;
        }

        public Kontakt getKontakt(int id)
        {

            buildconnection();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            Kontakt k = new Kontakt();
            try
            {
                string sql = "";

                sql = "Select * from kontakte where kontaktid = @kontaktid;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@kontaktid", id);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    k.Kontaktid = reader.GetInt32(0);
                    k.Firmenname = reader["firmenname"].ToString().Trim();
                    k.Vorname = reader["vorname"].ToString().Trim();
                    k.Nachname = reader["nachname"].ToString().Trim();
                    k.Email = reader["email"].ToString().Trim(); ;
                    k.Adresse = reader["adresse"].ToString().Trim();
                    k.Hausnummer = reader["hausnummer"].ToString().Trim();
                    k.Plz = reader.GetInt32(6);
                    k.Ort = reader["ort"].ToString().Trim();
                    k.Telefon = reader.GetInt64(8);
                    k.Bemerkungen = reader["bemerkungen"].ToString().Trim();
                    k.Status = ObjectStates.Unmodified;
                }
                return k;

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Kontakt konnte nicht gefunden werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
                reader.Close();
            }
        }
        #endregion
    }
}
