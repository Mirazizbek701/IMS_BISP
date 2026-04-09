using IMS_BISP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Data
{
    public static class CategoryRepository
    {
        public static List<Category> GetAll()
        {
            try
            {
                var list = new List<Category>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Categories_GetAll", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Category
                        {
                            CategoryId   = (int)reader["CategoryId"],
                            CategoryName = reader["CategoryName"].ToString()
                        });
                    }
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetAll (Categories): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
