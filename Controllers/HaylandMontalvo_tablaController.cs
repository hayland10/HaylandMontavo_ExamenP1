using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HaylandMontavo_ExamenP1.Data;
using HaylandMontavo_ExamenP1.Models;

namespace HaylandMontavo_ExamenP1.Controllers
{
    public class HaylandMontalvo_tablaController : Controller
    {
        private readonly HaylandMontavo_ExamenP1Context _context;

        public HaylandMontalvo_tablaController(HaylandMontavo_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: HaylandMontalvo_tabla
        public async Task<IActionResult> Index()
        {
              return _context.HaylandMontalvo_tabla != null ? 
                          View(await _context.HaylandMontalvo_tabla.ToListAsync()) :
                          Problem("Entity set 'HaylandMontavo_ExamenP1Context.HaylandMontalvo_tabla'  is null.");
        }

        // GET: HaylandMontalvo_tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HaylandMontalvo_tabla == null)
            {
                return NotFound();
            }

            var haylandMontalvo_tabla = await _context.HaylandMontalvo_tabla
                .FirstOrDefaultAsync(m => m.IdMonster == id);
            if (haylandMontalvo_tabla == null)
            {
                return NotFound();
            }

            return View(haylandMontalvo_tabla);
        }

        // GET: HaylandMontalvo_tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HaylandMontalvo_tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMonster,hmDateTime,hmNombre,hmNumeroMonsters,hmPrecio,hmPrimeraVez")] HaylandMontalvo_tabla haylandMontalvo_tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(haylandMontalvo_tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(haylandMontalvo_tabla);
        }

        // GET: HaylandMontalvo_tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HaylandMontalvo_tabla == null)
            {
                return NotFound();
            }

            var haylandMontalvo_tabla = await _context.HaylandMontalvo_tabla.FindAsync(id);
            if (haylandMontalvo_tabla == null)
            {
                return NotFound();
            }
            return View(haylandMontalvo_tabla);
        }

        // POST: HaylandMontalvo_tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMonster,hmDateTime,hmNombre,hmNumeroMonsters,hmPrecio,hmPrimeraVez")] HaylandMontalvo_tabla haylandMontalvo_tabla)
        {
            if (id != haylandMontalvo_tabla.IdMonster)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(haylandMontalvo_tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HaylandMontalvo_tablaExists(haylandMontalvo_tabla.IdMonster))
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
            return View(haylandMontalvo_tabla);
        }

        // GET: HaylandMontalvo_tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HaylandMontalvo_tabla == null)
            {
                return NotFound();
            }

            var haylandMontalvo_tabla = await _context.HaylandMontalvo_tabla
                .FirstOrDefaultAsync(m => m.IdMonster == id);
            if (haylandMontalvo_tabla == null)
            {
                return NotFound();
            }

            return View(haylandMontalvo_tabla);
        }

        // POST: HaylandMontalvo_tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HaylandMontalvo_tabla == null)
            {
                return Problem("Entity set 'HaylandMontavo_ExamenP1Context.HaylandMontalvo_tabla'  is null.");
            }
            var haylandMontalvo_tabla = await _context.HaylandMontalvo_tabla.FindAsync(id);
            if (haylandMontalvo_tabla != null)
            {
                _context.HaylandMontalvo_tabla.Remove(haylandMontalvo_tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HaylandMontalvo_tablaExists(int id)
        {
          return (_context.HaylandMontalvo_tabla?.Any(e => e.IdMonster == id)).GetValueOrDefault();
        }
    }
}
