using Entities.Concrete;

namespace DAL.Abstract
{
    public interface IRezervationDAL : IGenericDAL<Rezervation>
    {
        List<Rezervation> GetAllRezervationWithDestinationsDAL(int userId);

        List<Rezervation> GetMyAllRezervationDAL(int userId);
    }
}