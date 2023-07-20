using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class  AnimalConfiguration : Configuration<Animal,int>
    {
        public override void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.animal_name).IsRequired();
            builder.Property(x => x.animal_year).IsRequired();
            builder.Property(x => x.animal_sex).IsRequired().HasMaxLength(1);
            builder.Property(x => x.animal_type).IsRequired();
            builder.Property(x => x.animal_img).IsRequired();


            builder.HasOne(a => a.Advert) // Advert sınıfının Animal özelliğiyle ilişkili olduğunu belirtiyoruz
                 .WithOne(a => a.Animal) // Hayvanın birden fazla ilana ait olmadığını belirtiyoruz
                 .HasForeignKey<Animal>(a => a.advert_id); // İlişkiyi sağlayan sütunun Advert sınıfının AnimalId özelliği

        }
    }
}
