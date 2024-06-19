
using Microsoft.EntityFrameworkCore;

namespace ExamenP2;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Juguetes> Juguetes { get; set; }
    public DbSet<Marca> Marca { get; set; }

    
}