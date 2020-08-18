using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Api.Application.Dtos
{
    public class CustomerDto
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }

        public CustomerDto(Customer customer)
        {
            CustomerId = customer.CustomerId;
            CompanyName = customer.CompanyName;
            ContactName = customer.ContactName;
            ContactTitle = customer.ContactTitle;
        }
    }
}
