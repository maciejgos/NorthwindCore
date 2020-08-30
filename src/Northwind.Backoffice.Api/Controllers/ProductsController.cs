using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.Backoffice.Api.Application.Dtos;
using Northwind.Backoffice.Api.Application.Handlers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Api.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IMediator mediator, ILogger<ProductsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> Get()
        {
            _logger.LogInformation("Request all products");

            var request = new GetAllProductsRequest();
            var response = await _mediator.Send(request);

            return new OkObjectResult(response);
        }
    }
}