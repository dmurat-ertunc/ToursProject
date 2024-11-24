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
    public class CitiesManager : ICitiesService
    {
        private readonly ICitiesDal citiesDal;

        public CitiesManager(ICitiesDal citiesDal)
        {
            this.citiesDal = citiesDal;
        }

        public void TDelete(Cities entity)
        {
            citiesDal.Delete(entity);
        }

        public async Task<List<Cities>> TGetAll()
        { 
            return await citiesDal.GetAll();
        }

        public Cities TGetById(int id)
        {
            return citiesDal.GetById(id);
        }

        public void TInsert(Cities entity)
        {
            citiesDal.Add(entity);
        }

        public void TUpdate(Cities entity)
        {
            citiesDal.Update(entity);
        }
    }
}
