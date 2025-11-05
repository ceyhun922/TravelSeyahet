using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using EntityLayer.Concrete;

namespace DAL.Entityframework
{
    public class EFRezervationRepository : GenericRepository<Rezervation>, IRezervationDAL
    {
        protected readonly Context _context;

        public EFRezervationRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}