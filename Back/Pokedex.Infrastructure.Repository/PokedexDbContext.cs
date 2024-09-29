using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Model;

namespace Pokedex.Infrastructure.Repository;

public class PokedexDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public PokedexDbContext(DbContextOptions<PokedexDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {

        optionsBuilder.UseSqlServer("DefaultConnection");

    }
}
