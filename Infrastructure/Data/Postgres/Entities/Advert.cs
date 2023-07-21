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
        public int Advert_no { get; set; } = default!;
        public string Advert_date { get; set; } = default!;
        public string Advert_title { get; set; } = default!;
        public string Advert_text { get; set; } = default!;
        public bool Situation { get; set; }
        public string Advert_img { get; set; }

        public int Category_id { get; set; }



        public Animal? Animal { get; set; }
        public Categories? Categories { get; set; }

    }
}
