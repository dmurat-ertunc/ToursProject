using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Stations : BaseEntity
    {
        public string station { get; set; }
        public long CitiesId { get; set; }
        public Cities Cities { get; set; }
        public ICollection<Tours> Tours { get; set; }

    }
}
