using System;
using System.Data.SqlClient;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Mappers
{
    public static class StoreMapper
    {
        public static Store Map(SqlDataReader reader)
        {
            return new Store
            {
                StoreId = (int)reader["StoreId"],
                StoreName = reader["StoreName"].ToString(),
                ContactPhone = reader["ContactPhone"] == DBNull.Value ? "" : reader["ContactPhone"].ToString(),
                IsActive = (bool)reader["IsActive"],
                CreatedAt = (DateTime)reader["CreatedAt"]
            };
        }
    }
}