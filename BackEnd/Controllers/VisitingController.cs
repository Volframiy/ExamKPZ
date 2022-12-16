using BackEnd.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitingController : Controller
    {
        ExamContext _context;

        public VisitingController(ExamContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Visiting.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var visit = await _context.Visiting.FindAsync(id);

            return visit == null ? NotFound() : Ok(visit);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Visiting visit)
        {
            try
            {
                await _context.Visiting.AddAsync(visit);
                await _context.SaveChangesAsync();

                return Ok(await _context.Visiting.ToListAsync());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var visit = await _context.Visiting.FindAsync(id);
            if (visit == null) return NotFound();

            _context.Visiting.Remove(visit);
            await _context.SaveChangesAsync();

            return Ok(await _context.Visiting.ToListAsync());
        }
    }
}
