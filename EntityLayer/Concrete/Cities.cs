using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cities : BaseEntity
    {
        public string name {  get; set; }
        public ICollection<Stations> Stations { get; set; }
        public ICollection<Tours> Tours { get; set; }

    }
}
