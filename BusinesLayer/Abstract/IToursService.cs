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
        void TInsert(Tours entity);
        void TUpdate(Tours entity);
        void TDelete(Tours entity);
        List<Tours> TGetAll();
        Tours TGetById(int id);
    }
}
