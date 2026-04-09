using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IMS_BISP.DAL.Mappers;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Data
{
    public static class AuditLogRepository
    {
        public static void Insert(int userId, string actionType, string actionDetail)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Audit_Insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@ActionType", actionType);
                    cmd.Parameters.AddWithValue("@ActionDetail", actionDetail);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Insert (AuditLog): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<AuditLog> GetAll()
        {
            try
            {
                var list = new List<AuditLog>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Audit_GetAll", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(AuditLogMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetAll (AuditLog): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
