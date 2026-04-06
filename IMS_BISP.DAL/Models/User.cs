namespace IMS_BISP.DAL.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int? StoreId { get; set; }
        public string StoreName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
    }
}
