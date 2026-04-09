using System;

namespace IMS_BISP.DAL.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MonthlyRent { get; set; }
        public string ContractFile { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DaysLeft { get; set; }
    }
}
