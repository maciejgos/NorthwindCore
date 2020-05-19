using Northwind.Backoffice.Core.Entities;
using System;

namespace Northwind.Backoffice.Web.Application.Dtos
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public OrderDto(Order order)
        {
            OrderId = order.OrderId;
            OrderDate = order.OrderDate;
            RequiredDate = order.RequiredDate;
            ShippedDate = order.ShippedDate;
            ShipName = order.ShipName;
            ShipAddress = order.ShipAddress;
            ShipCity = order.ShipCity;
            ShipRegion = order.ShipRegion;
            ShipPostalCode = order.ShipPostalCode;
            ShipCountry = order.ShipCountry;
        }
    }
}
