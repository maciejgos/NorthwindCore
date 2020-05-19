using MediatR;
using Northwind.Backoffice.Infrastructure.Data;
using Northwind.Backoffice.Web.Application.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Web.Application.Handlers
{
    public class GetAllProductsRequestHandler : IRequestHandler<GetAllProductsRequest, IEnumerable<ProductDto>>
    {
        private readonly NorthwindContext _context;

        public GetAllProductsRequestHandler(NorthwindContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<ProductDto>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            var products = _context.Products.Select(p => new ProductDto(p)).AsEnumerable();
            return Task.FromResult(products);
        }
    }

    public class GetAllProductsRequest : IRequest<IEnumerable<ProductDto>>
    {
    }
}
