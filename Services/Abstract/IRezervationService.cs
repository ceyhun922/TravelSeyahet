using Entities.Concrete;

namespace Services.Abstract
{
    public interface IRezervationService : IGenericService<Rezervation>
    {
       List<Rezervation> GetAllRezervationWithDestinationsService(string userId);
    }
}