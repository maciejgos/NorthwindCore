using MediatR;
using Microsoft.AspNetCore.Mvc;
using Northwind.Backoffice.Api.Application.Dtos;
using Northwind.Backoffice.Api.Application.Handlers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Api.Controllers
{
    public class OrdersController : BaseApiController
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> Index()
        {
            var request = new GetAllOrdersRequest();
            var response = await _mediator.Send(request);

            return new OkObjectResult(response);
        }
    }
}
