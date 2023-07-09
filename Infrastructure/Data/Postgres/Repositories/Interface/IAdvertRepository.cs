using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IAdvertRepository : IRepository<Advert, int>
    {
        Task<IList<Advert>> GetAdvertByIdAsync(int id);
    }
}