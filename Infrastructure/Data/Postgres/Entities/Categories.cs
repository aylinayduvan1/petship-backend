﻿using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Categories : Entity<int>
    {
        public string Category_name { get; set; } = default!;
        public string Category_img { get; set; } = default!;

        public List<Advert?> Advert { get; set; }
    }
}
