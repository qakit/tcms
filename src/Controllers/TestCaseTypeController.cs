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
    public class TestCaseTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestCaseTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TestCaseType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestCaseType>>> GetTestCaseType()
        {
            return await _context.TestCaseType.ToListAsync();
        }

        // GET: api/TestCaseType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestCaseType>> GetTestCaseType(int id)
        {
            var testCaseType = await _context.TestCaseType.FindAsync(id);

            if (testCaseType == null)
            {
                return NotFound();
            }

            return testCaseType;
        }

        // PUT: api/TestCaseType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestCaseType(int id, TestCaseType testCaseType)
        {
            if (id != testCaseType.TestCaseTypeId)
            {
                return BadRequest();
            }

            _context.Entry(testCaseType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestCaseTypeExists(id))
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

        // POST: api/TestCaseType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestCaseType>> PostTestCaseType(TestCaseType testCaseType)
        {
            _context.TestCaseType.Add(testCaseType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestCaseType", new { id = testCaseType.TestCaseTypeId }, testCaseType);
        }

        // DELETE: api/TestCaseType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestCaseType(int id)
        {
            var testCaseType = await _context.TestCaseType.FindAsync(id);
            if (testCaseType == null)
            {
                return NotFound();
            }

            _context.TestCaseType.Remove(testCaseType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestCaseTypeExists(int id)
        {
            return _context.TestCaseType.Any(e => e.TestCaseTypeId == id);
        }
    }
}
