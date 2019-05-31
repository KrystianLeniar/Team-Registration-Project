using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamRegistration.Models;

namespace TeamRegistration.Controllers
{
    public class TeamsController : Controller
    {
        private readonly TeamsContext _context;

        public TeamsController(TeamsContext context)
        {
            _context = context;
        }

        // GET: Teams
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teams.ToListAsync());
        }

        // GET: Teams/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Teams());
            else
                return View(_context.Teams.Find(id));
        }

        // POST: Teams/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("TeamsId,TeamName,LeaderName,CallNumber,TeamLocation")] Teams teams)
        {
            if (ModelState.IsValid)
            {
                if (teams.TeamsId == 0)
                    _context.Add(teams);
                else
                    _context.Update(teams);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teams);
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var teams = await _context.Teams.FindAsync(id);
            _context.Teams.Remove(teams);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
