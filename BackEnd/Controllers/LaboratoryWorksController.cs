using BackEnd.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratoryWorksController : Controller
    {
        ExamContext _context;

        public LaboratoryWorksController(ExamContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.LaboratoryWorks.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var work = await _context.LaboratoryWorks.FindAsync(id);

            return work == null ? NotFound() : Ok(work);
        }

        [HttpPost]
        public async Task<IActionResult> Post(LaboratoryWorks work)
        {
            try
            {
                await _context.LaboratoryWorks.AddAsync(work);
                await _context.SaveChangesAsync();

                return Ok(await _context.LaboratoryWorks.ToListAsync());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var work = await _context.LaboratoryWorks.FindAsync(id);
            if (work == null) return NotFound();

            _context.LaboratoryWorks.Remove(work);
            await _context.SaveChangesAsync();

            return Ok(await _context.LaboratoryWorks.ToListAsync());
        }
    }
}
