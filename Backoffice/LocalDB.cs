using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Windows.Forms;

namespace Backoffice
{
    public class LocalDB
    {
        public int buildconnection ()
        {
            int text = 0;
            try
            {
                // PostgeSQL-style connection string
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    "localhost", 5432, "swe",
                    "swe", "EPU_SWE2");
                // Making connection with Npgsql provider
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                
                string sql = "SELECT * FROM Kunden;";
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                NpgsqlCommand allausrg = new NpgsqlCommand(sql,conn);
                allausrg.CommandType = System.Data.CommandType.Text;
                NpgsqlDataReader readausgrg;
                readausgrg = allausrg.ExecuteReader();
                while (readausgrg.HasRows)
                {
                    text++;
                    readausgrg.Read();
                }
                conn.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
               
               
               
            }
            return text;
        }
       
    }
}
