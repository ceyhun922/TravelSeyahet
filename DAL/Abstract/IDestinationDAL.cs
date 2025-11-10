using EntityLayer.Concrete;

namespace DAL.Abstract
{
    public interface IDestinationDAL : IGenericDAL<Destination>
    {
       public List<Destination> AllDestinationWithRotationDAL();
    }

}