using System;
using System.Data.SqlClient;
using IMS_BISP.DAL.Data;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Mappers
{
    public static class RequestMapper
    {
        public static ProductRequest Map(SqlDataReader reader)
        {
            return new ProductRequest
            {
                RequestId = (int)reader["RequestId"],
                RequesterStoreName = reader.HasColumn("RequesterStoreName") ? reader["RequesterStoreName"].ToString() : "",
                SupplierStoreName = reader.HasColumn("SupplierStoreName") ? reader["SupplierStoreName"].ToString() : "",
                ProductName = reader["ProductName"].ToString(),
                SKU = reader["SKU"].ToString(),
                OwnListedPrice = reader.HasColumn("OwnListedPrice") ? (decimal)reader["OwnListedPrice"] : 0,
                QuantityRequested = (int)reader["QuantityRequested"],
                ProposedPrice = (decimal)reader["ProposedPrice"],
                Status = reader["Status"].ToString(),
                RejectionNote = reader["RejectionNote"] == DBNull.Value ? "" : reader["RejectionNote"].ToString(),
                CreatedAt = (DateTime)reader["CreatedAt"],
                RespondedAt = reader["RespondedAt"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["RespondedAt"]
            };
        }
    }
}