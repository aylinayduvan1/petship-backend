using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq.Expressions;

namespace Infrastructure.Data.Postgres.Repositories;

public class AnimalRepository : Repository<User, int>, IAnimalRepository
{
    public AnimalRepository(PostgresContext postgresContext) : base(postgresContext)
    {

    }

    public Task AddAsync(Animal entity)
    {
        throw new NotImplementedException();
    }

    public Task AddRangeAsync(IEnumerable<Animal> entities)
    {
        throw new NotImplementedException();
    }

    public Task<Animal?> FirstOrDefaultAsync(Expression<Func<Animal, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Animal>> GetAllAsync(Expression<Func<Animal, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    public Task<Animal?> GetAsync(Expression<Func<Animal, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetCountAsync(Expression<Func<Animal, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Animal entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Animal> entities)
    {
        throw new NotImplementedException();
    }

    public void UntrackEntity(Animal entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Animal entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(IEnumerable<Animal> entities)
    {
        throw new NotImplementedException();
    }

    Task<Animal> IAnimalRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
