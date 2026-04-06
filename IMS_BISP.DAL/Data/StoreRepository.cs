using IMS_BISP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Data
{
    public static class StoreRepository
    {
        private static Store MapStore(SqlDataReader reader)
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

        public static List<Store> GetAll()
        {
            var list = new List<Store>();
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Stores_GetAll", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(MapStore(reader));
            }
            return list;
        }

        public static List<Store> GetAllActive()
        {
            var list = new List<Store>();
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Stores_GetAllActive", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(MapStore(reader));
            }
            return list;
        }

        public static Store GetById(int storeId)
        {
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Stores_GetById", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StoreId", storeId);
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read()) return MapStore(reader);
            }
            return null;
        }

        public static int Insert(string storeName, string contactPhone)
        {
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Stores_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StoreName", storeName);
                cmd.Parameters.AddWithValue("@ContactPhone", (object)contactPhone ?? DBNull.Value);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void Update(int storeId, string storeName, string contactPhone)
        {
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Stores_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StoreId", storeId);
                cmd.Parameters.AddWithValue("@StoreName", storeName);
                cmd.Parameters.AddWithValue("@ContactPhone", (object)contactPhone ?? DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void SetActiveStatus(int storeId, bool isActive)
        {
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Stores_SetActiveStatus", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StoreId", storeId);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}