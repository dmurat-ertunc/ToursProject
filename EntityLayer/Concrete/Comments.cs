using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comments : BaseEntity
    {
        public string comment {  get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public int userId { get; set; }
        public long ToursId { get; set; }
        public Tours Tours { get; set; }
    }
}
