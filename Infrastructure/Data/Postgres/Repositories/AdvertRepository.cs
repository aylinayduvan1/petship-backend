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
       
        public async Task<IList<Advert>> GetAdvertByIdAsync(int id)
        {
            return await PostgresContext.Set<Advert>()
                .Include(Advert => Advert.Id)
                .Where(Advert => Advert.Id == id)
                .ToListAsync();
        }
        public async Task<IList<Advert>> GetAllAsync(Expression<Func<Advert, bool>>? filter = null)
        {
            var advert = PostgresContext.Set<Advert>();
            return filter == null
                ? await advert.ToListAsync()
                : await advert.Where(filter)
                .ToListAsync();
        }

    }
}