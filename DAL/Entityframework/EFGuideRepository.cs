using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using EntityLayer.Concrete;

namespace DAL.Entityframework
{
    public class EFGuideRepository : GenericRepository<Guide>, IGuideDAL
    {
        protected readonly Context _context;

        public EFGuideRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}