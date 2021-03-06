using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SDTD_Web_APP.Models;

namespace SDTD_Web_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly SDTDContext _context;

        public StudentsController(SDTDContext context)
        {
            _context = context;
        }

        // GET: All Students
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok(await _context.Students.ToListAsync());
        }

        // GET: One Student
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        // POST: Add a student
        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            if (ModelState.IsValid)
            {
                var exists = _context.Students.Any(x => x.Email == student.Email);
                if (exists) return BadRequest("Student already exists");
                _context.Add(student);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest("Invalid data");
        }


        // PUT: Edit a student
        [HttpPut("{id}")]
        public async Task<IActionResult> EditStudent(int? id, [FromBody] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                    return Ok("Updated successfully");
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
            }

            return BadRequest();
        }


        // Delete: Delete a student
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            try
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return Ok("Deleted successfully");
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest("Could not complete");
            }
        }
    }
}
