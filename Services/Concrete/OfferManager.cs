using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
    public class OfferManager : IOfferService
    {
        private readonly IOfferDAL _offerDAL;

        public OfferManager(IOfferDAL offerDAL)
        {
            _offerDAL = offerDAL;
        }

        public Offer GetFindIdService(int id)
        {
            return _offerDAL.GetFindId(id);
        }

        public void InsertService(Offer t)
        {
            _offerDAL.Insert(t);
        }

        public List<Offer> ListAllService()
        {
           return _offerDAL.ListAll().ToList();
        }

        public List<Offer> ListAllService(Expression<Func<Offer, bool>> filter)
        {
            return _offerDAL.ListAll(filter);
        }

        public void RemoveService(Offer t)
        {
            _offerDAL.Remove(t);
        }

        public void UpdateService(Offer t)
        {
            _offerDAL.Update(t);
        }
    }
}