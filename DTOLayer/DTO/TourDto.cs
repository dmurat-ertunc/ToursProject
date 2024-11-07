using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTO
{
    public class TourDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public long ToursTimeId { get; set; }
        public string TourDayNight { get; set; }  // TourTime objesinden
        public string FotoUrl1 { get; set; }
        public string FotoUrl2 { get; set; }
        public string FotoUrl3 { get; set; }
        public DateTime TourDateTime { get; set; }
        public List<long> ServiceIds { get; set; }
        public List<string> ServiceNames { get; set; }
        public List<long> CityIds { get; set; }
        public List<string> CityNames { get; set; }
        public List<long> StationIds { get; set; }
        public List<string> StationNames { get; set; }
    }
}
