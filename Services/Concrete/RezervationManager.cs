using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace ServicesLayer.Concrete
{
    public class RezervationManager : IRezervationService
    {
        private readonly IRezervationDAL _rezervationDAL;

        public RezervationManager(IRezervationDAL rezervationDAL)
        {
            _rezervationDAL = rezervationDAL;
        }

        public Rezervation GetFindIdService(int id)
        {
            return _rezervationDAL.GetFindId(id);
        }

        public void InsertService(Rezervation t)
        {
            _rezervationDAL.Insert(t);
        }

        public List<Rezervation> ListAllService()
        {
            return _rezervationDAL.ListAll();
        }

        public List<Rezervation> ListAllService(Expression<Func<Rezervation, bool>> filter)
        {
            return _rezervationDAL.ListAll(filter);
        }

        public void RemoveService(Rezervation t)
        {
            _rezervationDAL.Remove(t);
        }

        public void UpdateService(Rezervation t)
        {
            _rezervationDAL.Update(t);
        }
    }
}