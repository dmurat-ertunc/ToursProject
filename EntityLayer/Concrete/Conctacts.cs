using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Conctacts : BaseEntity
    {
        public string name {  get; set; }
        public string subject {  get; set; }
        public string message {  get; set; }
        public string surName {  get; set; }
        public string mail {  get; set; }
        public string phoneNumber {  get; set; }
    }
}
