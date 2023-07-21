using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharpDX;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class AdvertConfiguration : Configuration<Advert,int>
    {
        public  override void Configure(EntityTypeBuilder<Advert> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Advert_no).IsRequired();
            builder.HasIndex(x => x.Advert_no).IsUnique(); // Burada Advert No'yu Unique olduğunu belirttik bu sayede karışıklık ihtimali ortadan kalktı
            builder.Property(x => x.Advert_date).IsRequired();
            builder.Property(x => x.Advert_title).IsRequired();
            builder.Property(x => x.Advert_text).IsRequired();
            builder.Property(x => x.Advert_img).IsRequired();


            builder.HasOne(b => b.Categories)
                 .WithOne(b => b.Advert)
                 .HasForeignKey<Advert>(b => b.Category_id);

        }
    }
}
 
