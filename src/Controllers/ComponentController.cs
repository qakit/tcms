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
    public class ComponentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ComponentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Component
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Component>>> GetComponent()
        {
            return await _context.Component.ToListAsync();
        }

        // GET: api/Component/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Component>> GetComponent(int id)
        {
            var component = await _context.Component.FindAsync(id);

            if (component == null)
            {
                return NotFound();
            }

            return component;
        }

        // PUT: api/Component/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComponent(int id, Component component)
        {
            if (id != component.ComponentId)
            {
                return BadRequest();
            }

            _context.Entry(component).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComponentExists(id))
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

        // POST: api/Component
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Component>> PostComponent(Component component)
        {
            _context.Component.Add(component);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComponent", new { id = component.ComponentId }, component);
        }

        // DELETE: api/Component/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComponent(int id)
        {
            var component = await _context.Component.FindAsync(id);
            if (component == null)
            {
                return NotFound();
            }

            _context.Component.Remove(component);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComponentExists(int id)
        {
            return _context.Component.Any(e => e.ComponentId == id);
        }
    }
}
