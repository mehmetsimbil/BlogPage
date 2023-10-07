using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Picture : BaseEntity,IEntity
    {
        public int BlogId { get; set; }
        public string Path { get; set; }
        public int OrderBy { get; set; }
    }
}
