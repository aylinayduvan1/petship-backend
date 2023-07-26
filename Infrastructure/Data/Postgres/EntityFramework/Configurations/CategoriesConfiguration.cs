﻿using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class CategoriesConfiguration : Configuration<Categories,int>
    {
        public override void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Category_name).IsRequired();
            builder.Property(x => x.Category_img).IsRequired();

           
            builder.HasMany(b => b.Advert)
                .WithOne(b => b.Categories)
                .HasForeignKey(b => b.Category_id); 
            //tekil olanın id si
           

            

        }
    }
}
