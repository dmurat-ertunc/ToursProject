using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BaseEntity
    {
        public long Id { get; set; }  // Changed to 'Id' for PascalCase consistency
        public DateTime AddDate { get; set; } = DateTime.Now;  // Corrected to PascalCase
        public bool IsDeleted { get; set; } = false;  // Corrected to PascalCase
    }

}
