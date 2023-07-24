using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Data.Postgres.Repositories;

public class AnimalRepository : Repository<Animal, int>, IAnimalRepository
{
    public AnimalRepository(PostgresContext postgresContext) : base(postgresContext)
    {
    }


    // IAnimalRepository arabiriminden türeyen GetByIdAsync yöntemini uygulama
    public async Task<IList<Animal>> GetByAnimalIdAsync(int id)
    {
        return await PostgresContext.Set<Animal>()
            .Include(Animal => Animal.Id)
            .Where(Animal => Animal.Id == id)
            .ToListAsync();
    }

   


}

