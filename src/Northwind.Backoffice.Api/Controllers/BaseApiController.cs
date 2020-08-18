using Microsoft.AspNetCore.Mvc;

namespace Northwind.Backoffice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
    }
}
