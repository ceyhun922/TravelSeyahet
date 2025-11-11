using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;
using ServicesLayer.Abstract;

namespace Services.Concrete
{
    public class TourManager : ITourService
    {
        private readonly ITourDAL _tourDAL;

        public TourManager(ITourDAL tourDAL)
        {
            _tourDAL = tourDAL;
        }

        public Tour GetFindIdService(int id)
        {
            return _tourDAL.GetFindId(id);
        }

        public void InsertService(Tour t)
        {
            _tourDAL.Insert(t);
        }

        public List<Tour> ListAllService()
        {
            return _tourDAL.ListAll();
        }

        public List<Tour> ListAllService(Expression<Func<Tour, bool>> filter)
        {
            return _tourDAL.ListAll(filter);
        }

        public void RemoveService(Tour t)
        {
            _tourDAL.Remove(t);
        }

        public void UpdateService(Tour t)
        {
            _tourDAL.Update(t);
        }
    }
}