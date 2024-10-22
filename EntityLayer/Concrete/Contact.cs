using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact : BaseEntity  // Corrected class name spelling and singular form
    {
        public string Name { get; set; }  // Corrected to PascalCase
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Surname { get; set; }  // Corrected spelling
        public string Email { get; set; }  // Changed 'mail' to 'Email'
        public string PhoneNumber { get; set; }  // Corrected to PascalCase
    }

}
