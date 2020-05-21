using MediatR;
using Northwind.Backoffice.Api.Application.Dtos;
using Northwind.Backoffice.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Api.Application.Handlers
{
    public class GetAllOrdersRequestHandler : IRequestHandler<GetAllOrdersRequest, IEnumerable<OrderDto>>
    {
        private readonly NorthwindContext _context;

        public GetAllOrdersRequestHandler(NorthwindContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<OrderDto>> Handle(GetAllOrdersRequest request, CancellationToken cancellationToken)
        {
            var orders = _context.Orders.Select(o => new OrderDto(o)).AsEnumerable();
            return Task.FromResult(orders);
        }
    }

    public class GetAllOrdersRequest : IRequest<IEnumerable<OrderDto>>
    {
    }
}
