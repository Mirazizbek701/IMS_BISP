using System;
using System.Data.SqlClient;
using IMS_BISP.DAL.Models;

namespace IMS_BISP.DAL.Mappers
{
    public static class ContractMapper
    {
        public static Contract Map(SqlDataReader reader)
        {
            return new Contract
            {
                ContractId = (int)reader["ContractId"],
                StoreId = (int)reader["StoreId"],
                StoreName = reader["StoreName"].ToString(),
                StartDate = (DateTime)reader["StartDate"],
                EndDate = (DateTime)reader["EndDate"],
                MonthlyRent = (decimal)reader["MonthlyRent"],
                ContractFile = reader.HasColumn("ContractFile") && reader["ContractFile"] != DBNull.Value
                    ? reader["ContractFile"].ToString()
                    : null,
                CreatedAt = (DateTime)reader["CreatedAt"],
                DaysLeft = (int)reader["DaysLeft"]
            };
        }
    }
}
