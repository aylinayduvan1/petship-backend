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
            builder.Property(x => x.advert_no).IsRequired();
            builder.HasIndex(x => x.advert_no).IsUnique(); // Burada Advert No'yu Unique olduğunu belirttik bu sayede karışıklık ihtimali ortadan kalktı
            builder.Property(x => x.advert_date).IsRequired();
            builder.Property(x => x.advert_title).IsRequired();
            builder.Property(x => x.advert_text).IsRequired();
            builder.Property(x => x.advert_img).IsRequired();

        }
    }
}
 
