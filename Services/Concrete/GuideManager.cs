using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace ServicesLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        private readonly IGuideDAL _guideDAL;

        public GuideManager(IGuideDAL guideDAL)
        {
            _guideDAL = guideDAL;
        }

        public Guide GetFindIdService(int id)
        {
            return _guideDAL.GetFindId(id);
        }

        public void InsertService(Guide t)
        {
            _guideDAL.Insert(t);
        }

        public List<Guide> ListAllService()
        {
            return _guideDAL.ListAll();
        }

        public List<Guide> ListAllService(Expression<Func<Guide, bool>> filter)
        {
            return _guideDAL.ListAll(filter);
        }

        public void RemoveService(Guide t)
        {
            _guideDAL.Remove(t);
        }

        public void UpdateService(Guide t)
        {
            _guideDAL.Update(t);
        }
    }
}