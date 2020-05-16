using MediatR;
using Northwind.Backoffice.Core.Entities;
using Northwind.Backoffice.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Web.Application.Handlers
{
    public class GetAllCustomersRequestHandler : IRequestHandler<GetAllCustomersRequest, IEnumerable<Customers>>
    {
        private readonly NorthwindContext _context;

        public GetAllCustomersRequestHandler(NorthwindContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Customers>> Handle(GetAllCustomersRequest request, CancellationToken cancellationToken)
        {
            var customers = _context.Customers.AsEnumerable();

            return Task.FromResult(customers);
        }
    }

    public class GetAllCustomersRequest : IRequest<IEnumerable<Customers>>
    {

    }
}
