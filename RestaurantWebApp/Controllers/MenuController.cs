using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantWebApp.Areas.Identity.Data;
using RestaurantWebApp.Models;

namespace RestaurantWebApp.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Menu
        public async Task<IActionResult> Index()
        {
              return View(await _context.MenuItem.ToListAsync());
        }

        private bool MenuItemExists(int id)
        {
          return _context.MenuItem.Any(e => e.MenuItemId == id);
        }
    }
}
