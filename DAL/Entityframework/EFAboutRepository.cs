using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFAboutRepository : GenericRepository<About>, IAboutDAL
    {
        private readonly Context _context;
        public EFAboutRepository(Context context) : base(context)
        {
            _context =context;
        }
    }
}