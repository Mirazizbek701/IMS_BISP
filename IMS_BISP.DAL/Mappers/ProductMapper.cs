using IMS_BISP.DAL.Models;
using System;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Mappers
{
    public static class ProductMapper
    {
        public static Product Map(SqlDataReader reader)
        {
            return new Product
            {
                ProductId = (int)reader["ProductId"],
                StoreId = (int)reader["StoreId"],
                StoreName = reader.HasColumn("StoreName") ? reader["StoreName"].ToString() : "",
                CategoryId = (int)reader["CategoryId"],
                CategoryName = reader["CategoryName"].ToString(),
                ProductName = reader["ProductName"].ToString(),
                SKU = reader["SKU"].ToString(),
                Quantity = (int)reader["Quantity"],
                UnitPrice = (decimal)reader["UnitPrice"],
                MinThreshold = reader.HasColumn("MinThreshold") ? (int)reader["MinThreshold"] : 0,
                Visibility = reader["Visibility"].ToString(),
                Description = reader["Description"] == DBNull.Value ? "" : reader["Description"].ToString(),
                UpdatedAt = (DateTime)reader["UpdatedAt"]
            };
        }
    }
}