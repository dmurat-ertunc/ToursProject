using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cities : BaseEntity  // Singular form for class name
{
    public string Name { get; set; }  // Corrected to PascalCase
    public ICollection<Stations> Stations { get; set; }  // Singular form for related class
    public ICollection<Tours> Tours { get; set; }  // Singular form for related class
}

}
