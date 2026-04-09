using System;
using System.Data.SqlClient;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Mappers
{
    public static class UserMapper
    {
        public static User Map(SqlDataReader reader)
        {
            return new User
            {
                UserId = (int)reader["UserId"],
                StoreId = reader["StoreId"] == DBNull.Value ? (int?)null : (int)reader["StoreId"],
                StoreName = reader["StoreName"].ToString(),
                RoleId = (int)reader["RoleId"],
                RoleName = reader["RoleName"].ToString(),
                Username = reader["Username"].ToString(),
                PasswordHash = reader.HasColumn("PasswordHash") ? reader["PasswordHash"].ToString() : "",
                FullName = reader["FullName"].ToString(),
                IsActive = (bool)reader["IsActive"]
            };
        }
    }
}