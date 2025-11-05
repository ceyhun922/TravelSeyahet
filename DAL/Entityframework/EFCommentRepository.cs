using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using EntityLayer.Concrete;

namespace DAL.Entityframework
{
    public class EFCommentRepository : GenericRepository<Comment>, ICommentDAL
    {
        protected readonly Context _context;


        public EFCommentRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}