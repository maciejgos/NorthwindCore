using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Northwind.Backoffice.Web.Application.Handlers;

namespace Northwind.Backoffice.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new GetAllProductsRequest();
            var response = await _mediator.Send(request);

            return View(response);
        }
    }
}