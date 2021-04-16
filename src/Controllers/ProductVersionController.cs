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
    [Route("api/Products/{productId:int}/Versions")]
    [ApiController]
    public class ProductVersionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductVersionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Products/5/Versions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVersion>>> GetProductVersions([FromRoute]int productId)
        {
            return await _context.ProductVersion.Where(p => p.ProductId == productId).ToListAsync();
        }

        // GET: api/Products/5/Versions/1
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVersion>> GetProductVersion([FromRoute]int productId, int id)
        {
            var productVersion = await _context.ProductVersion
                .Where(p => p.ProductId == productId && p.ProductVersionId == id)
                .FirstAsync();

            if (productVersion == null)
            {
                return NotFound();
            }

            return productVersion;
        }

        // PUT: api/Products/5/Versions/1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductVersion(int id, ProductVersion productVersion)
        {
            throw new NotImplementedException();
            if (id != productVersion.ProductVersionId)
            {
                return BadRequest();
            }

            _context.Entry(productVersion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductVersionExists(id))
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

        // POST: api/Products/5/Versions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductVersion>> PostProductVersion(ProductVersion productVersion)
        {
            throw new NotImplementedException();
            _context.ProductVersion.Add(productVersion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductVersion", new { id = productVersion.ProductVersionId }, productVersion);
        }

        // DELETE: api/Products/5/Versions/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductVersion(int id, [FromRoute]int productId)
        {
            var productVersion = await _context.ProductVersion
                .Where(p => p.ProductId == productId && p.ProductVersionId == id)
                .FirstAsync();
            if (productVersion == null)
            {
                return NotFound();
            }

            _context.ProductVersion.Remove(productVersion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductVersionExists(int id)
        {
            return _context.ProductVersion.Any(e => e.ProductVersionId == id);
        }
    }
}
