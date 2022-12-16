using BackEnd.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : Controller
    {
        ExamContext _context;

        public MarksController(ExamContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Marks.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var mark = await _context.Marks.FindAsync(id);

            return mark == null ? NotFound() : Ok(mark);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Marks mark)
        {
            try
            {
                await _context.Marks.AddAsync(mark);
                await _context.SaveChangesAsync();

                return Ok(await _context.Marks.ToListAsync());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var mark = await _context.Marks.FindAsync(id);
            if (mark == null) return NotFound();

            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();

            return Ok(await _context.Marks.ToListAsync());
        }
    }
}
