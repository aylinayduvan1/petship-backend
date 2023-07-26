using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AnimalInfoDTO
    {
        public string Animal_name { get; set; } = default!;
        public string Animal_year { get; set; } = default!;
        public bool Animal_vaccine { get; set; }
        public bool Animal_chip { get; set; }
        public string Animal_sex { get; set; } = default!;
        public string Animal_type { get; set; } = default!;
        public bool Animal_passion { get; set; }
        public string Animal_img { get; set; }

        public int Advert_id { get; set; }

        public AdvertInfoDTO Advert { get; set; }

    }
}
