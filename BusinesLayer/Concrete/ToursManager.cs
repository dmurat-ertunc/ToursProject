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

        public void TDelete(Tours entity)
        {
            entity.IsDeleted = true;
            toursDal.Update(entity);
        }

        public List<Tours> TGetAll()
        {
            return toursDal.GetAll();
        }

        public Tours TGetById(int id)
        {
            return toursDal.GetById(id);
        }

        public void TInsert(Tours entity)
        {
            toursDal.Add(entity);
        }

        public void TUpdate(Tours entity)
        {
            toursDal.Update(entity);
        }
    }
}
