using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;

namespace DAL.Entityframework
{
    public class EFTourRepository : GenericRepository<Tour>, ITourDAL
    {
        public EFTourRepository(Context context) : base(context)
        {
        }
    }
}