using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFTestimonialRepository : GenericRepository<Testimonial>, ITestimonialDAL
    {
        private readonly Context _context;
        public EFTestimonialRepository(Context context) : base(context)
        {
            _context =context;
        }
    }
}