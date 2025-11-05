using System.Linq.Expressions;

namespace ServicesLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> ListAllService();
        List<T> ListAllService(Expression<Func<T, bool>> filter);
        T GetFindIdService(int id);
        void InsertService(T t);
        void UpdateService(T t);
        void RemoveService(T t);
    }
}