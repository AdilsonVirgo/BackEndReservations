using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEndReservations;
using BackEndReservations.Models;

namespace BackEndReservations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContacttypeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContacttypeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Contacttype
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactType>>> GetContactType()
        {
            return await _context.ContactType.ToListAsync();
        }

        // GET: api/Contacttype/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactType>> GetContactType(int id)
        {
            var contactType = await _context.ContactType.FindAsync(id);

            if (contactType == null)
            {
                return NotFound();
            }

            return contactType;
        }

        // PUT: api/Contacttype/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactType(int id, ContactType contactType)
        {
            if (id != contactType.id)
            {
                return BadRequest();
            }

            _context.Entry(contactType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactTypeExists(id))
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

        // POST: api/Contacttype
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactType>> PostContactType(ContactType contactType)
        {
            _context.ContactType.Add(contactType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactType", new { id = contactType.id }, contactType);
        }

        // DELETE: api/Contacttype/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactType(int id)
        {
            var contactType = await _context.ContactType.FindAsync(id);
            if (contactType == null)
            {
                return NotFound();
            }

            _context.ContactType.Remove(contactType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactTypeExists(int id)
        {
            return _context.ContactType.Any(e => e.id == id);
        }
    }
}
