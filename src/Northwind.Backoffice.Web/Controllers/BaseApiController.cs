using Microsoft.AspNetCore.Mvc;

namespace Northwind.Backoffice.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
    }
}
