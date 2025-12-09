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

        public Tour AllToursWithDestinationAndGuideDAL(int id)
        {
            return
            _context.Tours.Where(t => t.TourStatus == true).Include(t => t.Destination).Include(t => t.Guide).FirstOrDefault(t=>t.TourId == id);

        }

        public List<Tour> AllToursWithRotasionsDAL(int rotasionId)
        {
            return _context.Tours.Include(t => t.Rotasions).Where(t => t.TourStatus == true && t.TourId == rotasionId).ToList();
        }

        public List<Tour> AllToursWithRotasionsDAL()
        {
            return _context.Tours.Include(x => x.Destination).Where(x => x.TourStatus == true && x.TourCountLimit > 0).ToList();
        }
    }
}