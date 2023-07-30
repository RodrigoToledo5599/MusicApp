using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApp.Data;
using MusicApp.Models;

namespace MusicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaixasController : ControllerBase
    {
        private readonly AluraTunesContext _context;

        public FaixasController(AluraTunesContext context)
        {
            _context = context;
        }

        // GET: api/Faixas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faixa>>> GetFaixas()
        {
          if (_context.Faixas == null)
          {
              return NotFound();
          }
            return await _context.Faixas.ToListAsync();
        }

        // GET: api/Faixas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faixa>> GetFaixa(int id)
        {
          if (_context.Faixas == null)
          {
              return NotFound();
          }
            var faixa = await _context.Faixas.FindAsync(id);

            if (faixa == null)
            {
                return NotFound();
            }

            return faixa;
        }

        // PUT: api/Faixas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaixa(int id, Faixa faixa)
        {
            if (id != faixa.FaixaId)
            {
                return BadRequest();
            }

            _context.Entry(faixa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaixaExists(id))
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

        // POST: api/Faixas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Faixa>> PostFaixa(Faixa faixa)
        {
          if (_context.Faixas == null)
          {
              return Problem("Entity set 'AluraTunesContext.Faixas'  is null.");
          }
            _context.Faixas.Add(faixa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaixa", new { id = faixa.FaixaId }, faixa);
        }

        // DELETE: api/Faixas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaixa(int id)
        {
            if (_context.Faixas == null)
            {
                return NotFound();
            }
            var faixa = await _context.Faixas.FindAsync(id);
            if (faixa == null)
            {
                return NotFound();
            }

            _context.Faixas.Remove(faixa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FaixaExists(int id)
        {
            return (_context.Faixas?.Any(e => e.FaixaId == id)).GetValueOrDefault();
        }
    }
}
