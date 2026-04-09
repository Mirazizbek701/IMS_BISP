using System;
using System.Data.SqlClient;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Mappers
{
    public static class AuditLogMapper
    {
        public static AuditLog Map(SqlDataReader reader)
        {
            return new AuditLog
            {
                LogId = (int)reader["LogId"],
                Username = reader["Username"].ToString(),
                FullName = reader["FullName"].ToString(),
                ActionType = reader["ActionType"].ToString(),
                ActionDetail = reader["ActionDetail"] == DBNull.Value ? "" : reader["ActionDetail"].ToString(),
                LoggedAt = (DateTime)reader["LoggedAt"]
            };
        }
    }
}