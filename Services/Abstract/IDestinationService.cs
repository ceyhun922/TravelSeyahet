
using Entities.Concrete;

namespace Services.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public List<Destination> AllDestinationSubTourService();
    }
}