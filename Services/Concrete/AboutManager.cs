

using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
    public class AboutManager : IAboutService
    {
         private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public About GetFindIdService(int id)
        {
            return _aboutDAL.GetFindId(id);
        }

        public void InsertService(About t)
        {
           _aboutDAL.Insert(t);
        }

        public List<About> ListAllService()
        {
            return _aboutDAL.ListAll();
        }

        public List<About> ListAllService(Expression<Func<About, bool>> filter)
        {
           return _aboutDAL.ListAll(filter);
        }

        public void RemoveService(About t)
        {
            _aboutDAL.Remove(t);
        }

        public void UpdateService(About t)
        {
            _aboutDAL.Update(t);
        }
    }
}