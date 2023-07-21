using Infrastructure.Data.Postgres.Entities.Base;
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

        public int Advert_id { get; set; }

        public Advert? Advert { get; set; }
    }
}
