using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SocialMedia : BaseEntity  // Corrected the class name
    {
        public string Instagram { get; set; }  // Corrected spelling and PascalCase
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Email { get; set; }  // Changed 'mail' to 'Email'
        public string PhoneNumber { get; set; }  // Corrected to PascalCase
    }

}
