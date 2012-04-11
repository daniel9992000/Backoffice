using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public static class DbHelper
    {
        public static int? ReadNullableInt(this Npgsql.NpgsqlDataReader rd, int col)
        {
            return rd.IsDBNull(col) ? (int?)null : rd.GetInt32(col);
        }

        public static double? ReadNullableDouble(this Npgsql.NpgsqlDataReader rd, int col)
        {
            return rd.IsDBNull(col) ? (double?)null : rd.GetDouble(col);
        }
        public static DateTime? ReadNullableDateTime(this Npgsql.NpgsqlDataReader rd, int col)
        {
            return rd.IsDBNull(col) ? (DateTime?)null : rd.GetDateTime(col);
        }
    }
}
