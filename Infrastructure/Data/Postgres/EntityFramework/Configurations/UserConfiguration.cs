using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.UserName).IsRequired();
        builder.Property(x => x.Password).IsRequired();
        builder.Property(x => x.user_surname).IsRequired();
        builder.HasIndex(x => x.user_surname).IsUnique();
        builder.Property(x => x.user_adress).IsRequired();
        builder.Property(x => x.user_sex).IsRequired().HasMaxLength(1);
        builder.Property(x => x.Email).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.user_gsm).IsRequired();
        builder.Property(x => x.animal_id).IsRequired();
        builder.Property(x => x.advert_id).IsRequired();
        builder.Property(x => x.PasswordSalt).IsRequired();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.IsDeleted).IsRequired();

        builder.HasOne(x => x.Animal)
            .WithOne()
            .HasForeignKey<User>(x => x.animal_id);

        builder.HasOne(x => x.Advert)
            .WithOne()
            .HasForeignKey<User>(x => x.advert_id);

        builder.Property(x => x.UserType)
            .IsRequired()
            .HasConversion<string>();
    }
}