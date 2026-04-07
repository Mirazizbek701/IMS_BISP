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
                        TotalProducts = (int)reader["TotalProducts"],
                        PublicProducts = (int)reader["PublicProducts"],
                        LowStockCount = (int)reader["LowStockCount"],
                        PendingIncoming = (int)reader["PendingIncoming"],
                        PendingSent = (int)reader["PendingSent"],
                        TotalInventoryValue = (decimal)reader["TotalInventoryValue"]
                    };
                }
            }
            return new DashboardStats();
        }

        public static AdminStats GetAdminStats()
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
                        TotalActiveStores = (int)reader["TotalActiveStores"],
                        TotalActiveUsers = (int)reader["TotalActiveUsers"],
                        TotalProducts = (int)reader["TotalProducts"],
                        TotalPendingRequests = (int)reader["TotalPendingRequests"]
                    };
                }
            }
            return new AdminStats();
        }
    }
}