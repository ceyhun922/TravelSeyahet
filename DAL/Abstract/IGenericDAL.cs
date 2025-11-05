using System.Linq.Expressions;

namespace DAL.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        List<T> ListAll();
        List<T> ListAll(Expression<Func<T, bool>> filter);
        T GetFindId(int id);
        void Insert(T t);
        void Update(T t);
        void Remove(T t);
    }
}