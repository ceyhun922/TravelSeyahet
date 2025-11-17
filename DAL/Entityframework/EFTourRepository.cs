using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entityframework
{
    public class EFTourRepository : GenericRepository<Tour>, ITourDAL
    {
        protected readonly Context _context;
        public EFTourRepository(Context context) : base(context)
        {
            _context = context;
        }

        public List<Tour> AllToursWithDestinationsDAL()
        {
            return _context.Tours.Include(t=>t.Destination).ToList();
        }
    }
}