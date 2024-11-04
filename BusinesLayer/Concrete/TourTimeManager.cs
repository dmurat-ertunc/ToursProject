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
    public class TourTimeManager : ITourTimeService
    {
        private readonly ITourTimeDal tourTimeDal;
        public TourTimeManager(ITourTimeDal tourTimeDal)
        {
            this.tourTimeDal=tourTimeDal;
        }

        public void TDelete(TourTime entity)
        {
            entity.IsDeleted = true;
            tourTimeDal.Update(entity);
        }

        public List<TourTime> TGetAll()
        {
            return tourTimeDal.GetAll();
        }

        public TourTime TGetById(int id)
        {
            return tourTimeDal.GetById(id);
        }

        public void TInsert(TourTime entity)
        {
            tourTimeDal.Add(entity);
        }

        public void TUpdate(TourTime entity)
        {
            tourTimeDal.Update(entity);
        }
    }
}
