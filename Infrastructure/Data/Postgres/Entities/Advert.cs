using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Advert : Entity<int>
    {
        public int advert_no { get; set; } = default!;
        public DateTime advert_date { get; set; } = default!;
        public string advert_title { get; set; } = default!;
        public string advert_text { get; set; } = default!;

    }
}
