using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.TourDTO
{
    public class TourViewDTO
    {   
        public long Id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public long ToursTimeId { get; set; }
        public string TourDayNight { get; set; }
        public string fotoUrl1 { get; set; }
        public string fotoUrl2 { get; set; }
        public string fotoUrl3 { get; set; }
        public DateTime TourDateTime { get; set; }
        public List<long> ServiceIds { get; set; }
        public List<string> ServiceNames { get; set; }
        public List<long> CityIds { get; set; }
        public List<string> CityNames { get; set; }
        public List<long> StationIds { get; set; }
        public List<string> StationNames { get; set; }


    }
}
