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
    public class ContactManager : IContactService
    {
        private readonly IContactsDal contactsDal;
        public ContactManager(IContactsDal contactsDal)
        {
            this.contactsDal = contactsDal;
        }
        public void TDelete(Contact entity)
        {
            entity.IsDeleted = true;
            contactsDal.Update(entity);
        }

        public List<Contact> TGetAll()
        {
            return contactsDal.GetAll();
        }

        public Contact TGetById(int id)
        {
            return contactsDal.GetById(id);
        }

        public void TInsert(Contact entity)
        {
            contactsDal.Add(entity);
        }

        public void TUpdate(Contact entity)
        {
            contactsDal.Update(entity);
        }
    }
}
