using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CategoryCreateDTO
    {
        public string Category_name { get; set; } = default!;
        public string Category_img { get; set; } = default!;
    }
}
