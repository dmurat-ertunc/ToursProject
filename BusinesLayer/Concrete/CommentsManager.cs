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
    public class CommentsManager : ICommentsService
    {
        private readonly ICommentsDal commentsDal;

        public CommentsManager(ICommentsDal commentsDal)
        {
            this.commentsDal = commentsDal;
        }
        public void TDelete(Comments entity)
        {
            entity.IsDeleted = true;
            commentsDal.Update(entity);
        }

        public List<Comments> TGetAll()
        {
            return commentsDal.GetAll();
        }

        public Comments TGetById(int id)
        {
            return commentsDal.GetById(id);
        }

        public void TInsert(Comments entity)
        {
            commentsDal.Add(entity);
        }

        public void TUpdate(Comments entity)
        {
            commentsDal.Update(entity);
        }
    }
}
