using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_First.Data;
using Web_First.Models;

namespace Web_First.Controllers
{
    public class ProductController : Controller
    {
        private readonly Web_FirstContext _context;

        public ProductController(Web_FirstContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            return View(await _context.San_Pham.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var san_Pham = await _context.San_Pham
                .FirstOrDefaultAsync(m => m.Id_SP == id);
            if (san_Pham == null)
            {
                return NotFound();
            }

            return View(san_Pham);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_SP,Loai_SP_1,Loai_SP_2,Name_SP,Price_SP,Mo_Ta")] San_Pham san_Pham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(san_Pham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(san_Pham);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var san_Pham = await _context.San_Pham.FindAsync(id);
            if (san_Pham == null)
            {
                return NotFound();
            }
            return View(san_Pham);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_SP,Loai_SP_1,Loai_SP_2,Name_SP,Price_SP,Mo_Ta")] San_Pham san_Pham)
        {
            if (id != san_Pham.Id_SP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(san_Pham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!San_PhamExists(san_Pham.Id_SP))
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
            return View(san_Pham);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var san_Pham = await _context.San_Pham
                .FirstOrDefaultAsync(m => m.Id_SP == id);
            if (san_Pham == null)
            {
                return NotFound();
            }

            return View(san_Pham);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var san_Pham = await _context.San_Pham.FindAsync(id);
            _context.San_Pham.Remove(san_Pham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool San_PhamExists(string id)
        {
            return _context.San_Pham.Any(e => e.Id_SP == id);
        }
    }
}
