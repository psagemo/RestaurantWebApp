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

        //[Authorize(Policy = "AdminOnly")]
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }

        //[Authorize(Policy = "AdminOnly")]
        [Authorize(Roles = "Admin")]
        public IActionResult MenuItems()
        {
            return View();
        }

    }
}
