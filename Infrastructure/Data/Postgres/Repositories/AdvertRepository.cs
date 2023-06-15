using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class AdvertRepository : Repository<Advert, int>, IAdvertRepository
    {
        public AdvertRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }
        Task<IList<Advert>> IAdvertRepository.GetAdvertByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IList<Advert>> GetAdvertByIdAsync(int id)
        {
            return await PostgresContext.Set<Advert>()
                .Include(Advert => Advert.Id)
                .Where(Advert => Advert.Id == id)
                .ToListAsync();
        }

    }
}