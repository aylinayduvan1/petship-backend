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
        public string category_name { get; set; } = default!;
        public byte[] category_img { get; set; }
    }
}
