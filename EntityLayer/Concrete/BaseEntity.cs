using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BaseEntity
    {
        public long id { get; set; }
        public DateTime addDate { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; } = false;
    }
}
