using EntityLayer.Concrete;

namespace DAL.Abstract
{
    public interface IDestinationDAL : IGenericDAL<Destination>
    {
        List<Destination> DestinationWithRotasionDAL(int userId);
        List<Destination> DestinationWithRotasionDALL(int id);
    }

}