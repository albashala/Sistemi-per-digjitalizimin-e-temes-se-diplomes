using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDTD_Web_APP.Models;

namespace SDTD_Web_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : Controller
    {
        private readonly SDTDContext _context;

        public AdminsController(SDTDContext context)
        {
            _context = context;
        }

        // GET: All Admins
        [HttpGet]
        public async Task<IActionResult> GetAllAdmins()
        {
            return Ok(await _context.Admins.ToListAsync());
        }

        // GET: One Admin
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin);
        }

        // POST: Add an admin
        [HttpPost]
        public async Task<IActionResult> AddAdmin([FromBody] Admin admin)
        {
            if (ModelState.IsValid)
            {
                var exists = _context.Admins.Any(x => x.Email == admin.Email);
                if (exists) return BadRequest("Admin already exists");
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return Ok("Added successfully");
            }
            return BadRequest("Invalid data");
        }


        // PUT: Edit an admin
        [HttpPut("{id}")]
        public async Task<IActionResult> EditAdmin(int? id, [FromBody] Admin admin)
        {
            if (id != admin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admin);
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


        // Delete: Delete an admin
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }
            try
            {
                _context.Admins.Remove(admin);
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