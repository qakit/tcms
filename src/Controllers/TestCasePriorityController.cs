using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tcms.Data;
using tcms.Data.Models;

namespace tcms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestCasePriorityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestCasePriorityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TestCasePriority
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestCasePriority>>> GetTestCasePriority()
        {
            return await _context.TestCasePriority.ToListAsync();
        }

        // GET: api/TestCasePriority/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestCasePriority>> GetTestCasePriority(int id)
        {
            var testCasePriority = await _context.TestCasePriority.FindAsync(id);

            if (testCasePriority == null)
            {
                return NotFound();
            }

            return testCasePriority;
        }

        // PUT: api/TestCasePriority/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestCasePriority(int id, TestCasePriority testCasePriority)
        {
            if (id != testCasePriority.TestCasePriorityId)
            {
                return BadRequest();
            }

            _context.Entry(testCasePriority).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestCasePriorityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TestCasePriority
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestCasePriority>> PostTestCasePriority(TestCasePriority testCasePriority)
        {
            _context.TestCasePriority.Add(testCasePriority);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestCasePriority", new { id = testCasePriority.TestCasePriorityId }, testCasePriority);
        }

        // DELETE: api/TestCasePriority/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestCasePriority(int id)
        {
            var testCasePriority = await _context.TestCasePriority.FindAsync(id);
            if (testCasePriority == null)
            {
                return NotFound();
            }

            _context.TestCasePriority.Remove(testCasePriority);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestCasePriorityExists(int id)
        {
            return _context.TestCasePriority.Any(e => e.TestCasePriorityId == id);
        }
    }
}
