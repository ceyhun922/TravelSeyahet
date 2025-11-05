using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFWriterRepository : GenericRepository<Writer>, IWriterDAL
    {
        protected readonly Context _context;

        public EFWriterRepository(Context context) : base(context)
        {
            _context = context;
        }
        
    }
}