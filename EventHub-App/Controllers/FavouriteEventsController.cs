using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventHub_App.Data;
using EventHub_App.Models;
using Microsoft.AspNetCore.Authorization;

namespace EventHub_App.Controllers
{
    public class FavouriteEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FavouriteEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FavouriteEvents
        [Authorize]
        public async Task<IActionResult> Index()
        {
              return View(await _context.FavouriteEvent.ToListAsync());
        }

        // GET: FavouriteEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FavouriteEvent == null)
            {
                return NotFound();
            }

            var favouriteEvent = await _context.FavouriteEvent
                .FirstOrDefaultAsync(m => m.id == id);
            if (favouriteEvent == null)
            {
                return NotFound();
            }

            return View(favouriteEvent);
        }

        // GET: FavouriteEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FavouriteEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]

        public async Task<IActionResult> Create([Bind("id,FavouriteEventName,FavouriteEventDate,FavouriteEventTime,FavouriteEventPriceMin,FavouriteEventPriceMax,FavouriteEventPriceCurrency,FavouriteEventUrl,FavouriteEventVenue")] FavouriteEvent favouriteEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(favouriteEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(favouriteEvent);
        }

        // GET: FavouriteEvents/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FavouriteEvent == null)
            {
                return NotFound();
            }

            var favouriteEvent = await _context.FavouriteEvent.FindAsync(id);
            if (favouriteEvent == null)
            {
                return NotFound();
            }
            return View(favouriteEvent);
        }

        // POST: FavouriteEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,FavouriteEventName,FavouriteEventDate,FavouriteEventTime,FavouriteEventPriceMin,FavouriteEventPriceMax,FavouriteEventPriceCurrency,FavouriteEventUrl,FavouriteEventVenue")] FavouriteEvent favouriteEvent)
        {
            if (id != favouriteEvent.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favouriteEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavouriteEventExists(favouriteEvent.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(favouriteEvent);
        }

        // GET: FavouriteEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FavouriteEvent == null)
            {
                return NotFound();
            }

            var favouriteEvent = await _context.FavouriteEvent
                .FirstOrDefaultAsync(m => m.id == id);
            if (favouriteEvent == null)
            {
                return NotFound();
            }

            return View(favouriteEvent);
        }

        // POST: FavouriteEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FavouriteEvent == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FavouriteEvent'  is null.");
            }
            var favouriteEvent = await _context.FavouriteEvent.FindAsync(id);
            if (favouriteEvent != null)
            {
                _context.FavouriteEvent.Remove(favouriteEvent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavouriteEventExists(int id)
        {
          return _context.FavouriteEvent.Any(e => e.id == id);
        }
    }
}
