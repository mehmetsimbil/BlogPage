using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Menu : BaseEntity,IEntity
    {
        public int CategoryId { get; set; }
        public int OrderBy { get; set; }
    }
}
