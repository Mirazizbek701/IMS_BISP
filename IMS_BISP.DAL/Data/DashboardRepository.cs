using System;
using System.Data;
using System.Data.SqlClient;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Data
{
    public static class DashboardRepository
    {
        public static DashboardStats GetStoreStats(int storeId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Dashboard_GetStoreStats", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new DashboardStats
                        {
                            TotalProducts      = (int)reader["TotalProducts"],
                            PublicProducts     = (int)reader["PublicProducts"],
                            LowStockCount      = (int)reader["LowStockCount"],
                            PendingIncoming    = (int)reader["PendingIncoming"],
                            PendingSent        = (int)reader["PendingSent"],
                            TotalInventoryValue = (decimal)reader["TotalInventoryValue"]
                        };
                    }
                }
                return new DashboardStats();
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetStoreStats: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static AdminStats GetAdminStats()
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Dashboard_GetAdminStats", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new AdminStats
                        {
                            TotalActiveStores    = (int)reader["TotalActiveStores"],
                            TotalActiveUsers     = (int)reader["TotalActiveUsers"],
                            TotalProducts        = (int)reader["TotalProducts"],
                            TotalPendingRequests = (int)reader["TotalPendingRequests"]
                        };
                    }
                }
                return new AdminStats();
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetAdminStats: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static RequestStats GetRequestStats(int storeId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Dashboard_GetRequestStats", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new RequestStats
                        {
                            AcceptedCount = (int)reader["AcceptedCount"],
                            RejectedCount = (int)reader["RejectedCount"]
                        };
                    }
                }
                return new RequestStats();
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetRequestStats: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DateTime? GetLastInventoryUpdate(int storeId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Dashboard_GetLastInventoryUpdate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var val = reader["UpdatedAt"];
                        return val == DBNull.Value ? (DateTime?)null : (DateTime)val;
                    }
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetLastInventoryUpdate: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static decimal GetTotalInventoryValue()
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Dashboard_GetTotalInventoryValue", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var result = cmd.ExecuteScalar();
                    return result == null || result == DBNull.Value ? 0m : Convert.ToDecimal(result);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetTotalInventoryValue: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static BusiestStore GetBusiestStore()
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Dashboard_GetBusiestStore", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new BusiestStore
                        {
                            StoreName     = reader["StoreName"].ToString(),
                            TotalRequests = (int)reader["TotalRequests"]
                        };
                    }
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetBusiestStore: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
