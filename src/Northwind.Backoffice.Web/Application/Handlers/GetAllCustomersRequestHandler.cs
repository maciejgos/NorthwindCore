using MediatR;
using Northwind.Backoffice.Infrastructure.Data;
using Northwind.Backoffice.Web.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Web.Application.Handlers
{
    public class GetAllCustomersRequestHandler : IRequestHandler<GetAllCustomersRequest, IEnumerable<CustomerDto>>
    {
        private readonly NorthwindContext _context;

        public GetAllCustomersRequestHandler(NorthwindContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<CustomerDto>> Handle(GetAllCustomersRequest request, CancellationToken cancellationToken)
        {
            var customers = _context.Customers.Select(c => new CustomerDto(c)).AsEnumerable();

            return Task.FromResult(customers);
        }
    }

    public class GetAllCustomersRequest : IRequest<IEnumerable<CustomerDto>>
    {

    }
}
