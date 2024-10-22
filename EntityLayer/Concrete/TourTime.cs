using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TourTime : BaseEntity
    {
        public string DayNight { get; set; }  
        public ICollection<Tours> Tours { get; set; }  
    }

}
