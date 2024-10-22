using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TicketSold : BaseEntity  // Singular name for the entity
    {
        public string Name { get; set; }  // Corrected property name to PascalCase
        public string Email { get; set; }  // Changed 'mail' to 'Email' for clarity
        public string PhoneNumber { get; set; }  // Corrected to PascalCase
        public string PnrNo { get; set; }  // Corrected to PascalCase
        public string IdentityNo { get; set; }  // Corrected to PascalCase
        public long TourId { get; set; }  // Corrected class name from 'Tours' to 'Tour' and adjusted property name
        public Tours Tour { get; set; }  // Singular class name 'Tour'
    }

}
