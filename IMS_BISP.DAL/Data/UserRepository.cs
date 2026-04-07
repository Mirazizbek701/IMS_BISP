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

        public static User GetById(int userId)
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

        public static User GetByUsername(string username)
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

        public static List<User> GetByStore(int storeId)
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

        public static int Insert(int? storeId, int roleId, string username, string password, string fullName)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Users_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StoreId", (object)storeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void Update(int userId, int? storeId, int roleId, string fullName)
        {
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Users_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@StoreId", (object)storeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdatePassword(int userId, string newPassword)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
            using (var con = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("sp_Users_UpdatePassword", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void SetActiveStatus(int userId, bool isActive)
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

        public static bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}