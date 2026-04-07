using IMS_BISP.DAL.Models;
using IMS_BISP.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Data
{
    public static class StoreRepository
    {
        public static List<Store> GetAll()
        {
            try
            {
                var list = new List<Store>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Stores_GetAll", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(StoreMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetAll (Stores): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Store> GetAllActive()
        {
            try
            {
                var list = new List<Store>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Stores_GetAllActive", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(StoreMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetAllActive (Stores): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Store GetById(int storeId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Stores_GetById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) return StoreMapper.Map(reader);
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetById (Stores): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(string storeName, string contactPhone)
        {
            try
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
            catch (SqlException ex)
            {
                throw new Exception("Database error in Insert (Stores): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Update(int storeId, string storeName, string contactPhone)
        {
            try
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
            catch (SqlException ex)
            {
                throw new Exception("Database error in Update (Stores): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SetActiveStatus(int storeId, bool isActive)
        {
            try
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
            catch (SqlException ex)
            {
                throw new Exception("Database error in SetActiveStatus (Stores): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
