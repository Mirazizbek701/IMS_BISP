using IMS_BISP.DAL.Models;
using IMS_BISP.DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Data
{
    public static class ContractRepository
    {
        public static List<Contract> GetAll()
        {
            try
            {
                var list = new List<Contract>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Contracts_GetAll", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(ContractMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetAll (Contracts): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Contract GetById(int contractId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Contracts_GetById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ContractId", contractId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) return ContractMapper.Map(reader);
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetById (Contracts): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Contract> GetExpiringSoon()
        {
            try
            {
                var list = new List<Contract>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Contracts_GetExpiringSoon", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(ContractMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetExpiringSoon (Contracts): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(int storeId, DateTime startDate, DateTime endDate, decimal monthlyRent, string contractFile)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Contracts_Insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@MonthlyRent", monthlyRent);
                    cmd.Parameters.AddWithValue("@ContractFile", (object)contractFile ?? DBNull.Value);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Insert (Contracts): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Update(int contractId, int storeId, DateTime startDate, DateTime endDate, decimal monthlyRent, string contractFile)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Contracts_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ContractId", contractId);
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@MonthlyRent", monthlyRent);
                    cmd.Parameters.AddWithValue("@ContractFile", (object)contractFile ?? DBNull.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Update (Contracts): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(int contractId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Contracts_Delete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ContractId", contractId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Delete (Contracts): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
