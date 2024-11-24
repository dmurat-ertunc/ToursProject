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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            this.socialMediaDal = socialMediaDal;
        }
        public void TDelete(SocialMedia entity)
        {
            entity.IsDeleted = true;
            socialMediaDal.Update(entity);
        }

        public async Task<List<SocialMedia>> TGetAll()
        {
            return await socialMediaDal.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return socialMediaDal.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            socialMediaDal.Add(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            socialMediaDal.Update(entity);
        }
    }
}
