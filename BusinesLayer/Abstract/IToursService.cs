using DTOLayer.TourDTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IToursService
    {
        void TInsert(TourViewDTO entity);
        void TUpdate(TourViewDTO entity);
        void TDelete(TourViewDTO entity);
        List<TourViewDTO> TGetAll();
        TourViewDTO TGetById(int id);
    }
}
