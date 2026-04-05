using System.Configuration;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Data
{
    public static class DatabaseHelper
    {
        public static string ConnectionString { get; set; }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
