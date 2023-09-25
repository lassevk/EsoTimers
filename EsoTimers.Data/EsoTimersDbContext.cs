using Microsoft.EntityFrameworkCore;

namespace EsoTimers.Data;

public class EsoTimersDbContext : DbContext
{
    public EsoTimersDbContext(DbContextOptions<EsoTimersDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Character> Characters { get; set; }
}