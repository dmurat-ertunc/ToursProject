using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTOLayer.TourDTO
{
    public class TourMapper
    {
        public TourViewDTO MapTourToDto(Tours tour)
        {
            var tourDto = new TourViewDTO
            {
                Id = tour.Id,
                title = tour.title,
                description = tour.description,
                price = tour.price,
                ToursTimeId = tour.ToursTimeId,
                TourDayNight = tour.TourTime?.DayNight, // İlişkili `TourTime` objesinden
                fotoUrl1 = tour.fotoUrl1,
                fotoUrl2 = tour.fotoUrl2,
                fotoUrl3 = tour.fotoUrl3,
                TourDateTime = tour.TourDateTime,
                ServiceIds = tour.Services?.Select(s => s.Id).ToList(),  // Services'ten ID'leri alır
                ServiceNames = tour.Services?.Select(s => s.Name).ToList(),  // Services'ten isimleri alır
                CityIds = tour.Cities?.Select(c => c.Id).ToList(),  // Cities'ten ID'leri alır
                CityNames = tour.Cities?.Select(c => c.Name).ToList(),  // Cities'ten isimleri alır
                StationIds = tour.Stations?.Select(st => st.Id).ToList(),  // Stations'tan ID'leri alır
                StationNames = tour.Stations?.Select(st => st.Name).ToList()  // Stations'tan isimleri alır
            };
            return tourDto;
        }
        public Tours MapDtoToTour(TourViewDTO dto)
        {
            var tour = new Tours
            {
                title = dto.title,
                description = dto.description,
                price = dto.price,
                ToursTimeId = dto.ToursTimeId,
                fotoUrl1 = dto.fotoUrl1,
                fotoUrl2 = dto.fotoUrl2,
                fotoUrl3 = dto.fotoUrl3,
                TourDateTime = dto.TourDateTime,
                // İlişkili alanlar ID üzerinden tekrar yüklenebilir (örnek: `Services` tablosundan ID ile kayıt bulunabilir)
                Services = dto.ServiceIds?.Select(id => new Services { Id = id }).ToList(),
                Cities = dto.CityIds?.Select(id => new Cities { Id = id }).ToList(),
                Stations = dto.StationIds?.Select(id => new Stations { Id = id }).ToList()
            };

            return tour;
        }
    }
}
