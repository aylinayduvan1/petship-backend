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
            builder.Property(x => x.user_surname).IsRequired();
            builder.HasIndex(x => x.user_surname).IsUnique();
            builder.Property(x => x.Email).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.user_sex).IsRequired().HasMaxLength(1);
            builder.Property(x => x.animal_exist).IsRequired();
            builder.Property(x => x.animal_history).IsRequired();


            builder.Property(x => x.animal_id).IsRequired(false);
            builder.Property(x => x.advert_id).IsRequired(false);
            builder.Property(x => x.PasswordSalt).IsRequired();
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.Animal)
                .WithMany()
                .HasForeignKey(x => x.animal_id);

            builder.HasOne(x => x.Advert)
                .WithMany()
                .HasForeignKey(x => x.advert_id);

            builder.HasOne(x => x.Contact)
                .WithMany()
                .HasForeignKey(x => x.contact_id);

            builder.Property(x => x.UserType)
                .IsRequired()
                .HasConversion<string>();
        }
    }
}
