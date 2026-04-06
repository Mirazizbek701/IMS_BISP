namespace IMS_BISP.DAL.Models
{
    public class DashboardStats
    {
        public int TotalProducts { get; set; }
        public int PublicProducts { get; set; }
        public int LowStockCount { get; set; }
        public int PendingIncoming { get; set; }
        public int PendingSent { get; set; }
        public decimal TotalInventoryValue { get; set; }
    }
}
