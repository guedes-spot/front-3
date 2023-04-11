using Microsoft.EntityFrameworkCore;

namespace Teste.Infrastructure.Persistence;

[ExcludeFromCodeCoverage]
public class ApplicationDbContext : DbContext
{
    public DbSet<HelloWorldResponse> HelloWorld { get; set; } = null!;
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}