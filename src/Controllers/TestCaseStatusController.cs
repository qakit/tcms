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
    public class TestCaseStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestCaseStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TestCaseStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestCaseStatus>>> GetTestCaseStatus()
        {
            return await _context.TestCaseStatus.ToListAsync();
        }

        // GET: api/TestCaseStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestCaseStatus>> GetTestCaseStatus(int id)
        {
            var testCaseStatus = await _context.TestCaseStatus.FindAsync(id);

            if (testCaseStatus == null)
            {
                return NotFound();
            }

            return testCaseStatus;
        }

        // PUT: api/TestCaseStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestCaseStatus(int id, TestCaseStatus testCaseStatus)
        {
            if (id != testCaseStatus.TestCaseStatusId)
            {
                return BadRequest();
            }

            _context.Entry(testCaseStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestCaseStatusExists(id))
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

        // POST: api/TestCaseStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestCaseStatus>> PostTestCaseStatus(TestCaseStatus testCaseStatus)
        {
            _context.TestCaseStatus.Add(testCaseStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestCaseStatus", new { id = testCaseStatus.TestCaseStatusId }, testCaseStatus);
        }

        // DELETE: api/TestCaseStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestCaseStatus(int id)
        {
            var testCaseStatus = await _context.TestCaseStatus.FindAsync(id);
            if (testCaseStatus == null)
            {
                return NotFound();
            }

            _context.TestCaseStatus.Remove(testCaseStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestCaseStatusExists(int id)
        {
            return _context.TestCaseStatus.Any(e => e.TestCaseStatusId == id);
        }
    }
}
