using Core.Utilities.Pagination;
using System.Linq.Expressions;


namespace Infrastructure.Data.Postgres.Repositories.Base.Interface;

public interface IRepository<TEntity, in TId> where TEntity : class
{
    Task AddAsync(TEntity entity);
    // Belirtilen `entity` nesnesini veritabanına ekler.

    Task AddRangeAsync(IEnumerable<TEntity> entities);
    //Belirtilen `entities` koleksiyonundaki nesneleri veritabanına toplu olarak ekler.

    Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter);
    // Belirtilen `filter` ifadesine uygun olarak veritabanında ilk öğeyi getirir veya varsayılan değeri döndürür.

    Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
    // Veritabanındaki tüm öğeleri döndürür. Opsiyonel olarak bir `filter` ifadesi belirtilirse, sadece filtrelenen öğeleri döndürür.

    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter);
    // Belirtilen `filter` ifadesine göre veritabanında tek bir öğeyi getirir veya varsayılan değeri döndürür.

    Task<int> GetCountAsync(Expression<Func<TEntity, bool>>? filter = null);
    // Veritabanında belirtilen `filter` ifadesine uygun olan öğelerin sayısını döndürür. Opsiyonel olarak bir `filter` ifadesi belirtilmezse, veritabanındaki tüm öğelerin sayısını döndürür.

    void Remove(TEntity entity);
    void RemoveById(TId id);
    // Belirtilen `id` değerine sahip nesneyi veritabanından kaldırır.

    void RemoveRange(IEnumerable<TEntity> entities);
    // Belirtilen `entities` koleksiyonundaki nesneleri toplu olarak veritabanından kaldırır.

    void UntrackEntity(TEntity entity);
    // Belirtilen `entity` nesnesini takip etmeyi durdurur. Bu, nesnenin veritabanı işlemlerinden bağımsız hale gelmesini sağlar.

    void Update(TEntity entity);
    // Belirtilen `entity` nesnesini veritabanında günceller.

    void UpdateRange(IEnumerable<TEntity> entities);
    // Belirtilen `entities` koleksiyonundaki nesneleri toplu olarak veritabanında günceller.
}