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
        public List<Rezervation> GetAllRezervationWithDestinationsDAL(int userId)
        {
            return _context.Rezervations
                    .Where(r => r.UserId == userId)
                    .Include(r => r.Destination)
                        .ThenInclude(d => d.Tours)
                    .ToList();

        }

        public List<Rezervation> GetMyAllRezervationDAL(int userId)
        {
            return _context.Rezervations.Where(x=>x.UserId ==userId).Include(x=>x.Destination).ThenInclude(x=>x.Tours).ThenInclude(x=>x.Rotasions).ToList();
        }
    }
}