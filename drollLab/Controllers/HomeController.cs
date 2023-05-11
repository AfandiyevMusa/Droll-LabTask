using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drollLab.Data;
using drollLab.Models;
using drollLab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace drollLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _context.products.Include(m => m.productImages).Where(m => !m.SoftDelete).ToListAsync();

            HomeVM home = new HomeVM()
            {
                products = products
            };
            return View(home);
        }
    }
}

