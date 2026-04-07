using IMS_BISP.DAL.Models;
using IMS_BISP.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Data
{
    public static class UserRepository
    {
        public static List<User> GetAll()
        {
            try
            {
                var list = new List<User>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Users_GetAll", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(UserMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetAll (Users): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static User GetById(int userId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Users_GetById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) return UserMapper.Map(reader);
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetById (Users): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static User GetByUsername(string username)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Users_GetByUsername", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) return UserMapper.Map(reader);
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetByUsername: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<User> GetByStore(int storeId)
        {
            try
            {
                var list = new List<User>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Users_GetByStore", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(UserMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetByStore (Users): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(int? storeId, int roleId, string username, string password, string fullName)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Users_Insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", (object)storeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoleId", roleId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Insert (Users): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdatePassword(int userId, string newPassword)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Users_UpdatePassword", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@PasswordHash", newPassword);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in UpdatePassword: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            return password == passwordHash;
        }

        public static void SetActiveStatus(int userId, bool isActive)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Users_SetActiveStatus", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in SetActiveStatus (Users): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
