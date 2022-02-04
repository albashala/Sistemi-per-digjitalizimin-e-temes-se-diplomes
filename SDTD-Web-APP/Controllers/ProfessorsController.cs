using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDTD_Web_APP.Models;

namespace SDTD_Web_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorsController : Controller
    {
        private readonly SDTDContext _context;

        public ProfessorsController(SDTDContext context)
        {
            _context = context;
        }

        // GET: All Professors
        [HttpGet]
        public async Task<IActionResult> GetAllProfessors()
        {
            return Ok(await _context.Professors.ToListAsync());
        }

        // GET: One Professor
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfessor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professors.FindAsync(id);
            if (professor == null)
            {
                return NotFound();
            }

            return Ok(professor);
        }

        // POST: Add a professor
        [HttpPost]
        public async Task<IActionResult> AddProfessor([FromBody] Professor professor)
        {
            if (ModelState.IsValid)
            {
                var exists = _context.Professors.Any(x => x.Email == professor.Email);
                if (exists) return BadRequest("Professor already exists");
                _context.Add(professor);
                await _context.SaveChangesAsync();
                return Ok("Added successfully");
            }
            return BadRequest("Invalid data");
        }


        // PUT: Edit a professor
        [HttpPut("{id}")]
        public async Task<IActionResult> EditProfessor(int? id, [FromBody] Professor professor)
        {
            if (id != professor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professor);
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


        // Delete: Delete a professor
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = await _context.Professors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (professor == null)
            {
                return NotFound();
            }
            try
            {
                _context.Professors.Remove(professor);
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