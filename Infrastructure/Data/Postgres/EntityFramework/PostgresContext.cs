using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data.Postgres.EntityFramework;

public class PostgresContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
        modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
        modelBuilder.ApplyConfiguration(new AnimalConfiguration());
        modelBuilder.ApplyConfiguration(new AdvertConfiguration());


        // repository içerisinde ki "PostgreContext özelliklerini kullanabilmemiz
        // için öncelikle burada configurationsları modelbuilder ile override etmemiz gerekli
        // daha sonrası aşağıda...."
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (_configuration["EnvironmentAlias"] == "DEV")
        {
            optionsBuilder.LogTo(Console.Write);
        }
    }

    public DbSet<User> User => Set<User>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();

    public DbSet<Categories> Categories => Set<Categories>();

    public DbSet<Animal> Animal => Set<Animal>();

    public DbSet<Advert> Advert => Set<Advert>();

    // daha sonra buradan objeleri set ediyoruz bu şekilde bu classın özelliklerini kullanabiliyoruz...
}