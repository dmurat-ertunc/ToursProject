using BusinesLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DTOLayer.DTO;
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
        public TourMappingProfile tourMappingProfile;
        public ToursManager(IToursDal toursDal)
        {
            this.toursDal = toursDal;
        }

        public void TDelete(Tours entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Tours>> TGetAll()
        {
            return await toursDal.GetAll();
        }

        public Tours TGetById(int id)
        {
            return toursDal.GetById(id);
        }

        public void TInsert(Tours tours)
        {
            toursDal.Add(tours);
        }

        public void TUpdate(Tours tours)
        {
            toursDal.Update(tours);
        }
    }
}
