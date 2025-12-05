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

        public List<Tour> AllToursWithRotasionsDAL(int rotasionId)
        {
            return _context.Tours.Include(t=>t.Rotasions).Where(t=>t.TourId ==rotasionId).ToList();
        }

        public List<Tour> AllToursWithRotasionsDAL()
        {
            return _context.Tours.Include(x=>x.Destination).Where(x=>x.TourStatus==true).ToList();
        }
    }
}