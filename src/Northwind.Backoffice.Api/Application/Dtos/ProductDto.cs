using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Api.Application.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }

        // TODO: Use Automapper
        public ProductDto(Product product)
        {
            ProductId = product.ProductId;
            Name = product.ProductName;
            UnitPrice = product.UnitPrice;
            UnitsInStock = product.UnitsInStock;
            UnitsOnOrder = product.UnitsOnOrder;
        }
    }
}
