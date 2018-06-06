using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class VerlagsController : Controller
    {
        private readonly BookContext _context;

        public VerlagsController(BookContext context)
        {
            _context = context;
        }

        // GET: Verlags
        public async Task<IActionResult> Index()
        {
            return View(await _context.Verlag.ToListAsync());
        }

        // GET: Verlags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verlag = await _context.Verlag
                .SingleOrDefaultAsync(m => m.Id == id);
            if (verlag == null)
            {
                return NotFound();
            }

            return View(verlag);
        }

        // GET: Verlags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Verlags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Verlag verlag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(verlag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(verlag);
        }

        // GET: Verlags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verlag = await _context.Verlag.SingleOrDefaultAsync(m => m.Id == id);
            if (verlag == null)
            {
                return NotFound();
            }
            return View(verlag);
        }

        // POST: Verlags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Verlag verlag)
        {
            if (id != verlag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(verlag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VerlagExists(verlag.Id))
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
            return View(verlag);
        }

        // GET: Verlags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verlag = await _context.Verlag
                .SingleOrDefaultAsync(m => m.Id == id);
            if (verlag == null)
            {
                return NotFound();
            }

            return View(verlag);
        }

        // POST: Verlags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var verlag = await _context.Verlag.SingleOrDefaultAsync(m => m.Id == id);
            _context.Verlag.Remove(verlag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VerlagExists(int id)
        {
            return _context.Verlag.Any(e => e.Id == id);
        }
    }
}
