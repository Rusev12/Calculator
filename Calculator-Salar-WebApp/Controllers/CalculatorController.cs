using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Calculator_Salar_WebApp.Models;

namespace Calculator_Salar_WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CalculatorController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        // PUT: api/Calculator/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNetSalaryCalculator(int id, NetSalaryCalculator netSalaryCalculator)
        {
            if (id != netSalaryCalculator.Id)
            {
                return BadRequest();
            }

            _context.Entry(netSalaryCalculator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NetSalaryCalculatorExists(id))
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

 
        [HttpPost]
        public async Task<ActionResult<NetSalaryCalculator>> PostNetSalaryCalculator(NetSalaryCalculator netSalaryCalculator)
        {

            _context.NetSalariesCalculator.Add(netSalaryCalculator);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNetSalaryCalculator", new { id = netSalaryCalculator.Id }, netSalaryCalculator);
        }

        private bool NetSalaryCalculatorExists(int id)
        {
            return _context.NetSalariesCalculator.Any(e => e.Id == id);
        }
    }
}
