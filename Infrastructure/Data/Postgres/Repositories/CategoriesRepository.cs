using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class CategoriesRepository : Repository<Categories, int>, ICategoriesRepository
    {
        

        public CategoriesRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }

        public async Task <IList<Categories>> GetWithCategoriesAsync(int id)
        {
            return (IList<Categories>)await PostgresContext.Categories
            .Include(c => c.Id) // kategorilerin mutlaka isim içermesi gerekli...
            .Where(Categories => Categories.Id == id)
            .ToListAsync();
        }

        public Task<IList<Categories>> GetWithCategoriesAsync(string category_name)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Categories>> GetWithCategoriesAsync(bool category_nımg)
        {
            throw new NotImplementedException();
        }
    }
}
