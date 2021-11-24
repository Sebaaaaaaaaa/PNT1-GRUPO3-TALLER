using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Taller.Context;
using Taller.Models;

namespace Taller.Controllers
{
    public class AutoARepararController : Controller
    {
        private readonly TallerDBContext _context;

        public AutoARepararController(TallerDBContext context)
        {
            _context = context;
        }

        // GET: AutoAReparar
        public async Task<IActionResult> Index()
        {
            return View(await _context.AutosAReparar.ToListAsync());
        }

        // GET: AutoAReparar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoAReparar = await _context.AutosAReparar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autoAReparar == null)
            {
                return NotFound();
            }

            return View(autoAReparar);
        }

        // GET: AutoAReparar/Create
        public IActionResult Create()
        {
            ViewBag.Patentes = new SelectList(_context.Clientes.ToList(), "Patente", "Patente");
            return View();
        }

        // POST: AutoAReparar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Patente,Marca,Modelo")] AutoAReparar autoAReparar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoAReparar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autoAReparar);
        }

        // GET: AutoAReparar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoAReparar = await _context.AutosAReparar.FindAsync(id);
            if (autoAReparar == null)
            {
                return NotFound();
            }
            ViewBag.Patentes = new SelectList(_context.Clientes.ToList(), "Patente", "Patente");
            return View(autoAReparar);
        }

        // POST: AutoAReparar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Patente,Marca,Modelo")] AutoAReparar autoAReparar)
        {
            if (id != autoAReparar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autoAReparar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoARepararExists(autoAReparar.Id))
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
            return View(autoAReparar);
        }

        // GET: AutoAReparar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autoAReparar = await _context.AutosAReparar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autoAReparar == null)
            {
                return NotFound();
            }

            return View(autoAReparar);
        }

        // POST: AutoAReparar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autoAReparar = await _context.AutosAReparar.FindAsync(id);
            _context.AutosAReparar.Remove(autoAReparar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoARepararExists(int id)
        {
            return _context.AutosAReparar.Any(e => e.Id == id);
        }
    }
}
