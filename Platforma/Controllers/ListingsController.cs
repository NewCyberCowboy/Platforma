using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Platforma.Data;
using Platforma.Models;
using System;
using System.Linq;

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
            var listings = _context.Listings.Include(l => l.Location).ToList();
            return View(listings);
        }

        // Создание объявления
        public IActionResult Create()
        {
            ViewBag.Locations = new SelectList(_context.Locations, "Id", "Name");
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
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Locations = new SelectList(_context.Locations, "Id", "Name");
            return View(listing);
        }

        // Редактирование объявления
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
        public IActionResult Edit(int id, Listing listing)
        {
            if (id != listing.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(listing);
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
            if (listing == null)
            {
                return NotFound();
            }
            _context.Listings.Remove(listing);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
