using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface;

public interface IAnimalRepository : IRepository<Animal, int>
{
    Task<Animal> GetByIdAsync(int id);
}