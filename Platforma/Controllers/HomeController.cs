using Microsoft.AspNetCore.Mvc;
using Platforma.Data;
using System;

namespace Platforma.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // ¬ыборка данных дл€ отображени€ на главной странице
            var listings = _context.Listings
                .OrderByDescending(l => l.PublishedAt)
                .Take(10)
                .ToList();

            var reviews = _context.Reviews
                .OrderByDescending(r => r.Rating)
                .Take(5)
                .ToList();

            return View(new HomeViewModel
            {
                Listings = listings,
                Reviews = reviews
            });
        }
    }
}

