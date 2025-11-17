using Entities.Concrete;

namespace DAL.Abstract
{
    public interface ITourDAL : IGenericDAL<Tour>
    {
        public List<Tour> AllToursWithDestinationsDAL();
    }
}