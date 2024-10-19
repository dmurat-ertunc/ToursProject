using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TicketsSold : BaseEntity
    {
        public string name {  get; set; }
        public string mail {  get; set; }
        public string phoneNumber {  get; set; }
        public string pnrNo {  get; set; }
        public string identityNo {  get; set; }
        public long ToursId { get; set; }
        public Tours Tours { get; set; }

    }
}
