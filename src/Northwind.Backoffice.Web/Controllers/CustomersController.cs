using MediatR;
using Microsoft.AspNetCore.Mvc;
using Northwind.Backoffice.Web.Application.Dtos;
using Northwind.Backoffice.Web.Application.Handlers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Web.Controllers
{
    public class CustomersController : BaseApiController
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> Get()
        {
            var request = new GetAllCustomersRequest();
            var response = await _mediator.Send(request);

            return new OkObjectResult(response);
        }
    }
}
