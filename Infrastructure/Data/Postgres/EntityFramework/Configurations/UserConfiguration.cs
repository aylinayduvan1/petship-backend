using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class UserConfiguration : Configuration<User, int>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.User_surname).IsRequired();
   
            builder.Property(x => x.Email).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.User_sex).IsRequired().HasMaxLength(1);
            builder.Property(x => x.Animal_exist).IsRequired();
            builder.Property(x => x.Animal_history).IsRequired();


            
            builder.Property(x => x.PasswordSalt).IsRequired();
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

           

            builder.Property(x => x.UserType)
                .IsRequired()
                .HasConversion<string>();

            builder.HasMany(b => b.Advert)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.User_id);
        }
    }
}
