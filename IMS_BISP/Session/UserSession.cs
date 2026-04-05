using IMS_BISP.DAL.Models;

namespace IMS_BISP.Session
{
    public static class UserSession
    {
        public static int UserId { get; private set; }
        public static int? StoreId { get; private set; }
        public static string StoreName { get; private set; }
        public static int RoleId { get; private set; }
        public static string RoleName { get; private set; }
        public static string Username { get; private set; }
        public static string FullName { get; private set; }

        public static void Login(User user)
        {
            UserId    = user.UserId;
            StoreId   = user.StoreId;
            StoreName = user.StoreName;
            RoleId    = user.RoleId;
            RoleName  = user.RoleName;
            Username  = user.Username;
            FullName  = user.FullName;
        }

        public static void Clear()
        {
            UserId    = 0;
            StoreId   = null;
            StoreName = null;
            RoleId    = 0;
            RoleName  = null;
            Username  = null;
            FullName  = null;
        }

        public static bool IsAdmin()   => string.Equals(RoleName, "Admin",   System.StringComparison.OrdinalIgnoreCase);
        public static bool IsManager() => string.Equals(RoleName, "Manager", System.StringComparison.OrdinalIgnoreCase);
        public static bool IsStaff()   => string.Equals(RoleName, "Staff",   System.StringComparison.OrdinalIgnoreCase);
    }
}
