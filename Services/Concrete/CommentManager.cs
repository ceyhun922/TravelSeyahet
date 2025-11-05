using System.Linq.Expressions;
using DAL.Abstract;
using EntityLayer.Concrete;
using ServicesLayer.Abstract;

namespace ServicesLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public Comment GetFindIdService(int id)
        {
            return _commentDAL.GetFindId(id);
        }

        public void InsertService(Comment t)
        {
            _commentDAL.Insert(t);
        }

        public List<Comment> ListAllService()
        {
            return _commentDAL.ListAll();
        }

        public List<Comment> ListAllService(Expression<Func<Comment, bool>> filter)
        {
            return _commentDAL.ListAll(filter);
        }

        public void RemoveService(Comment t)
        {
            _commentDAL.Remove(t);
        }

        public void UpdateService(Comment t)
        {
            _commentDAL.Update(t);
        }
    }
}