using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class CategoriesRepository : Repository<Categories, int>, ICategoriesRepository
    {
        

        public CategoriesRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Categories>> GetAllAsync(Expression<Func<Categories, bool>>? filter = null)
        {
            var categories = PostgresContext.Set<Categories>()
              .Include(categories => categories.Advert);
            return filter == null
                ? await categories.ToListAsync()
                : await categories.Where(filter)
                .ToListAsync();
        }

        public Task<IList<Categories>> GetWithCategoriesAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
