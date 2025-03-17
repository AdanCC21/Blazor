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
            var pokemons = await this._dbContext.MyPokemonEntity.ToListAsync();
            return pokemons ?? new List<E_Pokemon>();  // Return an empty list if null
        }

        public async Task<bool> insertPokemon(E_Pokemon pokemon)
        {
            try
            {
                _dbContext.Add(pokemon);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        } 
    }
}
