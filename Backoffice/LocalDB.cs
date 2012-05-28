using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Windows.Forms;

namespace Backoffice
{
    public class LocalDB : IDAL
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
                string sql = @"Select kundenid,vorname,nachname,email,adresse,
                hausnummer,plz,ort,telefon,bemerkungen from kunden;";
                comm = new NpgsqlCommand(sql, conn);             
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Kunde k = new Kunde();
                    k.Kundenid = reader.GetInt32(0);
                    k.Vorname = reader.GetString(1).Trim();
                    k.Nachname = reader.GetString(2).Trim();
                    k.Email = reader.GetString(3).Trim();
                    k.Adresse = reader.GetString(4).Trim();
                    k.Hausnummer = reader.GetString(5).Trim();
                    k.Plz = reader.GetString(6).Trim();
                    k.Ort = reader.GetString(7).Trim();
                    k.Telefon = reader.GetString(8).Trim();
                    k.Bemerkungen = reader.GetString(9).Trim();
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

        public List<Kunde> getKundeViewList(string search)
        {
            buildconnection();
            List<Kunde> klist = new List<Kunde>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select distinct kundenid,vorname,nachname,email,adresse,
                hausnummer,plz,ort,telefon,bemerkungen from kunden where vorname like %@search% or nachname like %@search% or email like %@search% or adresse like %@search% or ort like %@search%;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@search", search);
                comm.Prepare();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Kunde k = new Kunde();
                    k.Kundenid = reader.GetInt32(0);
                    k.Vorname = reader.GetString(1).Trim();
                    k.Nachname = reader.GetString(2).Trim();
                    k.Email = reader.GetString(3).Trim();
                    k.Adresse = reader.GetString(4).Trim();
                    k.Hausnummer = reader.GetString(5).Trim();
                    k.Plz = reader.GetString(6).Trim();
                    k.Ort = reader.GetString(7).Trim();
                    k.Telefon = reader.GetString(8).Trim();
                    k.Bemerkungen = reader.GetString(9).Trim();
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

        public Kunde getKunde(int id)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            Kunde k = new Kunde();
            try
            {
                string sql = @"Select kundenid, vorname,nachname,email,adresse,hausnummer,
                plz,ort,telefon,bemerkungen from kunden where kundenid = @kundenid;";
                comm = new NpgsqlCommand(sql, conn);
             
                comm.Parameters.AddWithValue("@kundenid",id);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    k.Kundenid = reader.GetInt32(0);
                    k.Vorname = reader.GetString(1).Trim();
                    k.Nachname = reader.GetString(2).Trim();
                    k.Email = reader.GetString(3).Trim();
                    k.Adresse = reader.GetString(4).Trim();
                    k.Hausnummer = reader.GetString(4).Trim();
                    k.Plz = reader.GetString(5).Trim();
                    k.Ort = reader.GetString(6).Trim();
                    k.Telefon = reader.GetString(7).Trim();
                    k.Bemerkungen = reader.GetString(8).Trim();
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
                string sql = "Select projektid, name from projekte;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Projekt p = new Projekt();
                    p.Projektid = reader.GetInt32(0);
                    p.Name = reader.GetString(1).Trim();
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
                string sql = "Select projektid, name from projekte where projektid = @projektid;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@projektid",id);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    p.Projektid = reader.GetInt32(0);
                    p.Name = reader.GetString(1).Trim();
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

        public List<Stunden> getStundenViewList(string projektname)
        {
            throw new NotImplementedException();
        }

        public void saveStunden(Stunden s)
        {
            throw new NotImplementedException();
        }
        public int getProjektStunden(string projektname)
        {
            throw new NotImplementedException();
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
                    sql = @"Insert into angebote (titel,summe,datum,dauer,chance,kundenid, projektid)
                        values (@titel,@summe,@datum,@dauer,@chance,@kundenid, @projektid)";
                    comm = new NpgsqlCommand(sql, conn);
                }
                else if (a.Status == ObjectStates.Modified)
                {
                    sql = @"Update angebote set titel = @titel, summe = @summe, datum = @datum, dauer=@dauer,chance = @chance,
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
                comm.Parameters.AddWithValue("@projektid", a.Projektid);
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
                string sql = "Select angebotid,summe,datum,dauer,chance,kundenid,projektid,titel from angebote;";
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
                    a.Projektid = reader.ReadNullableInt(6);
                    a.Titel = reader.GetString(7).Trim();
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
                string sql = @"Select angebotid, summe,datum,dauer,chance,kundenid,projektid,titel
                from angebote where kundenid = @kundenid;";
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
                    a.Projektid = reader.ReadNullableInt(6);
                    a.Titel = reader.GetString(7).Trim();
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
        public Angebot getProjektAngebot(int? projektid)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            Angebot a = new Angebot();
            try
            {

                string sql = @"Select angebotid, summe, datum, dauer, chance, 
                kundenid, projektid, titel from angebote where projektid = @projektid;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@projektid", projektid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    a.Angebotid = reader.GetInt32(0);
                    a.Summe = reader.GetDouble(1);
                    a.Datum = reader.GetDateTime(2);
                    a.Dauer = reader.GetInt32(3);
                    a.Chance = reader.GetInt32(4);
                    a.Kundenid = reader.GetInt32(5);
                    a.Projektid = reader.ReadNullableInt(6);
                    a.Titel = reader.GetString(7).Trim();
                    a.Status = ObjectStates.Unmodified;
                }
                return a;

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Angebot konnte nicht gefunden werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
                reader.Close();
            }
        }

