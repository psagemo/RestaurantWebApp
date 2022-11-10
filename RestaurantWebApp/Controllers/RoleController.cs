using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebApp.Controllers
{
    public class RoleController : Controller
    {
        [Authorize(Policy ="AdminOnly")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
