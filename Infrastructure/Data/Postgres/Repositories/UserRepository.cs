using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
        private readonly PostgresContext _context;

        public UserRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            // Belirli bir kullanıcıyı kimlik numarasına göre almak için bu metodu kullanabilirsiniz.
            return await _context.User.FindAsync(id);
        }
        public async Task<List<User>> GetUsersByIdAsync(int id)
        {
            Expression<Func<User, bool>> filter = u => u.Id == id;
            return await GetUsersByFilterAsync(filter);
        }

        private async Task<List<User>> GetUsersByFilterAsync(Expression<Func<User, bool>> filter)
        {
            return await _context.User.Where(filter).ToListAsync();
        }


        public async Task<User> CreateUserAsync(User user)
        {
            // Yeni bir kullanıcıyı veritabanına eklemek için bu metodu kullanabilirsiniz.
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            // Var olan bir kullanıcıyı güncellemek için bu metodu kullanabilirsiniz.
            _context.User.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task DeleteUserAsync(int id)
        {
            // Bir kullanıcıyı silmek için bu metodu kullanabilirsiniz.
            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            // Tüm kullanıcıları getirmek için bu metodu kullanabilirsiniz.
            return await _context.User.ToListAsync();
        }
    }
}
