using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDTD_Web_APP.Models;

namespace SDTD_Web_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThesesController : Controller
    {
        private readonly SDTDContext _context;

        public ThesesController(SDTDContext context)
        {
            _context = context;
        }

        // GET: All Theses
        [HttpGet]
        public async Task<IActionResult> GetAllTheses()
        {
            return Ok(await _context.Theses.ToListAsync());
        }

        // GET: One Thesis
        [HttpGet("{id}")]
        public async Task<IActionResult> GetThesis(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.Theses.FindAsync(id);
            if (thesis == null)
            {
                return NotFound();
            }
            return Ok(thesis);
        }

        // POST: Add a thesis
        [HttpPost]
        public async Task<IActionResult> AddThesis([FromBody] Thesis thesis)
        {
            if (ModelState.IsValid)
            {
                var exists = _context.Theses.Any(x => x.Emri == thesis.Emri);
                if (exists) return BadRequest("Thesis already exists");
                _context.Add(thesis);
                await _context.SaveChangesAsync();
                return Ok("Added successfully");
            }
            return BadRequest("Invalid data");
        }


        // PUT: Edit a thesis
        [HttpPut("{id}")]
        public async Task<IActionResult> EditThesis(int? id, [FromBody] Thesis thesis)
        {
            if (id != thesis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thesis);
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


        // Delete: Delete a thesis
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThesis(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thesis = await _context.Theses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thesis == null)
            {
                return NotFound();
            }
            try
            {
                _context.Theses.Remove(thesis);
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