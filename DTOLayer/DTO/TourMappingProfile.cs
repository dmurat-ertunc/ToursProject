using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTO
{
    public class TourMappingProfile 
    {
        public TourDto entityToDto(Tours tours)
        {
            TourDto tourDto = new TourDto();
            tourDto.Id = tours.Id;
            tourDto.Title = tourDto.Title;
            tourDto.Description = tourDto.Description;
            tourDto.Price = tourDto.Price;
            tourDto.ToursTimeId = tours.ToursTimeId;
            tourDto.TourDayNight = tours.TourTime.DayNight;
            tourDto.FotoUrl1 = tours.fotoUrl1;
            tourDto.FotoUrl2 = tours.fotoUrl2;
            tourDto.FotoUrl3 = tours.fotoUrl3;
            tourDto.TourDateTime = tours.TourDateTime;
            tourDto.ServiceIds = tours.Services.Select(s => s.Id).ToList();
            tourDto.ServiceNames = tours.Services.Select(s => s.Name).ToList();  // Services'ten isimleri alır
            tourDto.CityIds = tours.Cities.Select(c => c.Id).ToList();  // Cities'ten ID'leri alır
            tourDto.CityNames = tours.Cities.Select(c => c.Name).ToList();  // Cities'ten isimleri alır
            tourDto.StationIds = tours.Stations.Select(st => st.Id).ToList();  // Stations'tan ID'leri alır
            tourDto.StationNames = tours.Stations.Select(st => st.Name).ToList();

            return tourDto;
        }
    }
}
