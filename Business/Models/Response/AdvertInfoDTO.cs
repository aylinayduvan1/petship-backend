using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
        public class AdvertInfoDTO
    {
        public int id { get; set; } = default!;
        public int Advert_no { get; set; } = default!;
        public string Advert_date { get; set; } = default!;
        public string Advert_title { get; set; } = default!;
        public string Advert_text { get; set; } = default!;
        public bool Situation { get; set; }
        public string Advert_img { get; set; } = default!;


        // include atılmayacaksa bu id'lerden hangileriyle ilişili olduğuna bakılır..
        public int Category_id { get; set; }
        public int User_id { get; set; }
        public int Animal_id { get; set; }


        public UserProfileDto? User { get; set; }
        public AnimalInfoDTO ?Animal { get; set; }
        public CategoryInfoDTO ?Categories { get; set; }

    }
}
