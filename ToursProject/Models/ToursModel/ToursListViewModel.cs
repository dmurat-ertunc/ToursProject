using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ToursProject.Models.ToursModel
{
    public class ToursListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int TourTimeId { get; set; }
        public string TourTimeDayNight { get; set; }
        public string Foto1 { get; set; }
        public string Foto2 { get; set; }
        public string Foto3 { get; set; }
        public List<int> StationId { get; set; }  // Set yerine List kullanılır
        public List<string> StationName { get; set; }  // Set yerine List kullanılır
        public List<int> CityId { get; set; }  // Set yerine List kullanılır
        public List<string> CityName { get; set; }  // Set yerine List kullanılır
        public List<int> ServiceId { get; set; }  // Set yerine List kullanılır
        public List<string> ServiceName { get; set; }  // Set yerine List kullanılır
    }
}
