using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
   
    ICategoriesRepository Categories { get; }
    IAnimalRepository Animals { get; }
    IAdvertRepository Adverties { get; }

  
    Task<int> CommitAsync();
}