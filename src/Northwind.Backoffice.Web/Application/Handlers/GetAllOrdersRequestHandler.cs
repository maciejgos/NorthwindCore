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
    public class GetAllOrdersRequestHandler : IRequestHandler<GetAllOrdersRequest, IEnumerable<Order>>
    {
        private readonly NorthwindContext _context;

        public GetAllOrdersRequestHandler(NorthwindContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Order>> Handle(GetAllOrdersRequest request, CancellationToken cancellationToken)
        {
            var orders = _context.Orders.AsEnumerable();
            return Task.FromResult(orders);
        }
    }

    public class GetAllOrdersRequest : IRequest<IEnumerable<Order>>
    {
    }
}
