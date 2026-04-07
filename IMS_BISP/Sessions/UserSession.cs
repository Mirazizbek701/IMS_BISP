using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_BISP.Sessions
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static int? StoreId { get; set; }
        public static string StoreName { get; set; }
        public static int RoleId { get; set; }
        public static string RoleName { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }

        public static bool IsAdmin() => RoleName == "SuperAdmin";
        public static bool IsManager() => RoleName == "StoreManager";
        public static bool IsStaff() => RoleName == "StoreStaff";

        public static void Clear()
        {
            UserId = 0;
            StoreId = null;
            StoreName = null;
            RoleId = 0;
            RoleName = null;
            Username = null;
            FullName = null;
        }
    }
}
