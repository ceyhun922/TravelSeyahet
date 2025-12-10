using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2DAL _about2DAL;

        public About2Manager(IAbout2DAL aboutDAL)
        {
            _about2DAL = aboutDAL;
        }
        public About2 GetFindIdService(int id)
        {
            return _about2DAL.GetFindId(id);
        }

        public void InsertService(About2 t)
        {
            _about2DAL.Insert(t);
        }

        public List<About2> ListAllService()
        {
            return _about2DAL.ListAll();
        }

        public List<About2> ListAllService(Expression<Func<About2, bool>> filter)
        {
            return _about2DAL.ListAll(filter);

        }

        public void RemoveService(About2 t)
        {
            _about2DAL.Remove(t);
        }

        public void UpdateService(About2 t)
        {
            _about2DAL.Update(t);
        }
    }
}