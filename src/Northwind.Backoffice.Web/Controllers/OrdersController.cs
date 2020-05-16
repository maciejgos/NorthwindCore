using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Northwind.Backoffice.Web.Application.Handlers;

namespace Northwind.Backoffice.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new GetAllOrdersRequest();
            var response = await _mediator.Send(request);

            return View(response);
        }
    }
}
