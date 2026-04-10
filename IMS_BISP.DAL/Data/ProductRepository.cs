using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IMS_BISP.DAL.Mappers;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Data
{
    public static class ProductRepository
    {
        public static List<Product> GetByStore(int storeId)
        {
            try
            {
                var list = new List<Product>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Products_GetByStore", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(ProductMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetByStore (Products): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Product> GetLowStock(int storeId)
        {
            var list = new List<Product>();
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Products_GetLowStock", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StoreId", storeId);
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Product
                    {
                        ProductId    = reader["ProductId"]    != DBNull.Value ? (int)reader["ProductId"]    : 0,
                        ProductName  = reader["ProductName"].ToString(),
                        SKU          = reader["SKU"].ToString(),
                        CategoryName = reader["CategoryName"].ToString(),
                        Quantity     = (int)reader["Quantity"],
                        MinThreshold = (int)reader["MinThreshold"],
                        BookedQnt    = reader["BookedQnt"]    != DBNull.Value ? (int)reader["BookedQnt"]    : 0,
                        Available    = reader["Available"]    != DBNull.Value ? (int)reader["Available"]    : 0
                    });
                }
            }
            return list;
        }

        public static Product GetById(int productId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Products_GetById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) return ProductMapper.Map(reader);
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetById (Products): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Product> GetPublicExcludingStore(int storeId)
        {
            try
            {
                var list = new List<Product>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Products_GetPublicExcludingStore", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(ProductMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetPublicExcludingStore: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(int storeId, int categoryId, string productName,
            string sku, int quantity, decimal unitPrice,
            int minThreshold, string visibility, string description)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Products_Insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@SKU", sku);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@MinThreshold", minThreshold);
                    cmd.Parameters.AddWithValue("@Visibility", visibility);
                    cmd.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Insert (Products): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Update(int productId, int categoryId, string productName,
            string sku, int quantity, decimal unitPrice,
            int minThreshold, string visibility, string description)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Products_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@SKU", sku);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@MinThreshold", minThreshold);
                    cmd.Parameters.AddWithValue("@Visibility", visibility);
                    cmd.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Update (Products): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ToggleVisibility(int productId, string visibility)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Products_ToggleVisibility", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@Visibility", visibility);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in ToggleVisibility: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SoftDelete(int productId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Products_SoftDelete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in SoftDelete (Products): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
