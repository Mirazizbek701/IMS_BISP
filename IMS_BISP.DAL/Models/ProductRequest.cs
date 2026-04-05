using System;

namespace IMS_BISP.DAL.Models
{
    public class ProductRequest
    {
        public int RequestId { get; set; }
        public int RequesterStoreId { get; set; }
        public string RequesterStoreName { get; set; }
        public int SupplierStoreId { get; set; }
        public string SupplierStoreName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public decimal OwnListedPrice { get; set; }
        public int QuantityRequested { get; set; }
        public decimal ProposedPrice { get; set; }
        public string Status { get; set; }
        public string RejectionNote { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RespondedAt { get; set; }
    }
}
