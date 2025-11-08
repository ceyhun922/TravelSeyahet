using DAL.Abstract;
using EntityLayer.Concrete;

namespace ServicesLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
{
    List<Destination> DestinationWithRotasionService(int userId);
    List<Destination> DestinationWithRotasionServicee(int id);
}
}