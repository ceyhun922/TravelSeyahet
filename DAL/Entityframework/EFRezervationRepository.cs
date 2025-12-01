using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entityframework
{
    public class EFRezervationRepository : GenericRepository<Rezervation>, IRezervationDAL
    {
        protected readonly Context _context;

        public EFRezervationRepository(Context context) : base(context)
        {
            _context = context;
        }
        public List<Rezervation> GetAllRezervationWithDestinationsDAL(string userId)
        {
            return _context.Rezervations
                    .Where(r => r.UserId == userId)
                    .Include(r => r.Destination)
                        .ThenInclude(d => d.Tours)
                    .ToList();

        }
    }
}