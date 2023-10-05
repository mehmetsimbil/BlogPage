using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog : IEntity
    {
        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Detail{ get; set; }
        public bool Status { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
