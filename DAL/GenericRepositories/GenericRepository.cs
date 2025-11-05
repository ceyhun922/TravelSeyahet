using System.Linq.Expressions;
using DAL.Abstract;
using DAL.Concrete;

namespace DAL.GenericRepositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public T GetFindId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }

        public List<T> ListAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Remove(T t)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
            _context.SaveChanges();
        }
    }
}