using MediatR;
using Microsoft.AspNetCore.Mvc;
using Northwind.Backoffice.Web.Application.Handlers;
using System.Threading.Tasks;

namespace Northwind.Backoffice.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new GetAllCustomersRequest();
            var response = await _mediator.Send(request);

            return View(response);
        }
    }
}
