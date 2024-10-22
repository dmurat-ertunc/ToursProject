using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Services : BaseEntity  // Singular form for class name
    {
        public string Name { get; set; }  // Corrected to PascalCase
        public ICollection<Tours> Tours { get; set; }  // Singular class name for Tour
    }

}
