using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDTD_Web_APP.Models;

namespace SDTD_Web_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationsController : Controller
    {
        private readonly SDTDContext _context;

        public ConsultationsController(SDTDContext context)
        {
            _context = context;
        }

        // GET: All Consultations
        [HttpGet]
        public async Task<IActionResult> GetAllConsultations()
        {
            return Ok(await _context.Consultations.ToListAsync());
        }

        // GET: One Consultation
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsultation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultation = await _context.Consultations.FindAsync(id);
            if (consultation == null)
            {
                return NotFound();
            }
            return Ok(consultation);
        }

        // POST: Add a consultation
        [HttpPost]
        public async Task<IActionResult> AddConsultation([FromBody] Consultation consultation)
        {
            if (ModelState.IsValid)
            {
                var exists = _context.Consultations.Any(x => x.SllotiKohor == consultation.SllotiKohor);
                if (exists) return BadRequest("Consultation already exists");
                _context.Add(consultation);
                await _context.SaveChangesAsync();
                return Ok("Added successfully");
            }
            return BadRequest("Invalid data");
        }


        // PUT: Edit a consultation
        [HttpPut("{id}")]
        public async Task<IActionResult> EditConsultation(int? id, [FromBody] Consultation consultation)
        {
            if (id != consultation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultation);
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


        // Delete: Delete a consultation
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultation = await _context.Consultations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consultation == null)
            {
                return NotFound();
            }
            try
            {
                _context.Consultations.Remove(consultation);
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