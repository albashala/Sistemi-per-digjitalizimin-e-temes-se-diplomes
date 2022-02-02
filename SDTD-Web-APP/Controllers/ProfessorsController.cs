﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using SDTD_Web_APP.Models;

namespace SDTD_Web_APP.Controllers
{
    [Route("api/[controller]")]
    public class ProfessorsController : Controller
    {
        private readonly SDTDContext _context;

        public ProfessorsController(SDTDContext context)
        {
            _context = context;
        }

        // GET: Professors
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.Professors.ToListAsync());
        }

        //// POST
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([FromBody]Professor professor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(professor);
        //        await _context.SaveChangesAsync();
        //        return Ok();
        //    }

        //}

        // GET: Professors/Details/5
            //        public async Task<IActionResult> Details(int? id)
            //        {
            //            if (id == null)
            //            {
            //                return NotFound();
            //            }

            //            var professor = await _context.Professors
            //                .FirstOrDefaultAsync(m => m.Id == id);
            //            if (professor == null)
            //            {
            //                return NotFound();
            //            }

            //            return View(professor);
            //        }

            //        // GET: Professors/Create
            //        public IActionResult Create()
            //        {
            //            return View();
            //        }

            //        // POST: Professors/Create
            //        // To protect from overposting attacks, enable the specific properties you want to bind to.
            //        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public async Task<IActionResult> Create([Bind("Id,Emri,Mbiemri,Email,Password,DOB,Titulli,IsAvailable")] Professor professor)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        _context.Add(professor);
            //        await _context.SaveChangesAsync();
            //        return Ok();
            //    }

            //    return BadRequest("Invalid data");

            //}

            //        // GET: Professors/Edit/5
            //        public async Task<IActionResult> Edit(int? id)
            //        {
            //            if (id == null)
            //            {
            //                return NotFound();
            //            }

            //            var professor = await _context.Professors.FindAsync(id);
            //            if (professor == null)
            //            {
            //                return NotFound();
            //            }
            //            return View(professor);
            //        }

            //        // POST: Professors/Edit/5
            //        // To protect from overposting attacks, enable the specific properties you want to bind to.
            //        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            //        [HttpPost]
            //        [ValidateAntiForgeryToken]
            //        public async Task<IActionResult> Edit(int id, [Bind("Id,Emri,Mbiemri,Email,Password,DOB,Titulli,IsAvailable")] Professor professor)
            //        {
            //            if (id != professor.Id)
            //            {
            //                return NotFound();
            //            }

            //            if (ModelState.IsValid)
            //            {
            //                try
            //                {
            //                    _context.Update(professor);
            //                    await _context.SaveChangesAsync();
            //                }
            //                catch (DbUpdateConcurrencyException)
            //                {
            //                    if (!ProfessorExists(professor.Id))
            //                    {
            //                        return NotFound();
            //                    }
            //                    else
            //                    {
            //                        throw;
            //                    }
            //                }
            //                return RedirectToAction(nameof(Index));
            //            }
            //            return View(professor);
            //        }

            //        // GET: Professors/Delete/5
            //        public async Task<IActionResult> Delete(int? id)
            //        {
            //            if (id == null)
            //            {
            //                return NotFound();
            //            }

            //            var professor = await _context.Professors
            //                .FirstOrDefaultAsync(m => m.Id == id);
            //            if (professor == null)
            //            {
            //                return NotFound();
            //            }

            //            return View(professor);
            //        }

            //        // POST: Professors/Delete/5
            //        [HttpPost, ActionName("Delete")]
            //        [ValidateAntiForgeryToken]
            //        public async Task<IActionResult> DeleteConfirmed(int id)
            //        {
            //            var professor = await _context.Professors.FindAsync(id);
            //            _context.Professors.Remove(professor);
            //            await _context.SaveChangesAsync();
            //            return RedirectToAction(nameof(Index));
            //        }

            //        private bool ProfessorExists(int id)
            //        {
            //            return _context.Professors.Any(e => e.Id == id);
            //        }
            //    }
        }
    }