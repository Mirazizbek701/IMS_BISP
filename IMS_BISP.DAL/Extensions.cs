using System.Data.SqlClient;

namespace IMS_BISP.DAL
{
    public static class Extensions
    {
        public static bool HasColumn(this SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                if (reader.GetName(i) == columnName) return true;
            return false;
        }
    }
}