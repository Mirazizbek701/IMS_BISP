using System;

namespace IMS_BISP.DAL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int MinThreshold { get; set; }
        public string Visibility { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
