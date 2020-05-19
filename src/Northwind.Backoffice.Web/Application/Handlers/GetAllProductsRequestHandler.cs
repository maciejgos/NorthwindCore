using MediatR;
using Northwind.Backoffice.Core.Entities;
using Northwind.Backoffice.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Web.Application.Handlers
{
    public class GetAllProductsRequestHandler : IRequestHandler<GetAllProductsRequest, IEnumerable<Product>>
    {
        private readonly NorthwindContext _context;

        public GetAllProductsRequestHandler(NorthwindContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Product>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            var products = _context.Products.AsEnumerable();
            return Task.FromResult(products);
        }
    }

    public class GetAllProductsRequest : IRequest<IEnumerable<Product>>
    {
    }
}
