using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFSliderRepository : GenericRepository<Slider>, ISliderDAL
    {
        private readonly Context _context;
        public EFSliderRepository(Context context) : base(context)
        {
            _context =context;
        }
    }
}