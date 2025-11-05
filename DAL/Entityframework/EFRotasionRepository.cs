using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entityframework
{
    public class EFRotasionRepository : GenericRepository<Rotasion>, IRotasionDAL
    {
        protected readonly Context _context;
        public EFRotasionRepository(Context context) : base(context)
        {
             _context = context;
        }

    }
}