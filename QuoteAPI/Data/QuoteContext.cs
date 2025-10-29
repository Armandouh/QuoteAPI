using QuoteAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace QuoteAPI.Data;

public class QuoteContext : DbContext
{
    public QuoteContext(DbContextOptions<QuoteContext> options)
        : base(options) { }

    public DbSet<Quote> Quotes => Set<Quote>();
}