using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class AdvertRepository : Repository<Advert, int>, IAdvertRepository
    {
        public AdvertRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }

        public Task<Advert> GetAdvertById(int id)
        {
            throw new NotImplementedException();
        }
    }
}