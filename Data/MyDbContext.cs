using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}

        public DbSet<E_Pokemon> MyPokemonEntity { get; set; }
    }
}
