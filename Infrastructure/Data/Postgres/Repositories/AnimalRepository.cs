using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Linq.Expressions;

namespace Infrastructure.Data.Postgres.Repositories;

public class AnimalRepository : Repository<User, int>, IAnimalRepository
{
    // AnimalRepository sınıfının yapıcı metodu
    public AnimalRepository(PostgresContext postgresContext) : base(postgresContext)
    {

    }

    // Animal eklemek için asenkron bir yöntem
    public Task AddAsync(Animal entity)
    {
        throw new NotImplementedException();
    }

    // Birden fazla Animal eklemek için asenkron bir yöntem
    public Task AddRangeAsync(IEnumerable<Animal> entities)
    {
        throw new NotImplementedException();
    }

    // Belirtilen filtreye göre ilk Animal'ı almak için asenkron bir yöntem
    public Task<Animal?> FirstOrDefaultAsync(Expression<Func<Animal, bool>> filter)
    {
        throw new NotImplementedException();
    }

    // Belirtilen filtreye göre tüm Animal'ları almak için asenkron bir yöntem
    public Task<IList<Animal>> GetAllAsync(Expression<Func<Animal, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    // Belirtilen filtreye göre Animal almak için asenkron bir yöntem
    public Task<Animal?> GetAsync(Expression<Func<Animal, bool>> filter)
    {
        throw new NotImplementedException();
    }

    // Belirli bir kimlik değerine sahip User'ı almak için asenkron bir yöntem
    public Task<User> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    // Belirtilen filtreye göre Animal sayısını almak için asenkron bir yöntem
    public Task<int> GetCountAsync(Expression<Func<Animal, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    // Animal'ı silmek için bir yöntem
    public void Remove(Animal entity)
    {
        throw new NotImplementedException();
    }

    // Birden fazla Animal'ı silmek için bir yöntem
    public void RemoveRange(IEnumerable<Animal> entities)
    {
        throw new NotImplementedException();
    }

    // Animal nesnesinin izlenmesini durdurmak için bir yöntem
    public void UntrackEntity(Animal entity)
    {
        throw new NotImplementedException();
    }

    // Animal nesnesini güncellemek için bir yöntem
    public void Update(Animal entity)
    {
        throw new NotImplementedException();
    }

    // Birden fazla Animal nesnesini güncellemek için bir yöntem
    public void UpdateRange(IEnumerable<Animal> entities)
    {
        throw new NotImplementedException();
    }

    // IAnimalRepository arabiriminden türeyen GetByIdAsync yöntemini uygulama
    Task<Animal> IAnimalRepository.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}