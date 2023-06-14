using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class AdvertConfiguration : IEntityTypeConfiguration<Advert>
    {
        public void Configure(EntityTypeBuilder<Advert> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.advert_no).IsRequired();
            builder.HasIndex(x => x.advert_no).IsUnique();
            builder.Property(x => x.advert_date).IsRequired();
            builder.Property(x => x.advert_title).IsRequired();
            builder.Property(x => x.advert_text).IsRequired();
        }
    }
}
 