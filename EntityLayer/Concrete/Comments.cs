using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comments : BaseEntity  // Singular form for class name
    {
        public string Text { get; set; }  // Changed 'comment' to 'Text' for clarity
        public string Name { get; set; }  // Corrected to PascalCase
        public string Surname { get; set; }  // Corrected spelling
        public int UserId { get; set; }
        public long TourId { get; set; }  // Corrected property name and class name
        public Tours Tour { get; set; }  // Singular form for class name
    }

}
