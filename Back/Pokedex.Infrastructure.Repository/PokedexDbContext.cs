using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Model;

namespace Pokedex.Infrastructure.Repository;

   
public class PokedexDbContext(DbContextOptions<PokedexDbContext> options) : DbContext(options)
{
        public DbSet<User> Users { get; set; }
}

  
