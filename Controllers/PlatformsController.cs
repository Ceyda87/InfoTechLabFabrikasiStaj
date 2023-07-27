using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InfoTechLabProjeFabrikasi.Data;
using InfoTechLabProjeFabrikasi.Models;

namespace InfoTechLabProjeFabrikasi.Controllers
{
    public class PlatformsController : Controller
    {
        private readonly InfoTechLabContext _context;

        public PlatformsController(InfoTechLabContext context)
        {
            _context = context;
        }

        // GET: Platforms
        public async Task<IActionResult> Index()
        {
            var lst_platform = from plt in _context.Platforms
                               .Include(p => p.Category)
                               .Include(p => p.Customer)
                               .Include(p => p.Expert)
                               select new PlatformViewModel()
                               {
                                   Id= plt.Id,
                                   Name= plt.Name,
                                   Expert= plt.Expert.FullName,
                                   Customer=plt.Customer.Name,
                                   Category= plt.Category.Name


                               };
            return View(await lst_platform.ToListAsync());
        }

        // GET: Platforms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Platforms == null)
            {
                return NotFound();
            }

            var platform = await _context.Platforms
                .Include(p => p.Category)
                .Include(p => p.Customer)
                .Include(p => p.Expert)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (platform == null)
            {
                return NotFound();
            }

            return View(platform);
        }

        // GET: Platforms/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", "PhoneNumber", "EMail");
            ViewData["ExpertId"] = new SelectList(_context.Experts, "Id", "FullName", "EMail", "PhoneNumber");
            return View();
        }

        // POST: Platforms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,CategoryId,ExpertId,CustomerId,Id")] Platform platform)
        {
            if (ModelState.IsValid)
            {
                _context.Add(platform);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", platform.CategoryId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", platform.CustomerId);
            ViewData["ExpertId"] = new SelectList(_context.Experts, "Id", "FullName", platform.ExpertId);
            return View(platform);
        }

        // GET: Platforms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Platforms == null)
            {
                return NotFound();
            }

            var platform = await _context.Platforms.FindAsync(id);
            if (platform == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", platform.CategoryId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", platform.CustomerId);
            ViewData["ExpertId"] = new SelectList(_context.Experts, "Id", "FullName", platform.ExpertId);
            return View(platform);
        }

        // POST: Platforms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,CategoryId,ExpertId,CustomerId,Id")] Platform platform)
        {
            if (id != platform.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(platform);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlatformExists(platform.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", platform.CategoryId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", platform.CustomerId);
            ViewData["ExpertId"] = new SelectList(_context.Experts, "Id", "FullName", platform.ExpertId);
            return View(platform);
        }

        // GET: Platforms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Platforms == null)
            {
                return NotFound();
            }

            var platform = await _context.Platforms
                .Include(p => p.Category)
                .Include(p => p.Customer)
                .Include(p => p.Expert)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (platform == null)
            {
                return NotFound();
            }

            return View(platform);
        }

        // POST: Platforms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Platforms == null)
            {
                return Problem("Entity set 'InfoTechLabContext.Platform'  is null.");
            }
            var platform = await _context.Platforms.FindAsync(id);
            if (platform != null)
            {
                _context.Platforms.Remove(platform);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlatformExists(int id)
        {
          return (_context.Platforms?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
