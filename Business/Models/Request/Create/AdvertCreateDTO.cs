using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class AdvertCreateDTO
    {
        public int Advert_no { get; set; } = default!;
        public string Advert_date { get; set; } = default!;
        public string Advert_title { get; set; } = default!;
        public string Advert_text { get; set; } = default!;
        public string Advert_img { get; set; } = default!;

    }
}
