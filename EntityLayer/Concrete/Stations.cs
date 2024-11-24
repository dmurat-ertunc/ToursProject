using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Stations : BaseEntity
    {
        public string Name { get; set; }
        public long CityId { get; set; }
        public Cities City { get; set; }
        public virtual ICollection<Tours> Tours { get; set; }
    }

}
