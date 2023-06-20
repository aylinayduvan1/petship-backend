using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IContactRepository Contacts { get; }

   

    Task<int> CommitAsync();
}