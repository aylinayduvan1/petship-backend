using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CategoryInfoDTO
    {
        public int Id { get; set; }
        public string Category_name { get; set; } = default!;
        public string Category_img { get; set; }
    }
}
