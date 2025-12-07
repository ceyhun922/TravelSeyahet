
using DAL.Concrete;
using Entities.Concrete;

namespace DAL.Abstract
{
    
    public interface IRotasionDAL : IGenericDAL<Rotasion>
    {
        
        List<Rotasion> AllRotasionsWithTour();
    }
}