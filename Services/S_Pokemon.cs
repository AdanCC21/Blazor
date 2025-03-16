using Data;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class S_Pokemon
    {
        private readonly MyDbContext _dbContext;

        public S_Pokemon(MyDbContext dbContext  )
        {
            _dbContext = dbContext;
        }

        public async Task<List<E_Pokemon>> GetAllPokemons()
        {
            return await this._dbContext.MyPokemonEntity.ToListAsync();
        }
    }
}
