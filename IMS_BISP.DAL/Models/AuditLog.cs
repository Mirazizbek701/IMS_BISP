using System;

namespace IMS_BISP.DAL.Models
{
    public class AuditLog
    {
        public int LogId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string ActionType { get; set; }
        public string ActionDetail { get; set; }
        public DateTime LoggedAt { get; set; }
    }
}
