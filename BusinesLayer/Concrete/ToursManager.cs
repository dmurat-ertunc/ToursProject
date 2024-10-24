using BusinesLayer.Abstract;
using DataAccesLayer.Abstract;
using DTOLayer.TourDTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class ToursManager : IToursService
    {
        private readonly IToursDal toursDal;
        private readonly TourMapper tourMapper;
        public ToursManager(IToursDal toursDal,TourMapper tourMapper)
        {
            this.toursDal = toursDal;
            this.tourMapper = tourMapper;
        }

        public void TDelete(TourViewDTO tourViewDTO)
        {
            Tours tours = tourMapper.MapDtoToTour(tourViewDTO);
            tours.IsDeleted = true;
            toursDal.Update(tours);
        }

        public List<TourViewDTO> TGetAll()
        {
            List<Tours> tourList = toursDal.GetAll().ToList();
            List<TourViewDTO> tourViewDTOs = null;
            foreach (var tours in tourList)
            {
                tourViewDTOs.Add(tourMapper.MapTourToDto(tours));
            }
            return tourViewDTOs;
        }

        public TourViewDTO TGetById(int id)
        {
            Tours tours = toursDal.GetById(id);
            return tourMapper.MapTourToDto(tours);
        }

        public void TInsert(TourViewDTO tourViewDTO)
        {
            Tours tours = tourMapper.MapDtoToTour(tourViewDTO);
            toursDal.Add(tours);
        }

        public void TUpdate(TourViewDTO tourViewDTO)
        {
            Tours tours = tourMapper.MapDtoToTour(tourViewDTO);
            toursDal.Add(tours);
        }
    }
}
