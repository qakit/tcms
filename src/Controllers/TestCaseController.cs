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
    public class TestCaseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestCaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TestCase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestCase>>> GetTestCase()
        {
            return await _context.TestCase.ToListAsync();
        }

        // GET: api/TestCase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestCase>> GetTestCase(int id)
        {
            var testCase = await _context.TestCase.FindAsync(id);

            if (testCase == null)
            {
                return NotFound();
            }

            return testCase;
        }

        // PUT: api/TestCase/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestCase(int id, TestCase testCase)
        {
            if (id != testCase.TestCaseId)
            {
                return BadRequest();
            }

            _context.Entry(testCase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestCaseExists(id))
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

        // POST: api/TestCase
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestCase>> PostTestCase(TestCase testCase)
        {
            _context.TestCase.Add(testCase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestCase", new { id = testCase.TestCaseId }, testCase);
        }

        // DELETE: api/TestCase/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestCase(int id)
        {
            var testCase = await _context.TestCase.FindAsync(id);
            if (testCase == null)
            {
                return NotFound();
            }

            _context.TestCase.Remove(testCase);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestCaseExists(int id)
        {
            return _context.TestCase.Any(e => e.TestCaseId == id);
        }
    }
}
