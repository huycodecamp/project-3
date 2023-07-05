using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DEMO_PROJECT_C2108G3_Delivery.Data;
using DEMO_PROJECT_C2108G3_Delivery.Models;

namespace DEMO_PROJECT_C2108G3_Delivery.Controllers
{
    public class TrackingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrackingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trackings
        public async Task<IActionResult> Index()
        {
            var postalList = _context.PostalServices.ToList();
            ViewBag.PostalServices = postalList;
              return _context.Trackings != null ? 
                          View(await _context.Trackings.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Trackings'  is null.");
        }

        // GET: Trackings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Trackings == null)
            {
                return NotFound();
            }

            var tracking = await _context.Trackings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tracking == null)
            {
                return NotFound();
            }

            return View(tracking);
        }

        // GET: Trackings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trackings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,LoaiId,TrangThaiId,NgayTao,IdNguoiTao,NgaySua,IdNguoiSua,IsDelete,NgayXoa")] Tracking tracking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tracking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tracking);
        }

        // GET: Trackings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Trackings == null)
            {
                return NotFound();
            }

            var tracking = await _context.Trackings.FindAsync(id);
            if (tracking == null)
            {
                return NotFound();
            }
            return View(tracking);
        }

        // POST: Trackings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,LoaiId,TrangThaiId,NgayTao,IdNguoiTao,NgaySua,IdNguoiSua,IsDelete,NgayXoa")] Tracking tracking)
        {
            if (id != tracking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tracking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrackingExists(tracking.Id))
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
            return View(tracking);
        }

        // GET: Trackings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Trackings == null)
            {
                return NotFound();
            }

            var tracking = await _context.Trackings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tracking == null)
            {
                return NotFound();
            }

            return View(tracking);
        }

        // POST: Trackings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Trackings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Trackings'  is null.");
            }
            var tracking = await _context.Trackings.FindAsync(id);
            if (tracking != null)
            {
                _context.Trackings.Remove(tracking);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrackingExists(int id)
        {
          return (_context.Trackings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
