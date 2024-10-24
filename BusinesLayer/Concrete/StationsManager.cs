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
    public class StationsManager : IStationsService
    {
        private readonly IStationsDal stationsDal;
        public StationsManager(IStationsDal stationsDal)
        {
            this.stationsDal = stationsDal;
        }
        public void TDelete(Stations entity)
        {
            entity.IsDeleted = true;
            stationsDal.Update(entity);
        }

        public List<Stations> TGetAll()
        {
            return stationsDal.GetAll();
        }

        public Stations TGetById(int id)
        {
            return (stationsDal.GetById(id));
        }

        public void TInsert(Stations entity)
        {
            stationsDal.Add(entity);
        }

        public void TUpdate(Stations entity)
        {
            stationsDal.Update(entity);
        }
    }
}
