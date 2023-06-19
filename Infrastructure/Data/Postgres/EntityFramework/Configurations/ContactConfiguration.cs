using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class ContactConfiguration : Configuration<Contact,int>
{
    public override void Configure(EntityTypeBuilder<Contact> builder)

    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Adress).IsRequired();
        
        builder.Property(x => x.Email).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();

        builder.Property(x => x.gsm).IsRequired();



    }
}
