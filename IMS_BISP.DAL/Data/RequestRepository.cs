using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IMS_BISP.DAL.Mappers;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Data
{
    public static class RequestRepository
    {
        public static List<ProductRequest> GetByRequester(int requesterStoreId)
        {
            try
            {
                var list = new List<ProductRequest>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Requests_GetByRequester", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequesterStoreId", requesterStoreId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(RequestMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetByRequester: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ProductRequest> GetBySupplier(int supplierStoreId)
        {
            try
            {
                var list = new List<ProductRequest>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Requests_GetBySupplier", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierStoreId", supplierStoreId);
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        list.Add(RequestMapper.Map(reader));
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetBySupplier: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int GetPendingCount(int supplierStoreId)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Requests_GetPendingCount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierStoreId", supplierStoreId);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetPendingCount: " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int Insert(int requesterStoreId, int supplierStoreId,
            int productId, int quantityRequested, decimal proposedPrice)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Requests_Insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequesterStoreId", requesterStoreId);
                    cmd.Parameters.AddWithValue("@SupplierStoreId", supplierStoreId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@QuantityRequested", quantityRequested);
                    cmd.Parameters.AddWithValue("@ProposedPrice", proposedPrice);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Insert (Requests): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Respond(int requestId, string status, string rejectionNote)
        {
            try
            {
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Requests_Respond", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RequestId", requestId);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@RejectionNote", (object)rejectionNote ?? DBNull.Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in Respond (Requests): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
