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
    public class ServicesManager : IServicesService
    {
        private readonly IServiceDal serviceDal;
        public ServicesManager(IServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }
        public void TDelete(Services entity)
        {
            entity.IsDeleted = true;
            serviceDal.Update(entity);
        }

        public List<Services> TGetAll()
        {
            return serviceDal.GetAll();
        }

        public Services TGetById(int id)
        {
            return serviceDal.GetById(id);
        }

        public void TInsert(Services entity)
        {
            serviceDal.Add(entity);
        }

        public void TUpdate(Services entity)
        {
            serviceDal.Update(entity);
        }
    }
}
