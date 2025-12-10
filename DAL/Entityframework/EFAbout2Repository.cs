using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFAbout2Repository : GenericRepository<About2>, IAbout2DAL
    {
        private readonly Context _context;
        public EFAbout2Repository(Context context) : base(context)
        {
            _context =context;
        }
    }
}