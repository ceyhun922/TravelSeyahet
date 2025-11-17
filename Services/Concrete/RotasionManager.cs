using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace ServicesLayer.Concrete
{
    public class RotasionManager : IRotasionService
    {
        private readonly IRotasionDAL _rotasionDAL;

        public RotasionManager(IRotasionDAL rotasionDAL)
        {
            _rotasionDAL = rotasionDAL;
        }

        public Rotasion GetFindIdService(int id)
        {
            return _rotasionDAL.GetFindId(id);
        }

        public void InsertService(Rotasion t)
        {
            _rotasionDAL.Insert(t);
        }

        public List<Rotasion> ListAllService()
        {
            return _rotasionDAL.ListAll();
        }

        public List<Rotasion> ListAllService(Expression<Func<Rotasion, bool>> filter)
        {
            return _rotasionDAL.ListAll(filter);
        }

        public void RemoveService(Rotasion t)
        {
            _rotasionDAL.Remove(t);
        }

        public void UpdateService(Rotasion t)
        {
            _rotasionDAL.Update(t);
        }
    }
}