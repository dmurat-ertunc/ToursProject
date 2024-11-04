using BusinesLayer.Abstract;
using DataAccesLayer.Abstract;
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
        public ToursManager(IToursDal toursDal)
        {
            this.toursDal = toursDal;
        }

        public void TDelete(Tours tours)
        {
            tours.IsDeleted = true;
            toursDal.Update(tours);
        }

        public List<Tours> TGetAll()
        {
            return toursDal.GetAll();
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
