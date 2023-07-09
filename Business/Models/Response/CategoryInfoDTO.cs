using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CategoryInfoDTO
    {
        public string category_name { get; set; } = default!;
        public byte[] category_img { get; set; }
    }
}
