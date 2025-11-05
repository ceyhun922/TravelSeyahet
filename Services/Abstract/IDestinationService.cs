using DAL.Abstract;
using EntityLayer.Concrete;

namespace ServicesLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
{
    List<Destination> DestinationWithRotasionService(string userId);
    List<Destination> DestinationWithRotasionService(int id);
}
}