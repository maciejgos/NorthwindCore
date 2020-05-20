using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Northwind.Backoffice.Web.PageModels
{
    public class PrivacyModel : PageModel
    {
        public ActionResult OnGet()
        {
            return Page();
        }
    }
}
