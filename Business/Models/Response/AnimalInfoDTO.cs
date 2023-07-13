using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AnimalInfoDTO
    {
        public string animal_name { get; set; } = default!;
        public string animal_year { get; set; } = default!;
        public bool animal_vaccine { get; set; }
        public bool animal_chip { get; set; }
        public string animal_sex { get; set; } = default!;
        public string animal_type { get; set; } = default!;
        public bool animal_passion { get; set; }
        public byte[] animal_img { get; set; }
    }
}
