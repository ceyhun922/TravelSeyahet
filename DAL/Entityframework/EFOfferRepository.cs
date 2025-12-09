using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFOfferRepository : GenericRepository<Offer>, IOfferDAL
    {
        private readonly Context _context;
        public EFOfferRepository(Context context) : base(context)
        {
            _context=context;
        }
    }
}