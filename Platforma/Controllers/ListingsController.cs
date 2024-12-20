using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Platforma.Data;
using Platforma.Models;
using System;

namespace Platforma.Controllers
{
    public class ListingsController : Controller
    {
        private readonly AppDbContext _context;

        public ListingsController(AppDbContext context)
        {
            _context = context;
        }

        // Список объявлений
        public IActionResult Index()
        {
            var listings = _context.Listings.ToList();
            return View(listings);
        }

        // Создание объявления
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Listing listing)
        {
            if (ModelState.IsValid)
            {
                listing.PublishedAt = DateTime.Now;
                _context.Listings.Add(listing);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(listing);
        }

        // Редактирование объявления
        public IActionResult Edit(int id)
        {
            var listing = _context.Listings.Find(id);
            if (listing == null) return NotFound();
            return View(listing);
        }

        [HttpPost]
        public IActionResult Edit(Listing listing)
        {
            if (ModelState.IsValid)
            {
                _context.Listings.Update(listing);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(listing);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Locations = new SelectList(_context.Locations, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Listing listing)
        {
            if (ModelState.IsValid)
            {
                _context.Listings.Add(listing);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Locations = new SelectList(_context.Locations, "Id", "Name");
            return View(listing);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var listing = _context.Listings.Find(id);
            if (listing == null)
            {
                return NotFound();
            }
            ViewBag.Locations = new SelectList(_context.Locations, "Id", "Name", listing.LocationId);
            return View(listing);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Listing listing)
        {
            if (ModelState.IsValid)
            {
                _context.Listings.Update(listing);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Locations = new SelectList(_context.Locations, "Id", "Name", listing.LocationId);
            return View(listing);
        }
        // Удаление объявления
        public IActionResult Delete(int id)
        {
            var listing = _context.Listings.Find(id);
            if (listing == null) return NotFound();
            _context.Listings.Remove(listing);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ByCategory(int categoryId)
        {
            var listings = _context.Listings
                .Where(l => l.Item.Categories.Any(c => c.Id == categoryId))
                .ToList();
            return View("Index", listings);
        }
    }
}

