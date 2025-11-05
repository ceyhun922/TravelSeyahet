using EntityLayer.Concrete;

namespace DAL.Abstract
{
    public interface IDestinationDAL : IGenericDAL<Destination>
    {
        List<Destination> DestinationWithRotasionDAL(string userId);
        List<Destination> DestinationWithRotasionDAL(int id);
    }

}