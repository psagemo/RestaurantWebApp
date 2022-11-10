using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebApp.Controllers
{
    public class RoleController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "AdminOnly")]
        public IActionResult Admin()
        {
            return View();
        }

    }
}
