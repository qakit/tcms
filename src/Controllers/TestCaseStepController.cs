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
    public class TestCaseStepController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TestCaseStepController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TestCaseStep
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestCaseStep>>> GetTestCaseStep()
        {
            return await _context.TestCaseStep.ToListAsync();
        }

        // GET: api/TestCaseStep/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestCaseStep>> GetTestCaseStep(int id)
        {
            var testCaseStep = await _context.TestCaseStep.FindAsync(id);

            if (testCaseStep == null)
            {
                return NotFound();
            }

            return testCaseStep;
        }

        // PUT: api/TestCaseStep/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestCaseStep(int id, TestCaseStep testCaseStep)
        {
            if (id != testCaseStep.TestCaseStepId)
            {
                return BadRequest();
            }

            _context.Entry(testCaseStep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestCaseStepExists(id))
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

        // POST: api/TestCaseStep
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestCaseStep>> PostTestCaseStep(TestCaseStep testCaseStep)
        {
            _context.TestCaseStep.Add(testCaseStep);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestCaseStep", new { id = testCaseStep.TestCaseStepId }, testCaseStep);
        }

        // DELETE: api/TestCaseStep/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestCaseStep(int id)
        {
            var testCaseStep = await _context.TestCaseStep.FindAsync(id);
            if (testCaseStep == null)
            {
                return NotFound();
            }

            _context.TestCaseStep.Remove(testCaseStep);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestCaseStepExists(int id)
        {
            return _context.TestCaseStep.Any(e => e.TestCaseStepId == id);
        }
    }
}
