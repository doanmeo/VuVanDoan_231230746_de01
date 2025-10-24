using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuVanDoan_231230746_de01.Models;

namespace VuVanDoan_231230746_de01.Controllers
{
    public class VvdComputersController : Controller
    {
        private readonly VvdComputerContext _context;

        public VvdComputersController(VvdComputerContext context)
        {
            _context = context;
        }

        // GET: VvdComputers
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.VvdComputer.ToListAsync());
        }

        // GET: VvdComputers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vvdComputer = await _context.VvdComputer
                .FirstOrDefaultAsync(m => m.vvdComId == id);
            if (vvdComputer == null)
            {
                return NotFound();
            }

            return View(vvdComputer);
        }

        // GET: VvdComputers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VvdComputers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("vvdComId,vvdComName,vvdComPrice,vvdComImage,vvdComStatus")] VvdComputer vvdComputer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vvdComputer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vvdComputer);
        }

        // GET: VvdComputers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vvdComputer = await _context.VvdComputer.FindAsync(id);
            if (vvdComputer == null)
            {
                return NotFound();
            }
            return View(vvdComputer);
        }

        // POST: VvdComputers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("vvdComId,vvdComName,vvdComPrice,vvdComImage,vvdComStatus")] VvdComputer vvdComputer)
        {
            if (id != vvdComputer.vvdComId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vvdComputer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VvdComputerExists(vvdComputer.vvdComId))
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
            return View(vvdComputer);
        }

        // GET: VvdComputers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vvdComputer = await _context.VvdComputer
                .FirstOrDefaultAsync(m => m.vvdComId == id);
            if (vvdComputer == null)
            {
                return NotFound();
            }

            return View(vvdComputer);
        }

        // POST: VvdComputers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vvdComputer = await _context.VvdComputer.FindAsync(id);
            if (vvdComputer != null)
            {
                _context.VvdComputer.Remove(vvdComputer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VvdComputerExists(int id)
        {
            return _context.VvdComputer.Any(e => e.vvdComId == id);
        }
    }
}
