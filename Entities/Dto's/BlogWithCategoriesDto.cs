using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto_s
{
    public class BlogWithCategoriesDto
    {
        public string? Title{ get; set; }
        public string? Detail { get; set; }
        public string? CategoryName { get; set; }
    }
}
