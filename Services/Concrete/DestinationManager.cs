using System.Linq.Expressions;
using DAL.Abstract;
using EntityLayer.Concrete;
using ServicesLayer.Abstract;

namespace ServicesLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDAL _destinationDAL;



        public DestinationManager(IDestinationDAL destinationDAL)
        {
            _destinationDAL = destinationDAL;
        }

        public List<Destination> DestinationWithRotasionService(int userId)
        {
            return _destinationDAL.DestinationWithRotasionDAL(userId);
        }

        public List<Destination> DestinationWithRotasionServicee(int id)
        {
            return _destinationDAL.DestinationWithRotasionDAL(id);
        }

        public Destination GetFindIdService(int id)
        {
            return _destinationDAL.GetFindId(id);
        }

        public void InsertService(Destination t)
        {
            _destinationDAL.Insert(t);
        }

        public List<Destination> ListAllService()
        {
            return _destinationDAL.ListAll();
        }

        public List<Destination> ListAllService(Expression<Func<Destination, bool>> filter)
        {
            return _destinationDAL.ListAll(filter);
        }

        public void RemoveService(Destination t)
        {
            _destinationDAL.Remove(t);
        }

        public void UpdateService(Destination t)
        {
            _destinationDAL.Update(t);
        }
    }
}