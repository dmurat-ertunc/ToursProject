using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tours : BaseEntity
    {
        public string title { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public long ToursTimeId { get; set; }
        public TourTime TourTime { get; set; }
        public string fotoUrl1 { get; set; }
        public string fotoUrl2 { get; set; }
        public string fotoUrl3 { get; set; }
        public DateTime tourTime { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<TicketsSold> TicketsSolds { get; set; }
        public ICollection<Stations> Stations { get; set; }
        public ICollection<Services> Services { get; set; }
        public ICollection<Cities> Cities { get; set; }

    }
}
