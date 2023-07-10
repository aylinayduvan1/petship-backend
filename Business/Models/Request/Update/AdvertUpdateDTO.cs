using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class AdvertUpdateDTO
    {
        public int advert_no { get; set; } = default!;
        public string advert_date { get; set; } = default!;
        public string advert_title { get; set; } = default!;
        public string advert_text { get; set; } = default!;
        public bool situation { get; set; }
    }
}
