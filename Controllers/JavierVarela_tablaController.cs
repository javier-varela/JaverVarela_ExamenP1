using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JaverVarela_ExamenP1.Models;

namespace JaverVarela_ExamenP1.Controllers
{
    public class JavierVarela_tablaController : Controller
    {
        private readonly JaverVarela_ExamenP1Context _context;

        public JavierVarela_tablaController(JaverVarela_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: JavierVarela_tabla
        public async Task<IActionResult> Index()
        {
              return _context.JavierVarela_tabla != null ? 
                          View(await _context.JavierVarela_tabla.ToListAsync()) :
                          Problem("Entity set 'JaverVarela_ExamenP1Context.JavierVarela_tabla'  is null.");
        }

        // GET: JavierVarela_tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.JavierVarela_tabla == null)
            {
                return NotFound();
            }

            var javierVarela_tabla = await _context.JavierVarela_tabla
                .FirstOrDefaultAsync(m => m.JVId == id);
            if (javierVarela_tabla == null)
            {
                return NotFound();
            }

            return View(javierVarela_tabla);
        }

        // GET: JavierVarela_tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JavierVarela_tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JVId,JVDescripcion,JVNota,JVIsTrue,JVFecha")] JavierVarela_tabla javierVarela_tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(javierVarela_tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(javierVarela_tabla);
        }

        // GET: JavierVarela_tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.JavierVarela_tabla == null)
            {
                return NotFound();
            }

            var javierVarela_tabla = await _context.JavierVarela_tabla.FindAsync(id);
            if (javierVarela_tabla == null)
            {
                return NotFound();
            }
            return View(javierVarela_tabla);
        }

        // POST: JavierVarela_tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JVId,JVDescripcion,JVNota,JVIsTrue,JVFecha")] JavierVarela_tabla javierVarela_tabla)
        {
            if (id != javierVarela_tabla.JVId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(javierVarela_tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JavierVarela_tablaExists(javierVarela_tabla.JVId))
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
            return View(javierVarela_tabla);
        }

        // GET: JavierVarela_tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.JavierVarela_tabla == null)
            {
                return NotFound();
            }

            var javierVarela_tabla = await _context.JavierVarela_tabla
                .FirstOrDefaultAsync(m => m.JVId == id);
            if (javierVarela_tabla == null)
            {
                return NotFound();
            }

            return View(javierVarela_tabla);
        }

        // POST: JavierVarela_tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.JavierVarela_tabla == null)
            {
                return Problem("Entity set 'JaverVarela_ExamenP1Context.JavierVarela_tabla'  is null.");
            }
            var javierVarela_tabla = await _context.JavierVarela_tabla.FindAsync(id);
            if (javierVarela_tabla != null)
            {
                _context.JavierVarela_tabla.Remove(javierVarela_tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JavierVarela_tablaExists(int id)
        {
          return (_context.JavierVarela_tabla?.Any(e => e.JVId == id)).GetValueOrDefault();
        }
    }
}
