﻿using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class  AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.animal_name).IsRequired();
            builder.Property(x => x.animal_year).IsRequired();
            builder.Property(x => x.animal_sex).IsRequired().HasMaxLength(1);
            builder.Property(x => x.animal_type).IsRequired();
        }
    }
}
