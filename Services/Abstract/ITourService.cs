using Entities.Concrete;

namespace Services.Abstract
{
    public interface ITourService : IGenericService<Tour>
    {
        public List<Tour> AllToursWithRotasionsService(int rotasionId);
        
    }
}