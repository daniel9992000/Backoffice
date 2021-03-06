﻿using System;
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
                string sql = @"Select Distinct kundenid,vorname,nachname,email,adresse,
                hausnummer,plz,ort,telefon,bemerkungen from kunden where vorname ~* @search or nachname ~* @search or email ~* @search or adresse ~* @search or ort ~* @search;";
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
                throw new DALException("DAL: Gesuchter Kunde konnte nicht aus der Datenbank geladen werden!", exp);
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
                    k.Hausnummer = reader.GetString(5).Trim();
                    k.Plz = reader.GetString(6).Trim();
                    k.Ort = reader.GetString(7).Trim();
                    k.Telefon = reader.GetString(8).Trim();
                    k.Bemerkungen = reader.GetString(9).Trim();
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
                    p.Stunden = getProjektStunden(p.Name);
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

        public List<Projekt> getProjektViewList(string search)
        {
            buildconnection();
            List<Projekt> plist = new List<Projekt>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select distinct projektid, name from projekte
                where name ~* @search;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@search", search);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Projekt p = new Projekt();
                    p.Projektid = reader.GetInt32(0);
                    p.Name = reader.GetString(1).Trim();
                    p.Stunden = getProjektStunden(p.Name);
                    p.Status = ObjectStates.Unmodified;
                    plist.Add(p);
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Gesuchtes Projekt konnte aus der Datenbank nicht geladen werden!", exp);
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
            buildconnection();
            List<Stunden> slist = new List<Stunden>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {

                string sql = @"Select projektname, mitarbeiter, stundenanz, datum 
                from stunden where projektname = @projektname;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@projektname", projektname);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Stunden s = new Stunden();
                    s.Projektname = reader.GetString(0).Trim();
                    s.Mitarbeiter = reader.GetString(1).Trim();
                    s.Stundenanz = reader.GetInt32(2);
                    s.Datum = reader.GetDateTime(3);
                    slist.Add(s);
                }
                return slist;

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Stunden konnten nicht gefunden werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
                reader.Close();
            }
        }

        public void saveStunden(Stunden s)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "";
                
                sql = @"Insert into stunden (projektname, mitarbeiter, stundenanz, datum)
                    values (@projektname,@mitarbeiter,@stundenanz,@datum)";
                comm = new NpgsqlCommand(sql, conn);
       
                comm.Parameters.AddWithValue("@projektname", s.Projektname);
                comm.Parameters.AddWithValue("@mitarbeiter", s.Mitarbeiter);
                comm.Parameters.AddWithValue("@stundenanz", s.Stundenanz);
                comm.Parameters.AddWithValue("@datum", s.Datum);
        
                comm.Prepare();
                comm.ExecuteNonQuery();
             
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Stunden konnten nicht gepspeichert werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }
        public int getProjektStunden(string projektname)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            int stunden = 0;
            try
            {

                string sql = @"Select coalesce(sum(stundenanz),0) from stunden
                where projektname = @projektname;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@projektname", projektname);
                stunden = Convert.ToInt32(comm.ExecuteScalar());
               
                return stunden;

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Stunden konnten nicht gefunden werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
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
        public Angebot getAngebotByProjektId(int projektid)
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
                    if (a.Chance > 0 && !a.Projektid.HasValue)
                    {
                        alist.Add(a);
                    }
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

        public Angebot getAngebot(int angebotid)
        {
            buildconnection();
            Angebot a = new Angebot();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {

                string sql = @"Select angebotid, summe, datum, dauer, chance, 
                kundenid, projektid, titel from angebote where angebotid = @angebotid;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@angebotid", angebotid);
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
        public List<Angebot> getAngebotViewListByProjektId(int projektid)
        {
            buildconnection();
            List<Angebot> alist = new List<Angebot>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {

                string sql = @"Select angebotid, summe, datum, dauer, chance, 
                kundenid, projektid, titel from angebote where projektid = @projektid;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@projektid", projektid);
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
            buildconnection();
            List<Kontakt> klist = new List<Kontakt>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select Distinct kontaktid, firmenname, vorname,nachname, email,adresse,hausnummer,
                plz, ort, telefon, bemerkungen from kontakte where firmenname ~* @search or vorname ~* @search 
                or nachname ~* @search or adresse ~* @search or ort ~* @search;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@search", search);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Kontakt k = new Kontakt();
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
                    klist.Add(k);
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Gesucher Kontakt konnte nicht aus der Datenbank geladen werden!", exp);
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
                    sql = @"Insert into rechnungen (datum,bezeichnung) 
                            values (@datum,@bezeichnung)";
                    sqlaus = "Insert into ausgang (rechnungid,projektid,kundenid) values (currval('rechnungen_rechnungid_seq'),@projektid,@kundenid)";
                    comm = new NpgsqlCommand(sql, conn);
                    commaus = new NpgsqlCommand(sqlaus, conn);

                }
                else if (r.Status == ObjectStates.Modified)
                {
                    sql = @"Update rechnungen set  datum = @datum, 
                    bezeichnung = @bezeichnung where rechnungid = @rechnungid";
                    comm = new NpgsqlCommand(sql, conn);
                    sqlaus = @"Update ausgang set projektid = @projektid, 
                    kundenid = @kundenid where rechnungid = @rechnungid";
                    commaus = new NpgsqlCommand(sqlaus, conn);
                    comm.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                    commaus.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                }
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
                string sql = "Delete from rechnungen_buchungen where rechnungid = @rechnungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                sql = "Delete from rechnungszeilen where rechnungid = @rechnungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                sql = "Delete from ausgang where rechnungid = @rechnungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                sql = "Delete from rechnungen where rechnungid = @rechnungid";
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
                string sql = @"Select r.rechnungid, a.projektid, a.kundenid, r.datum,r.bezeichnung from ausgang a, rechnungen r
                where a.rechnungid = r.rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
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

        public List<Ausgang> getAusgangViewList(string search)
        {
            buildconnection();
            List<Ausgang> rlist = new List<Ausgang>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select Distinct r.rechnungid, a.projektid, a.kundenid, r.datum,r.bezeichnung from ausgang a, rechnungen r
                where a.rechnungid = r.rechnungid and (r.bezeichnung ~* @search or r.datum ~* @search) ;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@search", search);
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

        public List<Ausgang> getAusgangViewListByProjektId(int projektid)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            List<Ausgang> rlist = new List<Ausgang>();
            try
            {

                string sql = @"Select a.rechnungid, a.projektid, a.kundenid, r.datum,r.bezeichnung
                from ausgang a, rechnungen r where a.rechnungid = r.rechnungid and projektid = @projektid;";
                comm = new NpgsqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@projektid", projektid);
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
            buildconnection();
            NpgsqlCommand commein = null, commrech = null;
            try
            {
                string sqlein = "", sqlrech = "";
                if (r.Status == ObjectStates.New)
                {   
                    sqlein = @"Insert into eingang (rechnungid,kontaktid, betrag,path) 
                            values (currval('rechnungen_rechnungid_seq'), @kontaktid, @betrag, @path)";
                    sqlrech = @"Insert into rechnungen (bezeichnung, datum)
                            values (@bezeichnung, @datum)";
                    commein = new NpgsqlCommand(sqlein, conn);
                    commrech = new NpgsqlCommand(sqlrech,conn);
                }
                else if (r.Status == ObjectStates.Modified)
                {
                    sqlein = @"Update eingang set kontaktid = @kontaktid, betrag = @betrag, path = @path 
                            where rechnungid = @rechnungid";
                    sqlrech = @"Update rechnungen set bezeichnung = @bezeichnung, datum = @datum
                            where rechnungid = @rechnungid";
                    commein = new NpgsqlCommand(sqlein, conn);
                    commrech = new NpgsqlCommand(sqlrech, conn);
                    commein.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                    commrech.Parameters.AddWithValue("@rechnungid", r.Rechnungid);
                }
    
                commrech.Parameters.AddWithValue("@bezeichnung", r.Bezeichnung);
                commrech.Parameters.AddWithValue("@datum", r.Datum);
                commrech.Prepare();
                commrech.ExecuteNonQuery();

                commein.Parameters.AddWithValue("@kontaktid", r.Kontaktid);
                commein.Parameters.AddWithValue("@betrag", r.Betrag);
                commein.Parameters.AddWithValue("@path", r.Path);
                commein.Prepare();
                commein.ExecuteNonQuery();

                r.Status = ObjectStates.Unmodified;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Kontakt konnte nicht gespeichert werden!", exp);
            }
            finally
            {
                commein.Dispose();
                commrech.Dispose();
                conn.Close();
            }
        }
        public void deleteEingang(Eingang r)
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
        public List<Eingang> getEingangViewList()
        {
            buildconnection();
            List<Eingang> rlist = new List<Eingang>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, e.kontaktid, e.betrag, r.datum,r.bezeichnung, e.path from eingang e, rechnungen r
                where e.rechnungid = r.rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Eingang r = new Eingang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Kontaktid = reader.GetInt32(1);
                    r.Betrag = reader.GetDouble(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();
                    r.Path = reader.GetString(5).Trim();
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

        public List<Eingang> getEingangViewList(string search)
        {
            buildconnection();
            List<Eingang> rlist = new List<Eingang>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select Distinct r.rechnungid, e.kontaktid, e.betrag, r.datum,r.bezeichnung, e.path from eingang e, rechnungen r
                where e.rechnungid = r.rechnungid and (r.bezeichnung ~* @searchor r.datum ~* @search);";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@search", search);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Eingang r = new Eingang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Kontaktid = reader.GetInt32(1);
                    r.Betrag = reader.GetDouble(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();
                    r.Path = reader.GetString(5).Trim();
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

        public List<Eingang> getEingangViewList(int kontaktid)
        {
            buildconnection();
            List<Eingang> rlist = new List<Eingang>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, e.kontaktid, e.betrag, r.datum,r.bezeichnung, e.path from eingang e, rechnungen r
                where e.rechnungid = r.rechnungid and e.kontaktid = @kontaktid;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@kontaktid", kontaktid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Eingang r = new Eingang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Kontaktid = reader.GetInt32(1);
                    r.Betrag = reader.GetDouble(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();
                    r.Path = reader.GetString(5).Trim();
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
                    sql = @"Insert into rechnungszeilen (bezeichnung, betrag,rechnungid) 
                            values (@bezeichnung, @betrag,@rechnungid)";
                    comm = new NpgsqlCommand(sql, conn);
                  
                }
                else if (r.Status == ObjectStates.Modified)
                {
                    sql = @"Update rechnungszeilen set bezeichnung = @bezeichnung, betrag = @betrag, 
                    rechnungid = @rechnungid where reid = @reid";
                    comm = new NpgsqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("@reid", r.Reid);
           
                }
                comm.Parameters.AddWithValue("@bezeichnung", r.Bezeichnung);
                comm.Parameters.AddWithValue("@betrag", r.Betrag);
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
                string sql = "Select reid,bezeichnung,betrag,rechnungid from rechnungszeilen where rechnungid = @rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", rechnungid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Rechnungszeile r = new Rechnungszeile();
                    r.Reid = reader.GetInt32(0);
                    r.Bezeichnung = reader.GetString(1).Trim();
                    r.Betrag = reader.GetDouble(2);
                    r.Rechnungid = reader.ReadNullableInt(3);
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
            List<Angebot> alist = new List<Angebot>();
            buildconnection();
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
                    if (a.Datum.Year == DateTime.Now.Year && a.Chance > 0)
                    {
                        alist.Add(a);
                    }
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

        public double[] getIstJahresumsatz()
        {
            double[] werte = new double[2] { 0, 0 };

            buildconnection();
            List<Angebot> alist = new List<Angebot>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = "Select summe,datum,chance from angebote;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetDateTime(1).Year == DateTime.Now.Year && reader.GetInt32(2) > 0)
                    {
                        werte[0]++;
                        werte[1] += reader.GetDouble(0);
                    }
                }

            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Jahresumsat konnte aus der Datenbank nicht geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }
            return werte;
        }

        public List<Ausgang> getEinnahmen(int month, int year)
        {
            buildconnection();
            List<Ausgang> rlist = new List<Ausgang>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, a.projektid, a.kundenid, r.datum,r.bezeichnung from ausgang a, rechnungen r
                where a.rechnungid = r.rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Ausgang r = new Ausgang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Projektid = reader.GetInt32(1);
                    r.Kundenid = reader.GetInt32(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();
                    if ((r.Datum.Value.Year) == year && (r.Datum.Value.Month == month))
                    {
                        rlist.Add(r);
                    }
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Einnahmen konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return rlist;
        }

        public List<Eingang> getAusgaben(int month, int year)
        {
            buildconnection();
            List<Eingang> rlist = new List<Eingang>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, e.kontaktid, e.betrag, r.datum,r.bezeichnung, e.path from eingang e, rechnungen r
                where e.rechnungid = r.rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Eingang r = new Eingang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Kontaktid = reader.GetInt32(1);
                    r.Betrag = reader.GetDouble(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();
                    r.Path = reader.GetString(5).Trim();
                    if ((r.Datum.Value.Year) == year && (r.Datum.Value.Month == month))
                    {
                        rlist.Add(r);
                    }
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Ausgaben konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }
            return rlist;
        }


        public List<Eingang> getOffeneERechnungen()
        {
            buildconnection();
            List<Eingang> rlist = new List<Eingang>();
            double summerezeile, summebuchung;
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, e.kontaktid, e.betrag, r.datum,r.bezeichnung, e.path from eingang e, rechnungen r
                where e.rechnungid = r.rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Eingang r = new Eingang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Kontaktid = reader.GetInt32(1);
                    r.Betrag = reader.GetDouble(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();
                    r.Path = reader.GetString(5).Trim();

                    summebuchung = summerezeile = 0;
                    List<Buchung> blist = getBuchungViewList(r.Rechnungid);
                    foreach (var buchung in blist)
                    {
                        summebuchung += buchung.Betrag;
                    }
                    if (summebuchung != summerezeile)
                        rlist.Add(r);
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Offene Eingangsrechnungen konnten nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }
            return rlist;
        }

        public List<Ausgang> getOffeneARechnungen()
        {
            buildconnection();
            List<Ausgang> rlist = new List<Ausgang>();
            double summerezeile, summebuchung;
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, a.projektid, a.kundenid, r.datum,r.bezeichnung from ausgang a, rechnungen r
                where a.rechnungid = r.rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Ausgang r = new Ausgang();
                    r.Rechnungid = reader.GetInt32(0);
                    r.Projektid = reader.GetInt32(1);
                    r.Kundenid = reader.GetInt32(2);
                    r.Datum = reader.ReadNullableDateTime(3);
                    r.Bezeichnung = reader.GetString(4).Trim();

                    summerezeile = summebuchung = 0;
                    List<Rechnungszeile> zeilen = getRechnungszeilenViewList(r.Rechnungid);
                    foreach (var rzeile in zeilen)
                    {
                        summerezeile += rzeile.Betrag;
                    }
                    List<Buchung> buchungen = getBuchungViewList(r.Rechnungid);
                    foreach (var buchung in buchungen)
                    {
                        summebuchung += buchung.Betrag;
                    }
                    if (summebuchung != summerezeile)
                        rlist.Add(r);
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Offene Ausgangsrechnungen konnten nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                comm.Dispose();
                reader.Close();
                conn.Close();
            }
            return rlist;
        }
        #endregion

        #region Buchungen

        public void saveBuchung(Buchung b)
        {
            buildconnection();
            NpgsqlCommand commbuch = null, commrechbuch = null;
            try
            {
                string sqlbuch="", sqlrechbuch = "";
                if (b.Status == ObjectStates.New)
                {
                    sqlbuch = @"Insert into buchungen (betrag,katid, datum) 
                            values (@betrag, @katid, @datum)";
                    sqlrechbuch = @"Insert into rechnungen_buchungen (rechnungid, buchungid) 
                            values (@rechnungid, currval('buchungen_buchungid_seq'))";
                
                    commbuch = new NpgsqlCommand(sqlbuch, conn);
                    commrechbuch = new NpgsqlCommand(sqlrechbuch, conn);
                }
                else if (b.Status == ObjectStates.Modified)
                {
                    sqlbuch = @"Update buchungen set betrag = @betrag, katid = @katid, datum = @datum
                            where buchungid = @buchungid";
                    sqlrechbuch = @"Update rechnungen_buchungen set rechnungid = @rechnungid
                            where buchungid = @buchungid";
                    commbuch = new NpgsqlCommand(sqlbuch, conn);
                    commrechbuch = new NpgsqlCommand(sqlrechbuch, conn);
                    commbuch.Parameters.AddWithValue("@buchungid", b.Buchungid);
                    commrechbuch.Parameters.AddWithValue("@buchungid", b.Buchungid);
                }

                commbuch.Parameters.AddWithValue("@betrag", b.Betrag);
                commbuch.Parameters.AddWithValue("@katid", b.Kategorie);
                commbuch.Parameters.AddWithValue("@datum", b.Datum);
                commbuch.Prepare();
                commbuch.ExecuteNonQuery();

                commrechbuch.Parameters.AddWithValue("@rechnungid", b.Rechnungid);
                commrechbuch.Prepare();
                commrechbuch.ExecuteNonQuery();

                b.Status = ObjectStates.Unmodified;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Buchung konnte nicht gespeichert werden!", exp);
            }
            finally
            {
                commbuch.Dispose();
                commrechbuch.Dispose();
                conn.Close();
            }
        }

        public void deleteBuchung(Buchung b)
        {
            buildconnection();
            NpgsqlCommand comm = null;
            try
            {
                string sql = "Delete from rechnungen_buchungen where buchungid = @buchungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@buchungid", b.Buchungid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                sql = "Delete from buchungen where buchungid = @buchungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@buchungid", b.Buchungid);
                comm.Prepare();
                comm.ExecuteNonQuery();
                b.Status = ObjectStates.Deleted;
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Buchung konnte nicht gelöscht werden!", exp);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public List<Buchung> getBuchungViewList(int rechnungid)
        {
            buildconnection();
            List<Buchung> blist = new List<Buchung>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select b.buchungid, b.betrag, b.katid, b.datum, rb.rechnungid from buchungen b, rechnungen_buchungen rb
                where b.buchungid = rb.buchungid and rb.rechnungid = @rechnungid;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", rechnungid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Buchung b = new Buchung();
                    b.Buchungid = reader.GetInt32(0);
                    b.Betrag = reader.GetDouble(1);
                    b.Kategorie = reader.GetInt32(2);
                    b.Datum = reader.GetDateTime(3);
                    b.Rechnungid = reader.GetInt32(4);
                    blist.Add(b);
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Buchungsliste konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return blist;
        }
        
        public List<Buchung> getBuchungViewList()
        {
            buildconnection();
            List<Buchung> blist = new List<Buchung>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select b.buchungid, b.betrag, b.katid, b.datum, rb.rechnungid from buchungen b, rechnungen_buchungen rb
                where b.buchungid = rb.buchungid;";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Buchung b = new Buchung();
                    b.Buchungid = reader.GetInt32(0);
                    b.Betrag = reader.GetDouble(1);
                    b.Kategorie = reader.GetInt32(2);
                    b.Datum = reader.GetDateTime(3);
                    b.Rechnungid = reader.GetInt32(4);
                    blist.Add(b);
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Buchungsliste konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return blist;
        }

        public List<Buchungskategorie> getBuchungsKategorien()
        {
            buildconnection();
            List<Buchungskategorie> blist = new List<Buchungskategorie>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select k.katid, k.bezeichnung from kategorie k";
                comm = new NpgsqlCommand(sql, conn);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Buchungskategorie b = new Buchungskategorie();
                    b.Bkatid = reader.GetInt32(0);
                    b.Bezeichung = reader.GetString(1).Trim();
                    blist.Add(b);
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Buchungskategorieliste konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return blist;
        }

        public Buchungskategorie getBuchungsKategorie(int id)
        {
            buildconnection();
            Buchungskategorie bkat = new Buchungskategorie();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select k.katid, k.bezeichnung from kategorie k where k.katid = @katid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@katid", id);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {       
                    bkat.Bkatid = reader.GetInt32(0);
                    bkat.Bezeichung = reader.GetString(1).Trim();  
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Buchungskategorie konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return bkat;
        }


        #endregion 

        public double getRechnungssumme(int rechnungid)
        {
            buildconnection();
            double? resumme = 0;
            double value = 0;
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select sum(betrag) as summe from rechnungszeilen 
                where rechnungid = @rechnungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", rechnungid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                   
                    resumme =  reader.ReadNullableDouble(0);
                  
                    
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnungssumme konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }
            if (resumme == null)
                value = 0;
            else
                value = resumme.Value;
            return value;
        }

        public List<Angebot> getAngebotViewList(string search)
        {
            buildconnection();
            List<Angebot> alist = new List<Angebot>();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select distinct angebotid,summe,datum,dauer,chance,kundenid,projektid,titel from angebote
                where titel ~* @search ;";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@search", search);
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
                throw new DALException("DAL: Gesuchtes Angebot konnte aus der Datenbank nicht geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }

            return alist;
        }

        public Rechnung getRechung(int rechnungsid)
        {
            buildconnection();
            Rechnung r = new Rechnung();
            NpgsqlCommand comm = null;
            NpgsqlDataReader reader = null;
            try
            {
                string sql = @"Select r.rechnungid, a.projektid, a.kundenid, r.datum, r.bezeichnung
                from rechnungen r, ausgang a where r.rechnungid = a.rechnungid and r.rechnungid = @rechnungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", rechnungsid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Ausgang a = new Ausgang();
                    a.Rechnungid = reader.GetInt32(0);
                    a.Projektid = reader.GetInt32(1);
                    a.Kundenid = reader.GetInt32(2);
                    a.Datum = reader.ReadNullableDateTime(3);
                    a.Bezeichnung = reader.GetString(4).Trim();
                    return a;
                }

                sql = @"Select r.rechnungid, e.kontaktid, e.betrag, e.path, r.datum, r.bezeichnung
                from rechnungen r, eingang e where r.rechnungid = e.rechnungid and r.rechnungid = @rechnungid";
                comm = new NpgsqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@rechnungid", rechnungsid);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Eingang e = new Eingang();
                    e.Rechnungid = reader.GetInt32(0);
                    e.Kontaktid = reader.GetInt32(1);
                    e.Betrag = reader.GetDouble(2);
                    e.Path = reader.GetString(3);
                    e.Datum = reader.ReadNullableDateTime(4);
                    e.Bezeichnung = reader.GetString(5).Trim();
                    return e;
                }
            }
            catch (NpgsqlException exp)
            {
                throw new DALException("DAL: Rechnung konnte nicht aus der Datenbank geladen werden!", exp);
            }
            finally
            {
                reader.Close();
                comm.Dispose();
                conn.Close();
            }
            return null;
        }

    }
}
