using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal_Finance_Manager.Models;

namespace Personal_Finance_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseCategoriesController : ControllerBase
    {
        private readonly PersonaFinanceAppDbContext _context;

        public ExpenseCategoriesController(PersonaFinanceAppDbContext context)
        {
            _context = context;
        }

        // GET: api/ExpenseCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseCategory>>> GetExpenseCategories()
        {
          if (_context.ExpenseCategories == null)
          {
              return NotFound();
          }
            return await _context.ExpenseCategories.ToListAsync();
        }

        // GET: api/ExpenseCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseCategory>> GetExpenseCategory(int id)
        {
          if (_context.ExpenseCategories == null)
          {
              return NotFound();
          }
            var expenseCategory = await _context.ExpenseCategories.FindAsync(id);

            if (expenseCategory == null)
            {
                return NotFound();
            }

            return expenseCategory;
        }

        // PUT: api/ExpenseCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseCategory(int id, ExpenseCategory expenseCategory)
        {
            if (id != expenseCategory.ExpenseCategoryID)
            {
                return BadRequest();
            }

            _context.Entry(expenseCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseCategoryExists(id))
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

        // POST: api/ExpenseCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExpenseCategory>> PostExpenseCategory(ExpenseCategory expenseCategory)
        {
          if (_context.ExpenseCategories == null)
          {
              return Problem("Entity set 'PersonaFinanceAppDbContext.ExpenseCategories'  is null.");
          }
            _context.ExpenseCategories.Add(expenseCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpenseCategory", new { id = expenseCategory.ExpenseCategoryID }, expenseCategory);
        }

        // DELETE: api/ExpenseCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseCategory(int id)
        {
            if (_context.ExpenseCategories == null)
            {
                return NotFound();
            }
            var expenseCategory = await _context.ExpenseCategories.FindAsync(id);
            if (expenseCategory == null)
            {
                return NotFound();
            }

            _context.ExpenseCategories.Remove(expenseCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExpenseCategoryExists(int id)
        {
            return (_context.ExpenseCategories?.Any(e => e.ExpenseCategoryID == id)).GetValueOrDefault();
        }
    }
}
