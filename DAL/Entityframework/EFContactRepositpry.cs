using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFContactRepositpry : GenericRepository<Contact>, IContactDAL
    {
        private readonly Context _context;
        public EFContactRepositpry(Context context) : base(context)
        {
            _context = context;
        }
    }
}