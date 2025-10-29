using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuoteAPI.Data;
using QuoteAPI.Models;

namespace QuoteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuotesController : ControllerBase
{
    private readonly QuoteContext _context;

    // The context is automatically provided by ASP.NET (Dependency Injection)
    public QuotesController(QuoteContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Quote>>> GetAll()
    {
        var quotes = await _context.Quotes.ToListAsync();
        return Ok(quotes);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Quote>> GetById(int id)
    {
        var quote = await _context.Quotes.FindAsync(id);
        if (quote == null)
            return NotFound();

        return Ok(quote);
    }

    [HttpPost]
    public async Task<ActionResult<Quote>> Create(Quote newQuote)
    {
        _context.Quotes.Add(newQuote);
        await _context.SaveChangesAsync(); // saves to quotes.db

        return CreatedAtAction(nameof(GetById), new { id = newQuote.Id }, newQuote);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var quote = await _context.Quotes.FindAsync(id);
        if (quote == null)
            return NotFound();

        _context.Quotes.Remove(quote);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}