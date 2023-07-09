using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Data.Postgres.Repositories;

public class ContactRepository : Repository<Contact, int>, IContactRepository
{
    public ContactRepository(PostgresContext postgresContext) : base(postgresContext)
    {
    }


    public async Task<IList<Contact>> GetWithContactAsync(int id)
    {
        return await PostgresContext.Set<Contact>()
             .Include(Contact => Contact.Id)
             .Where(Contact => Contact.Id == id)
             .ToListAsync();
    }
}
