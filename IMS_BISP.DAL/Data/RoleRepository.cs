using IMS_BISP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IMS_BISP.DAL.Data
{
    public static class RoleRepository
    {
        public static List<Role> GetNonAdmin()
        {
            try
            {
                var list = new List<Role>();
                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("sp_Roles_GetAll", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var roleName = reader["RoleName"].ToString();
                        if (roleName == "SuperAdmin") continue;
                        list.Add(new Role
                        {
                            RoleId   = (int)reader["RoleId"],
                            RoleName = roleName
                        });
                    }
                }
                return list;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error in GetNonAdmin (Roles): " + ex.Message, ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
