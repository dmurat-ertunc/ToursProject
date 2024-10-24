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
    public class TicketSoldManager : ITicketSoldService
    {
        private readonly ITicketsSoldDal ticketsSoldDal;
        public TicketSoldManager(ITicketsSoldDal ticketsSoldDal)
        {
            this.ticketsSoldDal = ticketsSoldDal;
        }
        public void TDelete(TicketSold entity)
        {
            entity.IsDeleted = true;
            ticketsSoldDal.Update(entity);
        }

        public List<TicketSold> TGetAll()
        {
            return ticketsSoldDal.GetAll();
        }

        public TicketSold TGetById(int id)
        {
            return ticketsSoldDal.GetById(id);
        }

        public void TInsert(TicketSold entity)
        {
            ticketsSoldDal.Add(entity);
        }

        public void TUpdate(TicketSold entity)
        {
            ticketsSoldDal.Update(entity);
        }
    }
}
