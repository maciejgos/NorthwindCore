namespace Northwind.Backoffice.Core.Entities
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public decimal UnitPrice { get; set; }
        public uint Quantity { get; set; }
        public float Discount { get; set; }
    }
}