        public List<Angebot> getAngebotViewList(int kundenid)
        {
            buildconnection();
            List<Angebot> alist = new List<Angebot>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {

                string sql = @"Select angebotid, summe, datum, dauer, chance, 
                kundenid, projektid, titel from angebote where kundenid = @kundenid;";
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
                    a.Projektid = reader.ReadNullableInt(6);
                    a.Titel = reader.GetString(7).Trim();
                    a.Status = ObjectStates.Unmodified;
                    alist.Add(a);
                }
                return alist;

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Angebot konnte nicht gefunden werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
                reader.Close();
            }
        }

        public List<Angebot> getAngebotViewList(int? projektid)
        {
            throw new NotImplementedException();
        }

        public Angebot getAngebot(int? projektid)
        {
            throw new NotImplementedException();
        }
        public List<Angebot> getAngebote()
        {
            throw new NotImplementedException();
        }

        public Angebot getAngebot(int angebotid)
        {
            throw new NotImplementedException();
        }
        public List<Angebot> getAngebotViewListByProjektId(int projektid)
        {
            throw new NotImplementedException();
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
                string sql = @"Select kontaktid, firmenname, vorname,nachname, email,adresse,hausnummer,
                plz, ort, telefon, bemerkungen from kontakte;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Kontakt k = new Kontakt();
                    k.Kontaktid = reader.GetInt32(0);
                    k.Firmenname = reader.GetString(1).Trim() ;
                    k.Vorname = reader.GetString(2).Trim();
                    k.Nachname = reader.GetString(3).Trim();
                    k.Email = reader.GetString(4).Trim();
                    k.Adresse = reader.GetString(5).Trim();
                    k.Hausnummer = reader.GetString(6).Trim();
                    k.Plz = reader.GetString(7).Trim();
                    k.Ort = reader.GetString(8).Trim();
                    k.Telefon = reader.GetString(9).Trim();
                    k.Bemerkungen = reader.GetString(10).Trim();
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

        public List<Kontakt> getKontaktViewList(string search)
        {
            throw new NotImplementedException();
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

                sql = @"Select kontaktid, firmenname, vorname,nachname, email,adresse,hausnummer,
                plz, ort, telefon, bemerkungen from kontakte where kontaktid = @kontaktid;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@kontaktid", id);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    k.Kontaktid = reader.GetInt32(0);
                    k.Firmenname = reader.GetString(1).Trim();
                    k.Vorname = reader.GetString(2).Trim();
                    k.Nachname = reader.GetString(3).Trim();
                    k.Email = reader.GetString(4).Trim();
                    k.Adresse = reader.GetString(5).Trim();
                    k.Hausnummer = reader.GetString(6).Trim();
                    k.Plz = reader.GetString(7).Trim();
                    k.Ort = reader.GetString(8).Trim();
                    k.Telefon = reader.GetString(9).Trim();
                    k.Bemerkungen = reader.GetString(10).Trim();
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

        #region Ausgangsrechnung
        public void saveAusgang(Ausgang r)
        {
            buildconnection();
            NpgsqlCommand comm = null, commaus = null;
            try
            {
                string sql = "", sqlaus= "";
                if (r.Status == ObjectStates.New)
                {
                    sql = @"Insert into rechnungen (offen, datum,bezeichnung) 
                            values (@offen, @datum,@bezeichnung)";
                    sqlaus = "Insert into ausgang (rechnungid,projektid,kundenid) values (currval('rechnungen_rechnungid_seq'),@projektid,@kundenid)";
                    comm = new NpgsqlCommand(sql, conn);
                    commaus = new NpgsqlCommand(sqlaus, conn);

                }
                else if (r.Status == ObjectStates.Modified)
                {
                    sql = @"Update rechnungen set offen = @offen, datum = @datum, 
                    bezeichnung = @bezeichnung where rechnungid = @rechnungid";
                    comm = new NpgsqlCommand(sql, conn);
                    sqlaus = @"Update ausgang set projektid = @projektid, 
                    kundenid = @kundenid where rechnungid = @rechnungid";
                    commaus = new NpgsqlCommand(sqlaus,conn);
                    comm.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                    commaus.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                }
                comm.Parameters.AddWithValue("@offen", true);
                comm.Parameters.AddWithValue("@datum", r.Datum);
                comm.Parameters.AddWithValue("@bezeichnung", r.Bezeichnung);
                comm.Prepare();
                comm.ExecuteNonQuery();
               
                commaus.Parameters.AddWithValue("@kundenid", r.Kundenid);
                commaus.Parameters.AddWithValue("@projektid", r.Projektid);
                commaus.Prepare();
                commaus.ExecuteNonQuery();
                r.Status = ObjectStates.Unmodified;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnung konnte nicht gespeichert werden!", exp);
              
            }
            finally
            {
                comm.Dispose();
                commaus.Dispose();
                conn.Close();
            }
        }

        public void deleteAusgang(Ausgang r)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "Delete from rechnungen where rechnungid = @rechnungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                r.Status = ObjectStates.Deleted;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnung konnte nicht gelöscht werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public List<Ausgang> getAusgangViewList()
        {
            buildconnection();
            List<Ausgang> rlist = new List<Ausgang>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, a.projektid, a.kundenid, r.offen, r.datum,r.bezeichnung from ausgang a, rechnungen r
                where a.rechnungid = r.rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Ausgang r = new Ausgang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Projektid = reader.GetInt32(1);
                    r.Kundenid = reader.GetInt32(2);
                    //r.offen = reader.GetBoolean(3);
                    r.Datum = reader.ReadNullableDateTime(4);
                    r.Bezeichnung = reader.GetString(5).Trim();
                    rlist.Add(r);
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnungsliste konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return rlist;
        }

        public List<Ausgang> getAusgangViewList(int kundenid)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            List<Ausgang> rlist = new List<Ausgang>();
            try
            {

                string sql = @"Select a.rechnungid, a.projektid, a.kundenid, r.datum,r.bezeichnung
                from ausgang a, rechnungen r where a.rechnungid = r.rechnungid and kundenid = @kundenid;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@kundenid", kundenid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Ausgang r = new Ausgang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Projektid = reader.GetInt32(1);
                    r.Kundenid = reader.GetInt32(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();
                    rlist.Add(r);
                }
                return rlist;

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnungsliste konnte nicht gefunden werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
                reader.Close();
            }
        }
        #endregion

        #region Eingangsrechnungen

        public void saveEingang(Eingang r)
        {
            throw new NotImplementedException();
        }
        public void deleteEingang(Eingang r)
        {
            throw new NotImplementedException();
        }
        public List<Eingang> getEingangViewList()
        {
            throw new NotImplementedException();
        }
        public List<Eingang> getEingangViewList(int kontaktid)
        {
            throw new NotImplementedException();
        }
        public List<Rechnung> getRechnungViewList(int kundenid)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Rechnungszeile
        public void saveRechnungszeile(Rechnungszeile r)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                if (r.Status == ObjectStates.New)
                {
                    sql = @"Insert into rechnungszeilen (bezeichnung, betrag,angebotid,rechnungid) 
                            values (@bezeichnung, @betrag,@angebotid, @rechnungid)";
                    comm = new NpgsqlCommand(sql, conn);
                  
                }
                else if (r.Status == ObjectStates.Modified)
                {
                    sql = @"Update rechnungszeilen set bezeichnung = @bezeichnung, betrag = @betrag, 
                    angebotid = @angebotid, rechnungid = @rechnungid where reid = @reid";
                    comm = new NpgsqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@reid", r.Reid);
           
                }
                comm.Parameters.AddWithValue("@bezeichnung", r.Bezeichnung);
                comm.Parameters.AddWithValue("@betrag", r.Betrag);
                comm.Parameters.AddWithValue("@angebotid", r.Angebotid);
                comm.Parameters.AddWithValue("@rechnungid", r.Rechnungid);

                comm.Prepare();
                comm.ExecuteNonQuery();
                r.Status = ObjectStates.Unmodified;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnungszeile konnte nicht gespeichert werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public void deleteRechnungszeile(Rechnungszeile r)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "Delete from rechnungszeilen where reid = @reid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@reid", r.Reid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                r.Status = ObjectStates.Deleted;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnungszeile konnte nicht gelöscht werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public List<Rechnungszeile> getRechnungszeilenViewList(int rechnungid)
        {
            buildconnection();
            List<Rechnungszeile> rlist = new List<Rechnungszeile>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select reid,bezeichnung,betrag,angebotid,rechnungid from rechnungszeilen where rechnungid = @rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", rechnungid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Rechnungszeile r = new Rechnungszeile();
                    r.Reid = reader.GetInt32(0);
                    r.Bezeichnung = reader.GetString(1).Trim();
                    r.Betrag = reader.GetDouble(2);
                    r.Angebotid = reader.ReadNullableInt(3);
                    r.Rechnungid = reader.ReadNullableInt(4);
                    rlist.Add(r);
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnungszeilenliste konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return rlist;
        }
        #endregion

        #region Auswertungen
        public List<Angebot> getJahresumsatzViewList()
        {
            throw new NotImplementedException();
        }

        public double[] getIstJahresumsatz()
        {
            throw new NotImplementedException();
        }

        public List<Ausgang> getEinnahmen(int month, int year)
        {
            throw new NotImplementedException();
        }

        public List<Eingang> getAusgaben(int month, int year)
        {
            throw new NotImplementedException();
        }


        public List<Eingang> getOffeneERechnungen()
        {
            throw new NotImplementedException();
        }

        public List<Ausgang> getOffeneARechnungen()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Buchungen

        public void saveBuchung(Buchung b)
        {
            throw new NotImplementedException();
        }

        public void deleteBuchung(Buchung b)
        {
            throw new NotImplementedException();
        }

        public List<Buchung> getBuchungViewList(int rechnungid)
        {
            throw new NotImplementedException();
        }
        public List<Buchung> getBuchungViewList()
        {
            throw new NotImplementedException();
        }

        public List<Buchungskategorie> getBuchungsKategorien()
        {
            throw new NotImplementedException();
        }

        public Buchungskategorie getBuchungsKategorie(int id)
        {
            throw new NotImplementedException();
        }


        #endregion 

       

       

        public List<Ausgang> getAusgangViewListByProjektId(int projektid)
        {
            throw new NotImplementedException();
        }

       

        public double getRechnungssumme(int rechnungid)
        {
            throw new NotImplementedException();
        }

       

      

        public List<Angebot> getAngebotViewList(string search)
        {
            throw new NotImplementedException();
        }


        public Rechnung getRechung(int rechnungsid)
        {
            throw new NotImplementedException();
        }
    }
}
